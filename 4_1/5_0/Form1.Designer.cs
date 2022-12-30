namespace _5_0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.highByteTextbox = new System.Windows.Forms.TextBox();
            this.lowByteTextbox = new System.Windows.Forms.TextBox();
            this.cmdByteTextbox = new System.Windows.Forms.TextBox();
            this.escByteLabel = new System.Windows.Forms.Label();
            this.cmdByteLabel = new System.Windows.Forms.Label();
            this.dutyCycleValTextbox = new System.Windows.Forms.TextBox();
            this.highByteLabel = new System.Windows.Forms.Label();
            this.dutyCycleValLabel = new System.Windows.Forms.Label();
            this.flagTextbox = new System.Windows.Forms.TextBox();
            this.serialPortButton = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Resting = new System.Windows.Forms.Label();
            this.maxCwVelocity = new System.Windows.Forms.Label();
            this.maxCcwVelocity = new System.Windows.Forms.Label();
            this.velocitySliderLabel = new System.Windows.Forms.Label();
            this.velocityControlBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.flagLabel = new System.Windows.Forms.Label();
            this.lowByteLabel = new System.Windows.Forms.Label();
            this.pwmLabel = new System.Windows.Forms.Label();
            this.isSerialConnectedLabel = new System.Windows.Forms.Label();
            this.dutyCycle = new System.Windows.Forms.TextBox();
            this.hzTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rpmLabel = new System.Windows.Forms.Label();
            this.rpmTextbox = new System.Windows.Forms.TextBox();
            this.positionTextbox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.hzLabel = new System.Windows.Forms.Label();
            this.escByteTextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.positionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.positionInputTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.positionInputButton = new System.Windows.Forms.Button();
            this.inputSpeedTextbox = new System.Windows.Forms.TextBox();
            this.inputSpeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // highByteTextbox
            // 
            this.highByteTextbox.Location = new System.Drawing.Point(479, 49);
            this.highByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.highByteTextbox.Name = "highByteTextbox";
            this.highByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.highByteTextbox.TabIndex = 76;
            // 
            // lowByteTextbox
            // 
            this.lowByteTextbox.Location = new System.Drawing.Point(479, 73);
            this.lowByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.lowByteTextbox.Name = "lowByteTextbox";
            this.lowByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.lowByteTextbox.TabIndex = 75;
            // 
            // cmdByteTextbox
            // 
            this.cmdByteTextbox.Location = new System.Drawing.Point(479, 27);
            this.cmdByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.cmdByteTextbox.Name = "cmdByteTextbox";
            this.cmdByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.cmdByteTextbox.TabIndex = 67;
            // 
            // escByteLabel
            // 
            this.escByteLabel.AutoSize = true;
            this.escByteLabel.Location = new System.Drawing.Point(433, 94);
            this.escByteLabel.Name = "escByteLabel";
            this.escByteLabel.Size = new System.Drawing.Size(45, 13);
            this.escByteLabel.TabIndex = 74;
            this.escByteLabel.Text = "escByte";
            // 
            // cmdByteLabel
            // 
            this.cmdByteLabel.AutoSize = true;
            this.cmdByteLabel.Location = new System.Drawing.Point(427, 27);
            this.cmdByteLabel.Name = "cmdByteLabel";
            this.cmdByteLabel.Size = new System.Drawing.Size(48, 13);
            this.cmdByteLabel.TabIndex = 73;
            this.cmdByteLabel.Text = "cmdByte";
            // 
            // dutyCycleValTextbox
            // 
            this.dutyCycleValTextbox.Location = new System.Drawing.Point(299, 26);
            this.dutyCycleValTextbox.Name = "dutyCycleValTextbox";
            this.dutyCycleValTextbox.Size = new System.Drawing.Size(100, 20);
            this.dutyCycleValTextbox.TabIndex = 26;
            // 
            // highByteLabel
            // 
            this.highByteLabel.AutoSize = true;
            this.highByteLabel.Location = new System.Drawing.Point(427, 52);
            this.highByteLabel.Name = "highByteLabel";
            this.highByteLabel.Size = new System.Drawing.Size(50, 13);
            this.highByteLabel.TabIndex = 72;
            this.highByteLabel.Text = "HighByte";
            // 
            // dutyCycleValLabel
            // 
            this.dutyCycleValLabel.AutoSize = true;
            this.dutyCycleValLabel.Location = new System.Drawing.Point(202, 27);
            this.dutyCycleValLabel.Name = "dutyCycleValLabel";
            this.dutyCycleValLabel.Size = new System.Drawing.Size(91, 13);
            this.dutyCycleValLabel.TabIndex = 25;
            this.dutyCycleValLabel.Text = "16-Bit Duty Cycle:";
            // 
            // flagTextbox
            // 
            this.flagTextbox.Location = new System.Drawing.Point(479, 4);
            this.flagTextbox.Name = "flagTextbox";
            this.flagTextbox.Size = new System.Drawing.Size(73, 20);
            this.flagTextbox.TabIndex = 85;
            // 
            // serialPortButton
            // 
            this.serialPortButton.Location = new System.Drawing.Point(108, 10);
            this.serialPortButton.Margin = new System.Windows.Forms.Padding(1);
            this.serialPortButton.Name = "serialPortButton";
            this.serialPortButton.Size = new System.Drawing.Size(113, 21);
            this.serialPortButton.TabIndex = 70;
            this.serialPortButton.Text = "Connect Serial Port";
            this.serialPortButton.UseVisualStyleBackColor = true;
            this.serialPortButton.Click += new System.EventHandler(this.serialPortButton_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(10, 10);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(91, 21);
            this.ComboBox.TabIndex = 69;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // Resting
            // 
            this.Resting.AutoSize = true;
            this.Resting.Location = new System.Drawing.Point(202, 99);
            this.Resting.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Resting.Name = "Resting";
            this.Resting.Size = new System.Drawing.Size(13, 13);
            this.Resting.TabIndex = 10;
            this.Resting.Text = "0";
            // 
            // maxCwVelocity
            // 
            this.maxCwVelocity.AutoSize = true;
            this.maxCwVelocity.Location = new System.Drawing.Point(346, 78);
            this.maxCwVelocity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.maxCwVelocity.Name = "maxCwVelocity";
            this.maxCwVelocity.Size = new System.Drawing.Size(54, 13);
            this.maxCwVelocity.TabIndex = 9;
            this.maxCwVelocity.Text = "100% CW";
            // 
            // maxCcwVelocity
            // 
            this.maxCcwVelocity.AutoSize = true;
            this.maxCcwVelocity.Location = new System.Drawing.Point(4, 78);
            this.maxCcwVelocity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.maxCcwVelocity.Name = "maxCcwVelocity";
            this.maxCcwVelocity.Size = new System.Drawing.Size(61, 13);
            this.maxCcwVelocity.TabIndex = 8;
            this.maxCcwVelocity.Text = "100% CCW";
            // 
            // velocitySliderLabel
            // 
            this.velocitySliderLabel.AutoSize = true;
            this.velocitySliderLabel.Location = new System.Drawing.Point(116, 58);
            this.velocitySliderLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.velocitySliderLabel.Name = "velocitySliderLabel";
            this.velocitySliderLabel.Size = new System.Drawing.Size(180, 13);
            this.velocitySliderLabel.TabIndex = 7;
            this.velocitySliderLabel.Text = "Velocity Control Slider (% Duty Cycle)";
            // 
            // velocityControlBar
            // 
            this.velocityControlBar.LargeChange = 6550;
            this.velocityControlBar.Location = new System.Drawing.Point(65, 78);
            this.velocityControlBar.Margin = new System.Windows.Forms.Padding(1);
            this.velocityControlBar.Maximum = 65535;
            this.velocityControlBar.Minimum = -65535;
            this.velocityControlBar.Name = "velocityControlBar";
            this.velocityControlBar.Size = new System.Drawing.Size(279, 45);
            this.velocityControlBar.SmallChange = 50;
            this.velocityControlBar.TabIndex = 6;
            this.velocityControlBar.TickFrequency = 6550;
            this.velocityControlBar.Scroll += new System.EventHandler(this.velocityControlBar_Scroll);
            this.velocityControlBar.ValueChanged += new System.EventHandler(this.velocityControlBar_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "start Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Location = new System.Drawing.Point(433, 9);
            this.flagLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(27, 13);
            this.flagLabel.TabIndex = 86;
            this.flagLabel.Text = "Flag";
            // 
            // lowByteLabel
            // 
            this.lowByteLabel.AutoSize = true;
            this.lowByteLabel.Location = new System.Drawing.Point(430, 78);
            this.lowByteLabel.Name = "lowByteLabel";
            this.lowByteLabel.Size = new System.Drawing.Size(48, 13);
            this.lowByteLabel.TabIndex = 71;
            this.lowByteLabel.Text = "LowByte";
            // 
            // pwmLabel
            // 
            this.pwmLabel.AutoSize = true;
            this.pwmLabel.Location = new System.Drawing.Point(1, 27);
            this.pwmLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pwmLabel.Name = "pwmLabel";
            this.pwmLabel.Size = new System.Drawing.Size(105, 13);
            this.pwmLabel.TabIndex = 2;
            this.pwmLabel.Text = "PWM Duty Cycle (%)";
            // 
            // isSerialConnectedLabel
            // 
            this.isSerialConnectedLabel.AutoSize = true;
            this.isSerialConnectedLabel.Location = new System.Drawing.Point(225, 14);
            this.isSerialConnectedLabel.Name = "isSerialConnectedLabel";
            this.isSerialConnectedLabel.Size = new System.Drawing.Size(79, 13);
            this.isSerialConnectedLabel.TabIndex = 78;
            this.isSerialConnectedLabel.Text = "Not Connected";
            // 
            // dutyCycle
            // 
            this.dutyCycle.Location = new System.Drawing.Point(110, 26);
            this.dutyCycle.Margin = new System.Windows.Forms.Padding(1);
            this.dutyCycle.Name = "dutyCycle";
            this.dutyCycle.Size = new System.Drawing.Size(73, 20);
            this.dutyCycle.TabIndex = 1;
            // 
            // hzTextbox
            // 
            this.hzTextbox.Location = new System.Drawing.Point(557, 117);
            this.hzTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.hzTextbox.Name = "hzTextbox";
            this.hzTextbox.Size = new System.Drawing.Size(85, 20);
            this.hzTextbox.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dutyCycleValTextbox);
            this.groupBox1.Controls.Add(this.dutyCycleValLabel);
            this.groupBox1.Controls.Add(this.Resting);
            this.groupBox1.Controls.Add(this.maxCwVelocity);
            this.groupBox1.Controls.Add(this.maxCcwVelocity);
            this.groupBox1.Controls.Add(this.velocitySliderLabel);
            this.groupBox1.Controls.Add(this.velocityControlBar);
            this.groupBox1.Controls.Add(this.pwmLabel);
            this.groupBox1.Controls.Add(this.dutyCycle);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(409, 139);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DC Motor Interface";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Location = new System.Drawing.Point(423, 137);
            this.rpmLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(128, 13);
            this.rpmLabel.TabIndex = 84;
            this.rpmLabel.Text = "Rotational Velocity (RPM)";
            // 
            // rpmTextbox
            // 
            this.rpmTextbox.Location = new System.Drawing.Point(557, 139);
            this.rpmTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.rpmTextbox.Name = "rpmTextbox";
            this.rpmTextbox.Size = new System.Drawing.Size(85, 20);
            this.rpmTextbox.TabIndex = 83;
            // 
            // positionTextbox
            // 
            this.positionTextbox.Location = new System.Drawing.Point(557, 160);
            this.positionTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.positionTextbox.Name = "positionTextbox";
            this.positionTextbox.Size = new System.Drawing.Size(85, 20);
            this.positionTextbox.TabIndex = 82;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(461, 160);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 81;
            this.PositionLabel.Text = "Position";
            // 
            // hzLabel
            // 
            this.hzLabel.AutoSize = true;
            this.hzLabel.Location = new System.Drawing.Point(427, 116);
            this.hzLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hzLabel.Name = "hzLabel";
            this.hzLabel.Size = new System.Drawing.Size(117, 13);
            this.hzLabel.TabIndex = 80;
            this.hzLabel.Text = "Rotational Velocity (Hz)";
            // 
            // escByteTextbox
            // 
            this.escByteTextbox.Location = new System.Drawing.Point(479, 95);
            this.escByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.escByteTextbox.Name = "escByteTextbox";
            this.escByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.escByteTextbox.TabIndex = 77;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // positionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.positionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.positionChart.Legends.Add(legend1);
            this.positionChart.Location = new System.Drawing.Point(4, 192);
            this.positionChart.Name = "positionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.positionChart.Series.Add(series1);
            this.positionChart.Size = new System.Drawing.Size(400, 300);
            this.positionChart.TabIndex = 88;
            this.positionChart.Text = "Position Chart";
            // 
            // positionInputTextbox
            // 
            this.positionInputTextbox.Location = new System.Drawing.Point(557, 182);
            this.positionInputTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.positionInputTextbox.Name = "positionInputTextbox";
            this.positionInputTextbox.Size = new System.Drawing.Size(85, 20);
            this.positionInputTextbox.TabIndex = 90;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 17);
            this.textBox1.TabIndex = 91;
            // 
            // positionInputButton
            // 
            this.positionInputButton.Location = new System.Drawing.Point(436, 176);
            this.positionInputButton.Name = "positionInputButton";
            this.positionInputButton.Size = new System.Drawing.Size(90, 23);
            this.positionInputButton.TabIndex = 89;
            this.positionInputButton.Text = "enter Position";
            this.positionInputButton.UseVisualStyleBackColor = true;
            this.positionInputButton.Click += new System.EventHandler(this.positionInputButton_Click);
            // 
            // inputSpeedTextbox
            // 
            this.inputSpeedTextbox.Location = new System.Drawing.Point(557, 206);
            this.inputSpeedTextbox.Name = "inputSpeedTextbox";
            this.inputSpeedTextbox.Size = new System.Drawing.Size(85, 20);
            this.inputSpeedTextbox.TabIndex = 93;
            // 
            // inputSpeedButton
            // 
            this.inputSpeedButton.Location = new System.Drawing.Point(436, 205);
            this.inputSpeedButton.Name = "inputSpeedButton";
            this.inputSpeedButton.Size = new System.Drawing.Size(90, 23);
            this.inputSpeedButton.TabIndex = 92;
            this.inputSpeedButton.Text = "Set Speed";
            this.inputSpeedButton.UseVisualStyleBackColor = true;
            this.inputSpeedButton.Click += new System.EventHandler(this.inputSpeedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputSpeedTextbox);
            this.Controls.Add(this.inputSpeedButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.positionInputTextbox);
            this.Controls.Add(this.positionInputButton);
            this.Controls.Add(this.positionChart);
            this.Controls.Add(this.highByteTextbox);
            this.Controls.Add(this.lowByteTextbox);
            this.Controls.Add(this.cmdByteTextbox);
            this.Controls.Add(this.escByteLabel);
            this.Controls.Add(this.cmdByteLabel);
            this.Controls.Add(this.highByteLabel);
            this.Controls.Add(this.flagTextbox);
            this.Controls.Add(this.serialPortButton);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.lowByteLabel);
            this.Controls.Add(this.isSerialConnectedLabel);
            this.Controls.Add(this.hzTextbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.rpmTextbox);
            this.Controls.Add(this.positionTextbox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.hzLabel);
            this.Controls.Add(this.escByteTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox highByteTextbox;
        private System.Windows.Forms.TextBox lowByteTextbox;
        private System.Windows.Forms.TextBox cmdByteTextbox;
        private System.Windows.Forms.Label escByteLabel;
        private System.Windows.Forms.Label cmdByteLabel;
        private System.Windows.Forms.TextBox dutyCycleValTextbox;
        private System.Windows.Forms.Label highByteLabel;
        private System.Windows.Forms.Label dutyCycleValLabel;
        private System.Windows.Forms.TextBox flagTextbox;
        private System.Windows.Forms.Button serialPortButton;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label Resting;
        private System.Windows.Forms.Label maxCwVelocity;
        private System.Windows.Forms.Label maxCcwVelocity;
        private System.Windows.Forms.Label velocitySliderLabel;
        private System.Windows.Forms.TrackBar velocityControlBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Label lowByteLabel;
        private System.Windows.Forms.Label pwmLabel;
        private System.Windows.Forms.Label isSerialConnectedLabel;
        private System.Windows.Forms.TextBox dutyCycle;
        private System.Windows.Forms.TextBox hzTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.TextBox rpmTextbox;
        private System.Windows.Forms.TextBox positionTextbox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label hzLabel;
        private System.Windows.Forms.TextBox escByteTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart positionChart;
        private System.Windows.Forms.TextBox positionInputTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button positionInputButton;
        private System.Windows.Forms.TextBox inputSpeedTextbox;
        private System.Windows.Forms.Button inputSpeedButton;
    }
}

