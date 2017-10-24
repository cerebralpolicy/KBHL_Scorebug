namespace WindowsFormsApplication1
{
    partial class addPanel
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
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(460, 15);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(460, 50);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Items.AddRange(new object[] {
            "Select an Item",
            "String Text",
            "Incremental Numerical",
            "Timer"});
            this.itemComboBox.Location = new System.Drawing.Point(20, 17);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(431, 24);
            this.itemComboBox.TabIndex = 2;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Location = new System.Drawing.Point(16, 164);
            this.previewGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewGroupBox.Size = new System.Drawing.Size(267, 246);
            this.previewGroupBox.TabIndex = 3;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview:";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Location = new System.Drawing.Point(293, 164);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsGroupBox.Size = new System.Drawing.Size(267, 246);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 82);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(543, 73);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "Pick an Item from the combobox above.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 223);
            this.label1.TabIndex = 0;
            this.label1.Text = "No settings available for this component.";
            // 
            // addPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 422);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addPanel";
            this.Text = "Add Panel";
            this.settingsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
    }
}