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



namespace MECH_423_Lab3._2
{

    public partial class Form1 : Form
    {
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        List<int> hList = new List<int>();
        List<int> lList = new List<int>();
        int packetState = 0;


        //motor speed variables
        int Direction = 1;
        int DutyCycleHighBit = 0;
        int DutyCycleLowBit = 0;
        int EscapeByte = 0;
        int dutyCycleVal; // 16 bit value of duty cycle from -65535 to 65535
        byte[] byteData = new byte[5];

        //encoder variables
        int buffer;
        int start, cmd, dataH, dataL, esc;
        int position;
        int encDir = 0;
        int numLOverFlow = 0;
        int numHOverFlow = 0;
        double velocity; //Hz
        int cpr = 260; //counts per rev
        double tps = 0.04; //time per sample, in seconds (40ms)

        public Form1()
        {
            InitializeComponent();


        }


        private void velocityControlBar_Scroll(object sender, EventArgs e)
        {

            //Output the PWM value to the textbox
            dutyCycleVal = velocityControlBar.Value;
            dutyCycleValTextbox.Text = Convert.ToString(dutyCycleVal);
            dutyCycle.Text = Convert.ToString(dutyCycleVal * 100 / 65536);

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

            cmdByteTextbox.Text = Direction.ToString();
            lowByteTextbox.Text = DutyCycleLowBit.ToString();
            highByteTextbox.Text = DutyCycleHighBit.ToString();
            escByteTextbox.Text = EscapeByte.ToString();

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

            //letterA[0] = 'A';
            //COMPort.Write(letterA, 0, letterA.Length);


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

        private void serialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Acquire COM port from combo box
            if (ComboBox.SelectedItem != null)
            {
                //ComboBoxItem cbi1 = (ComboBoxItem)(sender as ComboBox).SelectedItem;
                serialPort1.PortName = Convert.ToString(ComboBox.SelectedItem);
                //textDataStream.Text= COMPort.PortName;
            }
            //Configure COM port on SerialPort object

        }

        private void serialPortButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //COMPort.PortName = "COM3";

            ComboBox.Items.Clear();
            ComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (ComboBox.Items.Count == 0)
                ComboBox.Text = "No COM ports!";
            else
                ComboBox.SelectedIndex = 0;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
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
            dataQueue.TryDequeue(out buffer);
            while (buffer!= 255) //dequeue until you read start byte (ie. start of packet)
            {
                dataQueue.TryDequeue(out buffer);
            }
            //unload packet from dataQueue.
            start = buffer;
            dataQueue.TryDequeue(out cmd);
            dataQueue.TryDequeue(out dataH);
            dataQueue.TryDequeue(out dataL);
            dataQueue.TryDequeue(out esc);

            if (esc == 1)
            {
                dataH = 255;
            }
            else if(esc == 2){
                dataL = 255;
            }
            else if(esc == 3)
            {
                dataH = 255;
                dataL = 255;
            }
            esc = 0;
            hList.Add(dataH);
            lList.Add(dataL);

            // if, in each list, there are 2 items (successive counts)
            if (hList.Count == lList.Count && hList.Count == 2)
            {
                //check direction
                if (hList[1] - hList[0] == 0 && lList[1] - lList[0] != 0)
                {
                    encDir = 0;
                }
                else if (hList[1] - hList[0] != 0 && lList[1] - lList[0] == 0)
                {
                    encDir = 1;
                }

                if (encDir == 0)
                {
                    //check for low byte overflow (ie. when dataL counts resets from 255)
                    if (lList[1] - lList[0] < 0)
                    {
                        numLOverFlow++;
                        velocity = -1*(lList[1] + 255 - lList[0]) / tps / cpr;
                    }
                    else
                    {
                        velocity = -1*(lList[1] - lList[0]) / tps / cpr;
                    }
                }

                if (encDir == 1)
                {
                    //check for overflow (ie. when dataH counts resets from 255)
                    if (hList[1] - hList[0] < 0)
                    {
                        numHOverFlow++;
                        velocity = (hList[1] + 255 - hList[0]) / tps / cpr;
                    }
                    else
                    {
                        velocity = (hList[1] - hList[0]) / tps / cpr;
                    }
                }

                position = (numHOverFlow - numLOverFlow)*cpr + (hList[1] - lList[1]);

                hzTextbox.Text = velocity.ToString();
                positionTextbox.Text = position.ToString();

                //      hList.Clear();
                //     lList.Clear();

                hList[1] = hList[0];
                lList[1] = lList[0];

                hList.RemoveAt(0); //.Remove() removes the first occurence of h
                lList.RemoveAt(0);

            }
            //packet now converted







        }
    }
}