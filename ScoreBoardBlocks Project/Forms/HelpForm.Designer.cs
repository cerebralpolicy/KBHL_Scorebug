namespace WindowsFormsApplication1.Forms
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.youtubeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubMainLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubWikiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.discordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ScoreBoardBlocksOBS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 117);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // youtubeLinkLabel
            // 
            this.youtubeLinkLabel.AutoSize = true;
            this.youtubeLinkLabel.Location = new System.Drawing.Point(83, 106);
            this.youtubeLinkLabel.Name = "youtubeLinkLabel";
            this.youtubeLinkLabel.Size = new System.Drawing.Size(123, 13);
            this.youtubeLinkLabel.TabIndex = 3;
            this.youtubeLinkLabel.TabStop = true;
            this.youtubeLinkLabel.Text = "LCTVNews on YouTube";
            this.youtubeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLinkLabel_LinkClicked);
            // 
            // githubMainLinkLabel
            // 
            this.githubMainLinkLabel.AutoSize = true;
            this.githubMainLinkLabel.Location = new System.Drawing.Point(13, 158);
            this.githubMainLinkLabel.Name = "githubMainLinkLabel";
            this.githubMainLinkLabel.Size = new System.Drawing.Size(168, 13);
            this.githubMainLinkLabel.TabIndex = 4;
            this.githubMainLinkLabel.TabStop = true;
            this.githubMainLinkLabel.Text = "ScoreBoardBlocksOBS on GitHub";
            this.githubMainLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubMainLinkLabel_LinkClicked);
            // 
            // githubWikiLinkLabel
            // 
            this.githubWikiLinkLabel.AutoSize = true;
            this.githubWikiLinkLabel.Location = new System.Drawing.Point(13, 171);
            this.githubWikiLinkLabel.Name = "githubWikiLinkLabel";
            this.githubWikiLinkLabel.Size = new System.Drawing.Size(175, 13);
            this.githubWikiLinkLabel.TabIndex = 4;
            this.githubWikiLinkLabel.TabStop = true;
            this.githubWikiLinkLabel.Text = "ScoreBoardBlocksOBS Github Wiki";
            this.githubWikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubWikiLinkLabel_LinkClicked);
            // 
            // discordLinkLabel
            // 
            this.discordLinkLabel.AutoSize = true;
            this.discordLinkLabel.Location = new System.Drawing.Point(13, 184);
            this.discordLinkLabel.Name = "discordLinkLabel";
            this.discordLinkLabel.Size = new System.Drawing.Size(154, 13);
            this.discordLinkLabel.TabIndex = 4;
            this.discordLinkLabel.TabStop = true;
            this.discordLinkLabel.Text = "Marcus\'s Public Discord Server";
            this.discordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.lclogo;
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 214);
            this.Controls.Add(this.discordLinkLabel);
            this.Controls.Add(this.githubWikiLinkLabel);
            this.Controls.Add(this.githubMainLinkLabel);
            this.Controls.Add(this.youtubeLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel youtubeLinkLabel;
        private System.Windows.Forms.LinkLabel githubMainLinkLabel;
        private System.Windows.Forms.LinkLabel githubWikiLinkLabel;
        private System.Windows.Forms.LinkLabel discordLinkLabel;
    }
}