namespace MECH_423_Lab3._2
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
            this.dutyCycle = new System.Windows.Forms.TextBox();
            this.pwmLabel = new System.Windows.Forms.Label();
            this.velocityControlBar = new System.Windows.Forms.TrackBar();
            this.velocitySliderLabel = new System.Windows.Forms.Label();
            this.maxCcwVelocity = new System.Windows.Forms.Label();
            this.maxCwVelocity = new System.Windows.Forms.Label();
            this.Resting = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dutyCycleValTextbox = new System.Windows.Forms.TextBox();
            this.dutyCycleValLabel = new System.Windows.Forms.Label();
            this.stepperMotorGroupBox = new System.Windows.Forms.GroupBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lowByteLabel = new System.Windows.Forms.Label();
            this.highByteLabel = new System.Windows.Forms.Label();
            this.cmdByteLabel = new System.Windows.Forms.Label();
            this.escByteLabel = new System.Windows.Forms.Label();
            this.cmdByteTextbox = new System.Windows.Forms.TextBox();
            this.lowByteTextbox = new System.Windows.Forms.TextBox();
            this.highByteTextbox = new System.Windows.Forms.TextBox();
            this.escByteTextbox = new System.Windows.Forms.TextBox();
            this.isSerialConnectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dutyCycle
            // 
            this.dutyCycle.Location = new System.Drawing.Point(110, 26);
            this.dutyCycle.Margin = new System.Windows.Forms.Padding(1);
            this.dutyCycle.Name = "dutyCycle";
            this.dutyCycle.Size = new System.Drawing.Size(73, 20);
            this.dutyCycle.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(7, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(409, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DC Motor Interface";
            // 
            // dutyCycleValTextbox
            // 
            this.dutyCycleValTextbox.Location = new System.Drawing.Point(299, 26);
            this.dutyCycleValTextbox.Name = "dutyCycleValTextbox";
            this.dutyCycleValTextbox.Size = new System.Drawing.Size(100, 20);
            this.dutyCycleValTextbox.TabIndex = 26;
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
            // stepperMotorGroupBox
            // 
            this.stepperMotorGroupBox.Location = new System.Drawing.Point(7, 200);
            this.stepperMotorGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.stepperMotorGroupBox.Name = "stepperMotorGroupBox";
            this.stepperMotorGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.stepperMotorGroupBox.Size = new System.Drawing.Size(409, 188);
            this.stepperMotorGroupBox.TabIndex = 14;
            this.stepperMotorGroupBox.TabStop = false;
            this.stepperMotorGroupBox.Text = "Stepper Motor Interface";
            this.stepperMotorGroupBox.UseCompatibleTextRendering = true;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(11, 10);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(91, 21);
            this.ComboBox.TabIndex = 15;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPorts_SelectedIndexChanged);
            // 
            // serialPortButton
            // 
            this.serialPortButton.Location = new System.Drawing.Point(109, 10);
            this.serialPortButton.Margin = new System.Windows.Forms.Padding(1);
            this.serialPortButton.Name = "serialPortButton";
            this.serialPortButton.Size = new System.Drawing.Size(113, 21);
            this.serialPortButton.TabIndex = 16;
            this.serialPortButton.Text = "Connect Serial Port";
            this.serialPortButton.UseVisualStyleBackColor = true;
            this.serialPortButton.Click += new System.EventHandler(this.serialPortButton_Click);
            // 
            // lowByteLabel
            // 
            this.lowByteLabel.AutoSize = true;
            this.lowByteLabel.Location = new System.Drawing.Point(431, 91);
            this.lowByteLabel.Name = "lowByteLabel";
            this.lowByteLabel.Size = new System.Drawing.Size(48, 13);
            this.lowByteLabel.TabIndex = 17;
            this.lowByteLabel.Text = "LowByte";
            // 
            // highByteLabel
            // 
            this.highByteLabel.AutoSize = true;
            this.highByteLabel.Location = new System.Drawing.Point(431, 127);
            this.highByteLabel.Name = "highByteLabel";
            this.highByteLabel.Size = new System.Drawing.Size(50, 13);
            this.highByteLabel.TabIndex = 18;
            this.highByteLabel.Text = "HighByte";
            // 
            // cmdByteLabel
            // 
            this.cmdByteLabel.AutoSize = true;
            this.cmdByteLabel.Location = new System.Drawing.Point(431, 49);
            this.cmdByteLabel.Name = "cmdByteLabel";
            this.cmdByteLabel.Size = new System.Drawing.Size(48, 13);
            this.cmdByteLabel.TabIndex = 19;
            this.cmdByteLabel.Text = "cmdByte";
            // 
            // escByteLabel
            // 
            this.escByteLabel.AutoSize = true;
            this.escByteLabel.Location = new System.Drawing.Point(431, 175);
            this.escByteLabel.Name = "escByteLabel";
            this.escByteLabel.Size = new System.Drawing.Size(45, 13);
            this.escByteLabel.TabIndex = 20;
            this.escByteLabel.Text = "escByte";
            // 
            // cmdByteTextbox
            // 
            this.cmdByteTextbox.Location = new System.Drawing.Point(483, 46);
            this.cmdByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.cmdByteTextbox.Name = "cmdByteTextbox";
            this.cmdByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.cmdByteTextbox.TabIndex = 11;
            // 
            // lowByteTextbox
            // 
            this.lowByteTextbox.Location = new System.Drawing.Point(483, 88);
            this.lowByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.lowByteTextbox.Name = "lowByteTextbox";
            this.lowByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.lowByteTextbox.TabIndex = 21;
            // 
            // highByteTextbox
            // 
            this.highByteTextbox.Location = new System.Drawing.Point(483, 124);
            this.highByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.highByteTextbox.Name = "highByteTextbox";
            this.highByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.highByteTextbox.TabIndex = 22;
            // 
            // escByteTextbox
            // 
            this.escByteTextbox.Location = new System.Drawing.Point(480, 175);
            this.escByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.escByteTextbox.Name = "escByteTextbox";
            this.escByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.escByteTextbox.TabIndex = 23;
            // 
            // isSerialConnectedLabel
            // 
            this.isSerialConnectedLabel.AutoSize = true;
            this.isSerialConnectedLabel.Location = new System.Drawing.Point(226, 14);
            this.isSerialConnectedLabel.Name = "isSerialConnectedLabel";
            this.isSerialConnectedLabel.Size = new System.Drawing.Size(79, 13);
            this.isSerialConnectedLabel.TabIndex = 27;
            this.isSerialConnectedLabel.Text = "Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 336);
            this.Controls.Add(this.isSerialConnectedLabel);
            this.Controls.Add(this.escByteTextbox);
            this.Controls.Add(this.highByteTextbox);
            this.Controls.Add(this.lowByteTextbox);
            this.Controls.Add(this.cmdByteTextbox);
            this.Controls.Add(this.escByteLabel);
            this.Controls.Add(this.cmdByteLabel);
            this.Controls.Add(this.highByteLabel);
            this.Controls.Add(this.lowByteLabel);
            this.Controls.Add(this.serialPortButton);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.stepperMotorGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dutyCycle;
        private System.Windows.Forms.Label pwmLabel;
        private System.Windows.Forms.TrackBar velocityControlBar;
        private System.Windows.Forms.Label velocitySliderLabel;
        private System.Windows.Forms.Label maxCcwVelocity;
        private System.Windows.Forms.Label maxCwVelocity;
        private System.Windows.Forms.Label Resting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox stepperMotorGroupBox;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button serialPortButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lowByteLabel;
        private System.Windows.Forms.Label highByteLabel;
        private System.Windows.Forms.Label cmdByteLabel;
        private System.Windows.Forms.Label escByteLabel;
        private System.Windows.Forms.TextBox cmdByteTextbox;
        private System.Windows.Forms.TextBox lowByteTextbox;
        private System.Windows.Forms.TextBox highByteTextbox;
        private System.Windows.Forms.TextBox escByteTextbox;
        private System.Windows.Forms.TextBox dutyCycleValTextbox;
        private System.Windows.Forms.Label dutyCycleValLabel;
        private System.Windows.Forms.Label isSerialConnectedLabel;
    }
}

