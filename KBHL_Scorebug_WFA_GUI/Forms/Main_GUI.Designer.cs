namespace KBHL_Scorebug_WFA_GUI
{
    partial class Main_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_GUI));
            this.togglePeriodTimer = new System.Windows.Forms.Button();
            this.periodTimer = new System.Windows.Forms.Timer(this.components);
            this.resetClock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.periodTimeDisplay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DecPeriod = new System.Windows.Forms.Button();
            this.IncPeriod = new System.Windows.Forms.Button();
            this.periodDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.homeHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HomeSetColour = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HomeGoalOverturned = new System.Windows.Forms.Button();
            this.HomeAddShot = new System.Windows.Forms.Button();
            this.HomeSubShot = new System.Windows.Forms.Button();
            this.HomeGoalScored = new System.Windows.Forms.Button();
            this.HomeMajorPen = new System.Windows.Forms.Button();
            this.Home2xMinorPen = new System.Windows.Forms.Button();
            this.HomeDelayedPen = new System.Windows.Forms.Button();
            this.HomeEmptyNet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.HomePen2Display = new System.Windows.Forms.Label();
            this.HomePen1Display = new System.Windows.Forms.Label();
            this.HomeMinorPen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeShotsDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HomeGoalsDisplay = new System.Windows.Forms.Label();
            this.HomeSetABB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HomeSetName = new System.Windows.Forms.Button();
            this.homeTeamColourDialog = new System.Windows.Forms.ColorDialog();
            this.roadTeamColourDialog = new System.Windows.Forms.ColorDialog();
            this.HomeColourPreview = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // togglePeriodTimer
            // 
            this.togglePeriodTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePeriodTimer.BackColor = System.Drawing.Color.Black;
            this.togglePeriodTimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.togglePeriodTimer.FlatAppearance.BorderSize = 4;
            this.togglePeriodTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.togglePeriodTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.togglePeriodTimer.Font = new System.Drawing.Font("60s Scoreboard", 18F);
            this.togglePeriodTimer.Location = new System.Drawing.Point(4, 138);
            this.togglePeriodTimer.Margin = new System.Windows.Forms.Padding(4);
            this.togglePeriodTimer.Name = "togglePeriodTimer";
            this.togglePeriodTimer.Size = new System.Drawing.Size(120, 48);
            this.togglePeriodTimer.TabIndex = 1;
            this.togglePeriodTimer.Text = "Start";
            this.togglePeriodTimer.UseCompatibleTextRendering = true;
            this.togglePeriodTimer.UseVisualStyleBackColor = false;
            this.togglePeriodTimer.Click += new System.EventHandler(this.TogglePeriodTimer_Click);
            // 
            // periodTimer
            // 
            this.periodTimer.Tick += new System.EventHandler(this.PeriodTimer_Tick);
            // 
            // resetClock
            // 
            this.resetClock.BackColor = System.Drawing.Color.Black;
            this.resetClock.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.resetClock.FlatAppearance.BorderSize = 4;
            this.resetClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetClock.Font = new System.Drawing.Font("60s Scoreboard", 18F);
            this.resetClock.ForeColor = System.Drawing.Color.Gold;
            this.resetClock.Location = new System.Drawing.Point(185, 138);
            this.resetClock.Margin = new System.Windows.Forms.Padding(4);
            this.resetClock.Name = "resetClock";
            this.resetClock.Size = new System.Drawing.Size(120, 48);
            this.resetClock.TabIndex = 2;
            this.resetClock.Text = "reset";
            this.resetClock.UseCompatibleTextRendering = true;
            this.resetClock.UseVisualStyleBackColor = false;
            this.resetClock.Click += new System.EventHandler(this.resetClock_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resetClock);
            this.panel1.Controls.Add(this.togglePeriodTimer);
            this.panel1.Controls.Add(this.periodTimeDisplay);
            this.panel1.Location = new System.Drawing.Point(340, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 218);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Octin College Sb", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Remaining";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // periodTimeDisplay
            // 
            this.periodTimeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.periodTimeDisplay.BackColor = System.Drawing.Color.Black;
            this.periodTimeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.periodTimeDisplay.Font = new System.Drawing.Font("60s Scoreboard", 36F);
            this.periodTimeDisplay.ForeColor = System.Drawing.Color.Gold;
            this.periodTimeDisplay.Image = ((System.Drawing.Image)(resources.GetObject("periodTimeDisplay.Image")));
            this.periodTimeDisplay.Location = new System.Drawing.Point(40, 39);
            this.periodTimeDisplay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.periodTimeDisplay.Name = "periodTimeDisplay";
            this.periodTimeDisplay.Size = new System.Drawing.Size(224, 96);
            this.periodTimeDisplay.TabIndex = 0;
            this.periodTimeDisplay.Text = "20:00";
            this.periodTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.periodTimeDisplay.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Location = new System.Drawing.Point(340, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 157);
            this.panel2.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DecPeriod);
            this.splitContainer2.Panel1.Controls.Add(this.IncPeriod);
            this.splitContainer2.Panel1.Controls.Add(this.periodDisplay);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button9);
            this.splitContainer2.Panel2.Controls.Add(this.button8);
            this.splitContainer2.Size = new System.Drawing.Size(309, 157);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.TabIndex = 0;
            // 
            // DecPeriod
            // 
            this.DecPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.DecPeriod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.DecPeriod.FlatAppearance.BorderSize = 4;
            this.DecPeriod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.DecPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecPeriod.Font = new System.Drawing.Font("60s Scoreboard", 24F);
            this.DecPeriod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DecPeriod.Location = new System.Drawing.Point(109, 82);
            this.DecPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.DecPeriod.Name = "DecPeriod";
            this.DecPeriod.Size = new System.Drawing.Size(48, 48);
            this.DecPeriod.TabIndex = 3;
            this.DecPeriod.Text = "-";
            this.DecPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DecPeriod.UseCompatibleTextRendering = true;
            this.DecPeriod.UseVisualStyleBackColor = false;
            // 
            // IncPeriod
            // 
            this.IncPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.IncPeriod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.IncPeriod.FlatAppearance.BorderSize = 4;
            this.IncPeriod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.IncPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncPeriod.Font = new System.Drawing.Font("60s Scoreboard", 24F);
            this.IncPeriod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IncPeriod.Location = new System.Drawing.Point(109, 34);
            this.IncPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.IncPeriod.Name = "IncPeriod";
            this.IncPeriod.Size = new System.Drawing.Size(48, 48);
            this.IncPeriod.TabIndex = 2;
            this.IncPeriod.Text = "+";
            this.IncPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.IncPeriod.UseCompatibleTextRendering = true;
            this.IncPeriod.UseVisualStyleBackColor = false;
            // 
            // periodDisplay
            // 
            this.periodDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.periodDisplay.BackColor = System.Drawing.Color.Black;
            this.periodDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.periodDisplay.Font = new System.Drawing.Font("60s Scoreboard", 36F);
            this.periodDisplay.Location = new System.Drawing.Point(32, 34);
            this.periodDisplay.Name = "periodDisplay";
            this.periodDisplay.Size = new System.Drawing.Size(64, 96);
            this.periodDisplay.TabIndex = 1;
            this.periodDisplay.Text = "1";
            this.periodDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.periodDisplay.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Octin College Sb", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "HALF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(9, 42);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 30);
            this.button9.TabIndex = 21;
            this.button9.Text = "3-on-3";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(9, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 30);
            this.button8.TabIndex = 20;
            this.button8.Text = "4-on-4";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // homeHeader
            // 
            this.homeHeader.Font = new System.Drawing.Font("Octin College Rg", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeHeader.ForeColor = System.Drawing.Color.White;
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(320, 46);
            this.homeHeader.TabIndex = 7;
            this.homeHeader.Text = "HOME";
            this.homeHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeHeader.Click += new System.EventHandler(this.homeHeader_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.HomeSetColour);
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Controls.Add(this.homeHeader);
            this.panel3.Font = new System.Drawing.Font("Octin College Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 383);
            this.panel3.TabIndex = 9;
            // 
            // HomeSetColour
            // 
            this.HomeSetColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeSetColour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeSetColour.FlatAppearance.BorderSize = 2;
            this.HomeSetColour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeSetColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSetColour.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSetColour.ForeColor = System.Drawing.Color.White;
            this.HomeSetColour.Location = new System.Drawing.Point(228, 5);
            this.HomeSetColour.Name = "HomeSetColour";
            this.HomeSetColour.Size = new System.Drawing.Size(85, 41);
            this.HomeSetColour.TabIndex = 6;
            this.HomeSetColour.Text = "COLOUR";
            this.HomeSetColour.UseVisualStyleBackColor = false;
            this.HomeSetColour.Click += new System.EventHandler(this.homeColour_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HomeGoalOverturned);
            this.splitContainer1.Panel1.Controls.Add(this.HomeAddShot);
            this.splitContainer1.Panel1.Controls.Add(this.HomeSubShot);
            this.splitContainer1.Panel1.Controls.Add(this.HomeGoalScored);
            this.splitContainer1.Panel1.Controls.Add(this.HomeMajorPen);
            this.splitContainer1.Panel1.Controls.Add(this.Home2xMinorPen);
            this.splitContainer1.Panel1.Controls.Add(this.HomeDelayedPen);
            this.splitContainer1.Panel1.Controls.Add(this.HomeEmptyNet);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.HomePen2Display);
            this.splitContainer1.Panel1.Controls.Add(this.HomePen1Display);
            this.splitContainer1.Panel1.Controls.Add(this.HomeMinorPen);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.HomeShotsDisplay);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.HomeGoalsDisplay);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.HomeSetABB);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.HomeSetName);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(315, 331);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 8;
            // 
            // HomeGoalOverturned
            // 
            this.HomeGoalOverturned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeGoalOverturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeGoalOverturned.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeGoalOverturned.FlatAppearance.BorderSize = 2;
            this.HomeGoalOverturned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeGoalOverturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeGoalOverturned.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.HomeGoalOverturned.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeGoalOverturned.Location = new System.Drawing.Point(184, 140);
            this.HomeGoalOverturned.Margin = new System.Windows.Forms.Padding(4);
            this.HomeGoalOverturned.Name = "HomeGoalOverturned";
            this.HomeGoalOverturned.Size = new System.Drawing.Size(122, 30);
            this.HomeGoalOverturned.TabIndex = 25;
            this.HomeGoalOverturned.Text = "Goals -1";
            this.HomeGoalOverturned.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeGoalOverturned.UseCompatibleTextRendering = true;
            this.HomeGoalOverturned.UseVisualStyleBackColor = false;
            // 
            // HomeAddShot
            // 
            this.HomeAddShot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeAddShot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeAddShot.FlatAppearance.BorderSize = 2;
            this.HomeAddShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeAddShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAddShot.Font = new System.Drawing.Font("60s Scoreboard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddShot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeAddShot.Location = new System.Drawing.Point(139, 209);
            this.HomeAddShot.Margin = new System.Windows.Forms.Padding(4);
            this.HomeAddShot.Name = "HomeAddShot";
            this.HomeAddShot.Size = new System.Drawing.Size(30, 30);
            this.HomeAddShot.TabIndex = 24;
            this.HomeAddShot.Text = "+";
            this.HomeAddShot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeAddShot.UseCompatibleTextRendering = true;
            this.HomeAddShot.UseVisualStyleBackColor = false;
            // 
            // HomeSubShot
            // 
            this.HomeSubShot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeSubShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeSubShot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeSubShot.FlatAppearance.BorderSize = 2;
            this.HomeSubShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeSubShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSubShot.Font = new System.Drawing.Font("60s Scoreboard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSubShot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeSubShot.Location = new System.Drawing.Point(103, 209);
            this.HomeSubShot.Margin = new System.Windows.Forms.Padding(4);
            this.HomeSubShot.Name = "HomeSubShot";
            this.HomeSubShot.Size = new System.Drawing.Size(30, 30);
            this.HomeSubShot.TabIndex = 23;
            this.HomeSubShot.Text = "-";
            this.HomeSubShot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeSubShot.UseCompatibleTextRendering = true;
            this.HomeSubShot.UseVisualStyleBackColor = false;
            // 
            // HomeGoalScored
            // 
            this.HomeGoalScored.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeGoalScored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.HomeGoalScored.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.HomeGoalScored.FlatAppearance.BorderSize = 2;
            this.HomeGoalScored.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.HomeGoalScored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeGoalScored.Font = new System.Drawing.Font("Octin College Rg", 24F, System.Drawing.FontStyle.Bold);
            this.HomeGoalScored.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeGoalScored.Location = new System.Drawing.Point(184, 93);
            this.HomeGoalScored.Margin = new System.Windows.Forms.Padding(4);
            this.HomeGoalScored.Name = "HomeGoalScored";
            this.HomeGoalScored.Size = new System.Drawing.Size(122, 43);
            this.HomeGoalScored.TabIndex = 22;
            this.HomeGoalScored.Text = "GOAL!";
            this.HomeGoalScored.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeGoalScored.UseCompatibleTextRendering = true;
            this.HomeGoalScored.UseVisualStyleBackColor = false;
            // 
            // HomeMajorPen
            // 
            this.HomeMajorPen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeMajorPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeMajorPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeMajorPen.FlatAppearance.BorderSize = 2;
            this.HomeMajorPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeMajorPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMajorPen.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.HomeMajorPen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeMajorPen.Location = new System.Drawing.Point(13, 209);
            this.HomeMajorPen.Margin = new System.Windows.Forms.Padding(4);
            this.HomeMajorPen.Name = "HomeMajorPen";
            this.HomeMajorPen.Size = new System.Drawing.Size(77, 30);
            this.HomeMajorPen.TabIndex = 21;
            this.HomeMajorPen.Text = "5:00";
            this.HomeMajorPen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeMajorPen.UseCompatibleTextRendering = true;
            this.HomeMajorPen.UseVisualStyleBackColor = false;
            // 
            // Home2xMinorPen
            // 
            this.Home2xMinorPen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home2xMinorPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.Home2xMinorPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.Home2xMinorPen.FlatAppearance.BorderSize = 2;
            this.Home2xMinorPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.Home2xMinorPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home2xMinorPen.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.Home2xMinorPen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home2xMinorPen.Location = new System.Drawing.Point(13, 175);
            this.Home2xMinorPen.Margin = new System.Windows.Forms.Padding(4);
            this.Home2xMinorPen.Name = "Home2xMinorPen";
            this.Home2xMinorPen.Size = new System.Drawing.Size(77, 30);
            this.Home2xMinorPen.TabIndex = 20;
            this.Home2xMinorPen.Text = "4:00";
            this.Home2xMinorPen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Home2xMinorPen.UseCompatibleTextRendering = true;
            this.Home2xMinorPen.UseVisualStyleBackColor = false;
            // 
            // HomeDelayedPen
            // 
            this.HomeDelayedPen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeDelayedPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeDelayedPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeDelayedPen.FlatAppearance.BorderSize = 2;
            this.HomeDelayedPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeDelayedPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeDelayedPen.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.HomeDelayedPen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeDelayedPen.Location = new System.Drawing.Point(184, 209);
            this.HomeDelayedPen.Margin = new System.Windows.Forms.Padding(4);
            this.HomeDelayedPen.Name = "HomeDelayedPen";
            this.HomeDelayedPen.Size = new System.Drawing.Size(122, 30);
            this.HomeDelayedPen.TabIndex = 19;
            this.HomeDelayedPen.Text = "Delayed Pen";
            this.HomeDelayedPen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeDelayedPen.UseCompatibleTextRendering = true;
            this.HomeDelayedPen.UseVisualStyleBackColor = false;
            // 
            // HomeEmptyNet
            // 
            this.HomeEmptyNet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeEmptyNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeEmptyNet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeEmptyNet.FlatAppearance.BorderSize = 2;
            this.HomeEmptyNet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeEmptyNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeEmptyNet.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.HomeEmptyNet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeEmptyNet.Location = new System.Drawing.Point(184, 175);
            this.HomeEmptyNet.Margin = new System.Windows.Forms.Padding(4);
            this.HomeEmptyNet.Name = "HomeEmptyNet";
            this.HomeEmptyNet.Size = new System.Drawing.Size(122, 30);
            this.HomeEmptyNet.TabIndex = 18;
            this.HomeEmptyNet.Text = "Empty Net";
            this.HomeEmptyNet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeEmptyNet.UseCompatibleTextRendering = true;
            this.HomeEmptyNet.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Octin College Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "Penalties";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePen2Display
            // 
            this.HomePen2Display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomePen2Display.BackColor = System.Drawing.Color.Black;
            this.HomePen2Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomePen2Display.Font = new System.Drawing.Font("60s Scoreboard", 18F);
            this.HomePen2Display.ForeColor = System.Drawing.Color.Gold;
            this.HomePen2Display.Image = ((System.Drawing.Image)(resources.GetObject("HomePen2Display.Image")));
            this.HomePen2Display.Location = new System.Drawing.Point(13, 88);
            this.HomePen2Display.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.HomePen2Display.Name = "HomePen2Display";
            this.HomePen2Display.Size = new System.Drawing.Size(112, 48);
            this.HomePen2Display.TabIndex = 13;
            this.HomePen2Display.Text = "20:00";
            this.HomePen2Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomePen2Display.UseCompatibleTextRendering = true;
            // 
            // HomePen1Display
            // 
            this.HomePen1Display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomePen1Display.BackColor = System.Drawing.Color.Black;
            this.HomePen1Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomePen1Display.Font = new System.Drawing.Font("60s Scoreboard", 18F);
            this.HomePen1Display.ForeColor = System.Drawing.Color.Gold;
            this.HomePen1Display.Image = ((System.Drawing.Image)(resources.GetObject("HomePen1Display.Image")));
            this.HomePen1Display.Location = new System.Drawing.Point(13, 33);
            this.HomePen1Display.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.HomePen1Display.Name = "HomePen1Display";
            this.HomePen1Display.Size = new System.Drawing.Size(112, 48);
            this.HomePen1Display.TabIndex = 12;
            this.HomePen1Display.Text = "20:00";
            this.HomePen1Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomePen1Display.UseCompatibleTextRendering = true;
            // 
            // HomeMinorPen
            // 
            this.HomeMinorPen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeMinorPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeMinorPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeMinorPen.FlatAppearance.BorderSize = 2;
            this.HomeMinorPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeMinorPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMinorPen.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold);
            this.HomeMinorPen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeMinorPen.Location = new System.Drawing.Point(13, 140);
            this.HomeMinorPen.Margin = new System.Windows.Forms.Padding(4);
            this.HomeMinorPen.Name = "HomeMinorPen";
            this.HomeMinorPen.Size = new System.Drawing.Size(77, 30);
            this.HomeMinorPen.TabIndex = 11;
            this.HomeMinorPen.Text = "2:00";
            this.HomeMinorPen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeMinorPen.UseCompatibleTextRendering = true;
            this.HomeMinorPen.UseVisualStyleBackColor = false;
            this.HomeMinorPen.Click += new System.EventHandler(this.button10_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Octin College Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "SOG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeShotsDisplay
            // 
            this.HomeShotsDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeShotsDisplay.BackColor = System.Drawing.Color.Black;
            this.HomeShotsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeShotsDisplay.Font = new System.Drawing.Font("60s Scoreboard", 20F);
            this.HomeShotsDisplay.ForeColor = System.Drawing.Color.Gold;
            this.HomeShotsDisplay.Image = ((System.Drawing.Image)(resources.GetObject("HomeShotsDisplay.Image")));
            this.HomeShotsDisplay.Location = new System.Drawing.Point(103, 172);
            this.HomeShotsDisplay.Name = "HomeShotsDisplay";
            this.HomeShotsDisplay.Size = new System.Drawing.Size(66, 33);
            this.HomeShotsDisplay.TabIndex = 7;
            this.HomeShotsDisplay.Text = "01";
            this.HomeShotsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeShotsDisplay.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(184, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "GOALS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeGoalsDisplay
            // 
            this.HomeGoalsDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeGoalsDisplay.BackColor = System.Drawing.Color.Black;
            this.HomeGoalsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeGoalsDisplay.Font = new System.Drawing.Font("60s Scoreboard", 36F);
            this.HomeGoalsDisplay.ForeColor = System.Drawing.Color.Gold;
            this.HomeGoalsDisplay.Image = ((System.Drawing.Image)(resources.GetObject("HomeGoalsDisplay.Image")));
            this.HomeGoalsDisplay.Location = new System.Drawing.Point(184, 33);
            this.HomeGoalsDisplay.Name = "HomeGoalsDisplay";
            this.HomeGoalsDisplay.Size = new System.Drawing.Size(122, 56);
            this.HomeGoalsDisplay.TabIndex = 2;
            this.HomeGoalsDisplay.Text = "01";
            this.HomeGoalsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeGoalsDisplay.UseCompatibleTextRendering = true;
            // 
            // HomeSetABB
            // 
            this.HomeSetABB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeSetABB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeSetABB.FlatAppearance.BorderSize = 2;
            this.HomeSetABB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeSetABB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSetABB.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSetABB.ForeColor = System.Drawing.Color.White;
            this.HomeSetABB.Location = new System.Drawing.Point(258, 40);
            this.HomeSetABB.Name = "HomeSetABB";
            this.HomeSetABB.Size = new System.Drawing.Size(48, 30);
            this.HomeSetABB.TabIndex = 5;
            this.HomeSetABB.Text = "SET";
            this.HomeSetABB.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Octin College Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(173)))), ((int)(((byte)(154)))));
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(68, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(173)))), ((int)(((byte)(154)))));
            this.textBox1.Location = new System.Drawing.Point(68, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Octin College Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "ABB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeSetName
            // 
            this.HomeSetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.HomeSetName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(191)))));
            this.HomeSetName.FlatAppearance.BorderSize = 2;
            this.HomeSetName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(133)))), ((int)(((byte)(118)))));
            this.HomeSetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSetName.Font = new System.Drawing.Font("Octin College Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSetName.ForeColor = System.Drawing.Color.White;
            this.HomeSetName.Location = new System.Drawing.Point(258, 3);
            this.HomeSetName.Name = "HomeSetName";
            this.HomeSetName.Size = new System.Drawing.Size(48, 30);
            this.HomeSetName.TabIndex = 2;
            this.HomeSetName.Text = "SET";
            this.HomeSetName.UseVisualStyleBackColor = false;
            // 
            // homeTeamColourDialog
            // 
            this.homeTeamColourDialog.SolidColorOnly = true;
            // 
            // HomeColourPreview
            // 
            this.HomeColourPreview.Location = new System.Drawing.Point(15, 404);
            this.HomeColourPreview.Name = "HomeColourPreview";
            this.HomeColourPreview.Size = new System.Drawing.Size(318, 34);
            this.HomeColourPreview.TabIndex = 10;
            // 
            // Main_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.HomeColourPreview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("60s Scoreboard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_GUI";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Main_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button togglePeriodTimer;
        public System.Windows.Forms.Timer periodTimer;
        public System.Windows.Forms.Label periodTimeDisplay;
        public bool periodIsPlaying;
        private System.Windows.Forms.Button resetClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label periodDisplay;
        public System.Windows.Forms.Button IncPeriod;
        public System.Windows.Forms.Button DecPeriod;
        private System.Windows.Forms.Label homeHeader;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ColorDialog homeTeamColourDialog;
        private System.Windows.Forms.ColorDialog roadTeamColourDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeSetColour;
        private System.Windows.Forms.Button HomeSetABB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HomeSetName;
        private System.Windows.Forms.Label HomeGoalsDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HomeShotsDisplay;
        public System.Windows.Forms.Label HomePen2Display;
        public System.Windows.Forms.Label HomePen1Display;
        public System.Windows.Forms.Button HomeMinorPen;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button HomeMajorPen;
        public System.Windows.Forms.Button Home2xMinorPen;
        public System.Windows.Forms.Button HomeDelayedPen;
        public System.Windows.Forms.Button HomeEmptyNet;
        public System.Windows.Forms.Button HomeGoalScored;
        public System.Windows.Forms.Button HomeAddShot;
        public System.Windows.Forms.Button HomeSubShot;
        public System.Windows.Forms.Button HomeGoalOverturned;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel HomeColourPreview;
    }
}

