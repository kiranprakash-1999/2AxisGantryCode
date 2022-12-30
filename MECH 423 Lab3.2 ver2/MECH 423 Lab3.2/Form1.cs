using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MECH_423_Lab3._2
{

    public partial class Form1 : Form
    {
        int Direction = 1;
        int DutyCycleHighBit = 0;
        int DutyCycleLowBit = 0;
        int EscapeByte = 0;
        int dutyCycleVal; // 16 bit value of duty cycle from -65535 to 65535
        byte[] byteData = new byte[5];


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

        private void Form1_Load(object sender, EventArgs e)
        {

            //COMPort.PortName = "COM3";

            ComboBox.Items.Clear();
            ComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (ComboBox.Items.Count == 0)
                ComboBox.Text = "No COM ports!";
            else
                ComboBox.SelectedIndex = 0;

            //timer1.Start();


        }

    }
}