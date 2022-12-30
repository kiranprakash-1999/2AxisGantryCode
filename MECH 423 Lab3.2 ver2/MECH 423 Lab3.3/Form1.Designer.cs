namespace WindowsFormsApp1
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
            this.isSerialConnectedLabel = new System.Windows.Forms.Label();
            this.escByteTextbox = new System.Windows.Forms.TextBox();
            this.highByteTextbox = new System.Windows.Forms.TextBox();
            this.lowByteTextbox = new System.Windows.Forms.TextBox();
            this.cmdByteTextbox = new System.Windows.Forms.TextBox();
            this.escByteLabel = new System.Windows.Forms.Label();
            this.cmdByteLabel = new System.Windows.Forms.Label();
            this.highByteLabel = new System.Windows.Forms.Label();
            this.lowByteLabel = new System.Windows.Forms.Label();
            this.serialPortButton = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dutyCycleValTextbox = new System.Windows.Forms.TextBox();
            this.dutyCycleValLabel = new System.Windows.Forms.Label();
            this.Resting = new System.Windows.Forms.Label();
            this.maxCwVelocity = new System.Windows.Forms.Label();
            this.maxCcwVelocity = new System.Windows.Forms.Label();
            this.velocitySliderLabel = new System.Windows.Forms.Label();
            this.velocityControlBar = new System.Windows.Forms.TrackBar();
            this.pwmLabel = new System.Windows.Forms.Label();
            this.dutyCycle = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).BeginInit();
            this.SuspendLayout();
            // 
            // isSerialConnectedLabel
            // 
            this.isSerialConnectedLabel.AutoSize = true;
            this.isSerialConnectedLabel.Location = new System.Drawing.Point(229, 12);
            this.isSerialConnectedLabel.Name = "isSerialConnectedLabel";
            this.isSerialConnectedLabel.Size = new System.Drawing.Size(79, 13);
            this.isSerialConnectedLabel.TabIndex = 39;
            this.isSerialConnectedLabel.Text = "Not Connected";
            // 
            // escByteTextbox
            // 
            this.escByteTextbox.Location = new System.Drawing.Point(483, 173);
            this.escByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.escByteTextbox.Name = "escByteTextbox";
            this.escByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.escByteTextbox.TabIndex = 38;
            // 
            // highByteTextbox
            // 
            this.highByteTextbox.Location = new System.Drawing.Point(486, 122);
            this.highByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.highByteTextbox.Name = "highByteTextbox";
            this.highByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.highByteTextbox.TabIndex = 37;
            // 
            // lowByteTextbox
            // 
            this.lowByteTextbox.Location = new System.Drawing.Point(486, 86);
            this.lowByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.lowByteTextbox.Name = "lowByteTextbox";
            this.lowByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.lowByteTextbox.TabIndex = 36;
            // 
            // cmdByteTextbox
            // 
            this.cmdByteTextbox.Location = new System.Drawing.Point(486, 44);
            this.cmdByteTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.cmdByteTextbox.Name = "cmdByteTextbox";
            this.cmdByteTextbox.Size = new System.Drawing.Size(73, 20);
            this.cmdByteTextbox.TabIndex = 28;
            // 
            // escByteLabel
            // 
            this.escByteLabel.AutoSize = true;
            this.escByteLabel.Location = new System.Drawing.Point(434, 173);
            this.escByteLabel.Name = "escByteLabel";
            this.escByteLabel.Size = new System.Drawing.Size(45, 13);
            this.escByteLabel.TabIndex = 35;
            this.escByteLabel.Text = "escByte";
            // 
            // cmdByteLabel
            // 
            this.cmdByteLabel.AutoSize = true;
            this.cmdByteLabel.Location = new System.Drawing.Point(434, 47);
            this.cmdByteLabel.Name = "cmdByteLabel";
            this.cmdByteLabel.Size = new System.Drawing.Size(48, 13);
            this.cmdByteLabel.TabIndex = 34;
            this.cmdByteLabel.Text = "cmdByte";
            // 
            // highByteLabel
            // 
            this.highByteLabel.AutoSize = true;
            this.highByteLabel.Location = new System.Drawing.Point(434, 125);
            this.highByteLabel.Name = "highByteLabel";
            this.highByteLabel.Size = new System.Drawing.Size(50, 13);
            this.highByteLabel.TabIndex = 33;
            this.highByteLabel.Text = "HighByte";
            // 
            // lowByteLabel
            // 
            this.lowByteLabel.AutoSize = true;
            this.lowByteLabel.Location = new System.Drawing.Point(434, 89);
            this.lowByteLabel.Name = "lowByteLabel";
            this.lowByteLabel.Size = new System.Drawing.Size(48, 13);
            this.lowByteLabel.TabIndex = 32;
            this.lowByteLabel.Text = "LowByte";
            // 
            // serialPortButton
            // 
            this.serialPortButton.Location = new System.Drawing.Point(112, 8);
            this.serialPortButton.Margin = new System.Windows.Forms.Padding(1);
            this.serialPortButton.Name = "serialPortButton";
            this.serialPortButton.Size = new System.Drawing.Size(113, 21);
            this.serialPortButton.TabIndex = 31;
            this.serialPortButton.Text = "Connect Serial Port";
            this.serialPortButton.UseVisualStyleBackColor = true;
            this.serialPortButton.Click += new System.EventHandler(this.serialPortButton_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(14, 8);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(91, 21);
            this.ComboBox.TabIndex = 30;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(409, 139);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stepper Motor Interface";
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
            this.velocityControlBar.Location = new System.Drawing.Point(65, 78);
            this.velocityControlBar.Margin = new System.Windows.Forms.Padding(1);
            this.velocityControlBar.Maximum = 100;
            this.velocityControlBar.Minimum = -100;
            this.velocityControlBar.Name = "velocityControlBar";
            this.velocityControlBar.Size = new System.Drawing.Size(279, 45);
            this.velocityControlBar.SmallChange = 20;
            this.velocityControlBar.TabIndex = 6;
            this.velocityControlBar.TickFrequency = 20;
            this.velocityControlBar.Scroll += new System.EventHandler(this.velocityControlBar_Scroll);
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
            // dutyCycle
            // 
            this.dutyCycle.Location = new System.Drawing.Point(110, 26);
            this.dutyCycle.Margin = new System.Windows.Forms.Padding(1);
            this.dutyCycle.Name = "dutyCycle";
            this.dutyCycle.Size = new System.Drawing.Size(73, 20);
            this.dutyCycle.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isSerialConnectedLabel;
        private System.Windows.Forms.TextBox escByteTextbox;
        private System.Windows.Forms.TextBox highByteTextbox;
        private System.Windows.Forms.TextBox lowByteTextbox;
        private System.Windows.Forms.TextBox cmdByteTextbox;
        private System.Windows.Forms.Label escByteLabel;
        private System.Windows.Forms.Label cmdByteLabel;
        private System.Windows.Forms.Label highByteLabel;
        private System.Windows.Forms.Label lowByteLabel;
        private System.Windows.Forms.Button serialPortButton;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dutyCycleValTextbox;
        private System.Windows.Forms.Label dutyCycleValLabel;
        private System.Windows.Forms.Label Resting;
        private System.Windows.Forms.Label maxCwVelocity;
        private System.Windows.Forms.Label maxCcwVelocity;
        private System.Windows.Forms.Label velocitySliderLabel;
        private System.Windows.Forms.TrackBar velocityControlBar;
        private System.Windows.Forms.Label pwmLabel;
        private System.Windows.Forms.TextBox dutyCycle;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

