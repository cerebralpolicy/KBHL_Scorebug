namespace WindowsFormsApplication1.Blocks
{
    partial class IncrementalNumerical
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.quickChangeTextBox = new System.Windows.Forms.TextBox();
            this.minusCustomButton = new System.Windows.Forms.Button();
            this.minusOneButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusCustomButton = new System.Windows.Forms.Button();
            this.plusOneButton = new System.Windows.Forms.Button();
            this.currentNumberTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.quickChangeTextBox);
            this.groupBox.Controls.Add(this.minusCustomButton);
            this.groupBox.Controls.Add(this.minusOneButton);
            this.groupBox.Controls.Add(this.zeroButton);
            this.groupBox.Controls.Add(this.plusCustomButton);
            this.groupBox.Controls.Add(this.plusOneButton);
            this.groupBox.Controls.Add(this.currentNumberTextBox);
            this.groupBox.Controls.Add(this.changeButton);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Incremental Numerical:";
            // 
            // quickChangeTextBox
            // 
            this.quickChangeTextBox.Location = new System.Drawing.Point(6, 121);
            this.quickChangeTextBox.Name = "quickChangeTextBox";
            this.quickChangeTextBox.Size = new System.Drawing.Size(69, 20);
            this.quickChangeTextBox.TabIndex = 5;
            // 
            // minusCustomButton
            // 
            this.minusCustomButton.Location = new System.Drawing.Point(101, 84);
            this.minusCustomButton.Name = "minusCustomButton";
            this.minusCustomButton.Size = new System.Drawing.Size(43, 23);
            this.minusCustomButton.TabIndex = 4;
            this.minusCustomButton.Text = "-7";
            this.minusCustomButton.UseVisualStyleBackColor = true;
            this.minusCustomButton.Click += new System.EventHandler(this.minusCustomButton_Click);
            // 
            // minusOneButton
            // 
            this.minusOneButton.Location = new System.Drawing.Point(101, 55);
            this.minusOneButton.Name = "minusOneButton";
            this.minusOneButton.Size = new System.Drawing.Size(43, 23);
            this.minusOneButton.TabIndex = 4;
            this.minusOneButton.Text = "-1";
            this.minusOneButton.UseVisualStyleBackColor = true;
            this.minusOneButton.Click += new System.EventHandler(this.minusOneButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(55, 84);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(40, 23);
            this.zeroButton.TabIndex = 4;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // plusCustomButton
            // 
            this.plusCustomButton.Location = new System.Drawing.Point(6, 84);
            this.plusCustomButton.Name = "plusCustomButton";
            this.plusCustomButton.Size = new System.Drawing.Size(43, 23);
            this.plusCustomButton.TabIndex = 4;
            this.plusCustomButton.Text = "+7";
            this.plusCustomButton.UseVisualStyleBackColor = true;
            this.plusCustomButton.Click += new System.EventHandler(this.plusCustomButton_Click);
            // 
            // plusOneButton
            // 
            this.plusOneButton.Location = new System.Drawing.Point(6, 55);
            this.plusOneButton.Name = "plusOneButton";
            this.plusOneButton.Size = new System.Drawing.Size(43, 23);
            this.plusOneButton.TabIndex = 4;
            this.plusOneButton.Text = "+1";
            this.plusOneButton.UseVisualStyleBackColor = true;
            this.plusOneButton.Click += new System.EventHandler(this.plusOneButton_Click);
            // 
            // currentNumberTextBox
            // 
            this.currentNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNumberTextBox.Location = new System.Drawing.Point(6, 23);
            this.currentNumberTextBox.Name = "currentNumberTextBox";
            this.currentNumberTextBox.ReadOnly = true;
            this.currentNumberTextBox.Size = new System.Drawing.Size(138, 26);
            this.currentNumberTextBox.TabIndex = 3;
            this.currentNumberTextBox.Text = "0";
            this.currentNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(81, 119);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(63, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // IncrementalNumerical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "IncrementalNumerical";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox quickChangeTextBox;
        private System.Windows.Forms.Button minusCustomButton;
        private System.Windows.Forms.Button minusOneButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusCustomButton;
        private System.Windows.Forms.Button plusOneButton;
        private System.Windows.Forms.TextBox currentNumberTextBox;
    }
}
