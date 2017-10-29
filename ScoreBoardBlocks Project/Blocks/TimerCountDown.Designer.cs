namespace WindowsFormsApplication1.Blocks
{
    partial class TimerCountDown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.minusOneButton = new System.Windows.Forms.Button();
            this.plusOneButton = new System.Windows.Forms.Button();
            this.currentTimeTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.stopButton);
            this.groupBox.Controls.Add(this.startButton);
            this.groupBox.Controls.Add(this.secondsTextBox);
            this.groupBox.Controls.Add(this.minuteTextBox);
            this.groupBox.Controls.Add(this.minusOneButton);
            this.groupBox.Controls.Add(this.plusOneButton);
            this.groupBox.Controls.Add(this.currentTimeTextBox);
            this.groupBox.Controls.Add(this.changeButton);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Timer Count Down:";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(55, 84);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(89, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(55, 55);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(89, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(43, 121);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(31, 20);
            this.secondsTextBox.TabIndex = 5;
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(6, 121);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(31, 20);
            this.minuteTextBox.TabIndex = 5;
            // 
            // minusOneButton
            // 
            this.minusOneButton.Location = new System.Drawing.Point(6, 84);
            this.minusOneButton.Name = "minusOneButton";
            this.minusOneButton.Size = new System.Drawing.Size(43, 23);
            this.minusOneButton.TabIndex = 4;
            this.minusOneButton.Text = "-1";
            this.minusOneButton.UseVisualStyleBackColor = true;
            // 
            // plusOneButton
            // 
            this.plusOneButton.Location = new System.Drawing.Point(6, 55);
            this.plusOneButton.Name = "plusOneButton";
            this.plusOneButton.Size = new System.Drawing.Size(43, 23);
            this.plusOneButton.TabIndex = 4;
            this.plusOneButton.Text = "+1";
            this.plusOneButton.UseVisualStyleBackColor = true;
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeTextBox.Location = new System.Drawing.Point(6, 23);
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.ReadOnly = true;
            this.currentTimeTextBox.Size = new System.Drawing.Size(138, 26);
            this.currentTimeTextBox.TabIndex = 3;
            this.currentTimeTextBox.Text = "0";
            this.currentTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(81, 119);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(63, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // TimerCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "TimerCountDown";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.Button minusOneButton;
        private System.Windows.Forms.Button plusOneButton;
        private System.Windows.Forms.TextBox currentTimeTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
    }
}
