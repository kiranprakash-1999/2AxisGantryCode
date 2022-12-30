using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Direction = 1;
        int DutyCycleHighBit = 0;
        int DutyCycleLowBit = 0;
        int EscapeByte = 0;
        double dutyCycleVal; // 16 bit value of duty cycle from -65535 to 65535
        byte[] byteData = new byte[5];
  
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            ComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (ComboBox.Items.Count == 0)
                ComboBox.Text = "No COM ports!";
            else
                ComboBox.SelectedIndex = 0;
        }

        private void velocityControlBar_Scroll(object sender, EventArgs e)
        {
            dutyCycleVal = velocityControlBar.Value;
            //Make the PWM value positive if its negative, but store the sign in a variable as -1 and 1
            if (dutyCycleVal == 0)
            {
                dutyCycleVal = 0;
            } 
            else if (dutyCycleVal < 0)
            {
                Direction = 0;
                dutyCycleVal = ((1 * velocityControlBar.Value/99.0 * 23040 + 25832));
            }
            else
            {
                Direction = 1;
                dutyCycleVal = ((-1 * velocityControlBar.Value/99.0 * 23040 + 25832));
            }

            dutyCycleValTextbox.Text = Convert.ToString(dutyCycleVal);

            DutyCycleHighBit = Convert.ToInt32(dutyCycleVal / 256);
            DutyCycleLowBit = Convert.ToInt32(dutyCycleVal) % 256;

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

        }
    }
}
