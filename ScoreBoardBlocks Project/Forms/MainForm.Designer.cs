namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentScenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageScenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneNameLabel = new System.Windows.Forms.Label();
            this.noPanelsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(768, 356);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sceneManagerToolStripMenuItem,
            this.editCurrentSceneToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(132, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // sceneManagerToolStripMenuItem
            // 
            this.sceneManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentScenesToolStripMenuItem,
            this.toolStripSeparator1,
            this.newSceneToolStripMenuItem,
            this.loadSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.toolStripSeparator2,
            this.manageScenesToolStripMenuItem});
            this.sceneManagerToolStripMenuItem.Name = "sceneManagerToolStripMenuItem";
            this.sceneManagerToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.sceneManagerToolStripMenuItem.Text = "Scene Manager";
            // 
            // recentScenesToolStripMenuItem
            // 
            this.recentScenesToolStripMenuItem.Name = "recentScenesToolStripMenuItem";
            this.recentScenesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.recentScenesToolStripMenuItem.Text = "Recent Scenes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            // 
            // loadSceneToolStripMenuItem
            // 
            this.loadSceneToolStripMenuItem.Name = "loadSceneToolStripMenuItem";
            this.loadSceneToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadSceneToolStripMenuItem.Text = "Load Scene";
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // manageScenesToolStripMenuItem
            // 
            this.manageScenesToolStripMenuItem.Name = "manageScenesToolStripMenuItem";
            this.manageScenesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageScenesToolStripMenuItem.Text = "Manage Scenes";
            // 
            // editCurrentSceneToolStripMenuItem
            // 
            this.editCurrentSceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.removePanelToolStripMenuItem,
            this.modifyOrderToolStripMenuItem,
            this.toolStripSeparator4,
            this.lockToolStripMenuItem});
            this.editCurrentSceneToolStripMenuItem.Name = "editCurrentSceneToolStripMenuItem";
            this.editCurrentSceneToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.editCurrentSceneToolStripMenuItem.Text = "Edit Current Scene";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addItemToolStripMenuItem.Text = "Add Panel";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // removePanelToolStripMenuItem
            // 
            this.removePanelToolStripMenuItem.Name = "removePanelToolStripMenuItem";
            this.removePanelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removePanelToolStripMenuItem.Text = "Remove Panel";
            // 
            // modifyOrderToolStripMenuItem
            // 
            this.modifyOrderToolStripMenuItem.Name = "modifyOrderToolStripMenuItem";
            this.modifyOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyOrderToolStripMenuItem.Text = "Modify Order";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sceneNameLabel
            // 
            this.sceneNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sceneNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneNameLabel.Location = new System.Drawing.Point(0, 24);
            this.sceneNameLabel.Name = "sceneNameLabel";
            this.sceneNameLabel.Size = new System.Drawing.Size(792, 23);
            this.sceneNameLabel.TabIndex = 0;
            this.sceneNameLabel.Text = "New Scene";
            this.sceneNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noPanelsLabel
            // 
            this.noPanelsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noPanelsLabel.Location = new System.Drawing.Point(72, 63);
            this.noPanelsLabel.Name = "noPanelsLabel";
            this.noPanelsLabel.Size = new System.Drawing.Size(654, 293);
            this.noPanelsLabel.TabIndex = 0;
            this.noPanelsLabel.Text = "You currently have no panels or a scene openned. Use the menu buttons above to st" +
    "art.";
            this.noPanelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.noPanelsLabel);
            this.Controls.Add(this.sceneNameLabel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(483, 306);
            this.Name = "MainForm";
            this.Text = "ScoreBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sceneManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentScenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem manageScenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.Label sceneNameLabel;
        private System.Windows.Forms.Label noPanelsLabel;
    }
}

