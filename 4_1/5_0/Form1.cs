using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _5_0
{
    public partial class Form1 : Form
    {


        //motor speed variables
        int Direction = 1;
        int DutyCycleHighBit = 0;
        int DutyCycleLowBit = 0;
        int EscapeByte = 0;
        int dutyCycleVal = 65534; // 16 bit value of duty cycle from -65535 to 65535
        byte[] byteData = new byte[5];

        //encoder variables
        int start, cmd, dataH, dataL, esc;
        double position = 0;
        int encDir = 0; //encoder direction
        int numLOverFlow = 0;
        int numHOverFlow = 0;
        double velocity; //Hz
        int cpr = 260; //counts per rev
        double tps = 0.066; //time per sample, in seconds (equal to timer interrupt speed)
       
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        int hList0, hList1, lList0, lList1;
        int count = 0;


        //plotting variables
        double time = 0;
        double[] x = new double[100];
        double[] y1 = new double[100];
        double[] y2 = new double[100];
        int j = 0;


        //timer variables
        int i = 0;
        bool isTimerOn = false;

        //test variables
        double pastPosition = 0;

        //control system variables and functions
        double inputPosition;
        bool isInputSet = false;

        // function in timer loop to output specific PWM to motor based on position andPositionInput
        // using global variables for consistency, instead of arguments
        double errPosition; //variable that stores the position error, scaled by Kp.
        double Kp = -10;
        void setPosition ()
        {
            if (isInputSet)
            {
                errPosition = Kp*(inputPosition - position);

                // change pwm signal based on errPosition, saturate pwm signal based on motors physical limits (min and max speed)
                // max is 100% duty cycle, min is 0%;
                

                //saturate PWM
                if (errPosition >= 65535)
                {
                    dutyCycleVal = 65535;
                }
                else if (errPosition <= -65535)
                {
                    dutyCycleVal = -65535;
                }
                else
                {
                    dutyCycleVal = Convert.ToInt32(errPosition);
                }
                velocityControlBar.Value = dutyCycleVal;
            }
                
        }

        void sendPacket(int cmdSpecial)
        {
            
            //Make the PWM value positive if its negative, but store the sign in a variable as -1 and 1
            if (dutyCycleVal < 0)
            {
            Direction = 0;
            }
            else
            {
            Direction = 1;
            }
            
            DutyCycleHighBit = Math.Abs(dutyCycleVal / 256);
            DutyCycleLowBit = Math.Abs(dutyCycleVal) % 256;

            //Combine the PWM and directions values in the queue/just send the values to the controller in the right format
            if (DutyCycleLowBit == 255 & DutyCycleHighBit == 255)
            {
                EscapeByte = 3;
                DutyCycleLowBit = 0;
                DutyCycleHighBit = 0;
            }
            else if (DutyCycleHighBit == 255)
            {
                EscapeByte = 1;
                DutyCycleHighBit = 0;
            }
            else if (DutyCycleLowBit == 255)
            {
                EscapeByte = 2;
                DutyCycleLowBit = 0;
            }
            else
            {
                EscapeByte = 0;
            }

            byteData[0] = (byte)255;
            byteData[1] = (byte)Direction;
            byteData[2] = (byte)DutyCycleHighBit;
            byteData[3] = (byte)DutyCycleLowBit;
            byteData[4] = (byte)EscapeByte;

            serialPort1.Write(byteData, 0, 1);
            serialPort1.Write(byteData, 1, 1);
            serialPort1.Write(byteData, 2, 1);
            serialPort1.Write(byteData, 3, 1);
            serialPort1.Write(byteData, 4, 1);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPort1.BytesToRead;
            int newByte = 0;


            while (bytesToRead != 0)
            {
                newByte = serialPort1.ReadByte();
                dataQueue.Enqueue(newByte);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flagTextbox.Text = dataQueue.Count.ToString();
            if (dataQueue.Count >= 5)
            {
                if (!dataQueue.TryDequeue(out i))
                {
                    flagLabel.Text = "0";
                }
                while (i != 255)
                {
                    dataQueue.TryDequeue(out i);
                }
                start = i;

                if (!dataQueue.TryDequeue(out cmd))
                {
                    flagLabel.Text = "1";
                }
                if (!dataQueue.TryDequeue(out dataH))
                {
                    flagLabel.Text = "2";
                }
                if (!dataQueue.TryDequeue(out dataL))
                {
                    flagLabel.Text = "3";
                }
                if (!dataQueue.TryDequeue(out esc))
                {
                    flagLabel.Text = "4";
                }
                if (esc == 1)
                {
                    dataH = 255;
                }
                else if (esc == 2)
                {
                    dataL = 255;
                }
                else if (esc == 3)
                {
                    dataH = 255;
                    dataL = 255;
                }
                esc = 0;
                cmdByteTextbox.Text = cmd.ToString();
                highByteTextbox.Text = dataH.ToString();
                lowByteTextbox.Text = dataL.ToString();
                escByteTextbox.Text = esc.ToString();
                //packet converted


                if (cmd == 0)
                {
                    if (count == 0)
                    {
                        hList0 = dataH;
                        lList0 = dataL;
                        count++;

                    }
                    else if (count == 1)
                    {
                        hList1 = dataH;
                        lList1 = dataL;
                        count++;
                    }

                    // if, in each list, there are 2 items (successive counts)
                    else if (count == 2)
                    {
                        //shuffle list inputs:
                        //old present input becomes new past input, then add new present input
                        hList0 = hList1;
                        lList0 = lList1;

                        hList1 = dataH;
                        lList1 = dataL;

                        //check direction
                        if (hList1 - hList0 == 0 && lList1 - lList0 != 0)
                        {
                            encDir = 0;
                        }
                        else if (hList1 - hList0 != 0 && lList1 - lList0 == 0)
                        {
                            encDir = 1;
                        }

                        if (encDir == 0)
                        {
                            //check for low byte overflow (ie. when dataL counts resets from 255)
                            if (lList1 - lList0 < 0)
                            {
                                numLOverFlow++;
                                velocity = -1 * (lList1 + 255 - lList0) / tps / cpr;
                            }
                            else
                            {
                                velocity = -1 * (lList1 - lList0) / tps / cpr;
                            }
                        }

                        if (encDir == 1)
                        {
                            //check for rollover (ie. when dataH counts resets from 255)
                            if (hList1 - hList0 < 0)
                            {
                                numHOverFlow++;
                                velocity = (hList1 + 255 - hList0) / tps / cpr;
                            }
                            else
                            {
                                velocity = (hList1 - hList0) / tps / cpr;
                            }
                        }

                        if (position - pastPosition < 0)
                        {
                            flagLabel.Text = "Down";
                        }
                        else
                        {
                            flagLabel.Text = "Up";
                        }

                        pastPosition = position;
                        position = (numHOverFlow - numLOverFlow) * cpr + (hList1 - lList1);

                        hzTextbox.Text = velocity.ToString();
                        positionTextbox.Text = position.ToString();

                        positionChart.Series[0].Points.AddXY(time, position);
                        time += tps;
                        if (j < 800)
                        {
                            j++;
                        }
                        else                 //scroll through points in chart
                        {
                            positionChart.Series[0].Points.RemoveAt(0);
                            positionChart.ChartAreas[0].RecalculateAxesScale();
                        }
                         setPosition();
                    }
                }
                else if (cmd == 2 || cmd == 3)
                {
                    textBox1.Text = start.ToString() + " + " +
                                    cmd.ToString() + " + " +
                                    dataH.ToString() + " + " +
                                    dataL.ToString() + " + " +
                                    esc.ToString();
                }


            }

        }

        private void velocityControlBar_ValueChanged(object sender, EventArgs e)
        {
            //Output the PWM value to the textbox
            dutyCycleVal = velocityControlBar.Value;
            dutyCycleValTextbox.Text = Convert.ToString(dutyCycleVal);
            dutyCycle.Text = Convert.ToString(dutyCycleVal * 100 / 65536);

            sendPacket(0);
        }

        private void inputSpeedButton_Click(object sender, EventArgs e)
        {
            dutyCycleVal = Convert.ToInt32(inputSpeedTextbox.Text);
            velocityControlBar.Value = dutyCycleVal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isTimerOn)
            {
                timer1.Enabled = true;
                isTimerOn = true;
            }
            else
            {
                timer1.Enabled = false;
                isTimerOn = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void positionInputButton_Click(object sender, EventArgs e)
        {
            inputPosition = Convert.ToDouble(positionInputTextbox.Text);
          //  dutyCycleVal = 65000;
            isInputSet = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            ComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (ComboBox.Items.Count == 0)
                ComboBox.Text = "No COM ports!";
            else
                ComboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Acquire COM port from combo box
            if (ComboBox.SelectedItem != null)
            {
                serialPort1.PortName = Convert.ToString(ComboBox.SelectedItem);
            }
            //Configure COM port on SerialPort object
        }

        private void serialPortButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.PortName != null)
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    isSerialConnectedLabel.Text = "Connected";
                }
                else
                {
                    serialPort1.Close();
                    isSerialConnectedLabel.Text = "Not Connected";
                }
            }


        }

        private void velocityControlBar_Scroll(object sender, EventArgs e)
        {
            //Output the PWM value to the textbox
            dutyCycleVal = velocityControlBar.Value;
            dutyCycleValTextbox.Text = Convert.ToString(dutyCycleVal);
            dutyCycle.Text = Convert.ToString(dutyCycleVal * 100 / 65536);

            sendPacket(0);


        }




    }
}
