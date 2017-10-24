namespace WindowsFormsApplication1.Blocks.SettingsBlocks
{
    partial class IncrementalNumericalSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customIntervalTextBox = new System.Windows.Forms.TextBox();
            this.ordinalCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Custom Interval:";
            // 
            // customIntervalTextBox
            // 
            this.customIntervalTextBox.Location = new System.Drawing.Point(6, 55);
            this.customIntervalTextBox.Name = "customIntervalTextBox";
            this.customIntervalTextBox.Size = new System.Drawing.Size(187, 20);
            this.customIntervalTextBox.TabIndex = 1;
            this.customIntervalTextBox.Text = "7";
            // 
            // ordinalCheckBox
            // 
            this.ordinalCheckBox.AutoSize = true;
            this.ordinalCheckBox.Location = new System.Drawing.Point(6, 81);
            this.ordinalCheckBox.Name = "ordinalCheckBox";
            this.ordinalCheckBox.Size = new System.Drawing.Size(197, 17);
            this.ordinalCheckBox.TabIndex = 2;
            this.ordinalCheckBox.Text = "Ordinal Suffixes? (1st, 2nd, 3rd, etc),";
            this.ordinalCheckBox.UseVisualStyleBackColor = true;
            // 
            // IncrementalNumericalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ordinalCheckBox);
            this.Controls.Add(this.customIntervalTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncrementalNumericalSettings";
            this.Size = new System.Drawing.Size(196, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customIntervalTextBox;
        private System.Windows.Forms.CheckBox ordinalCheckBox;
    }
}
