using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KBHL_Scorebug_WFA_GUI
{
     public partial class Main_GUI : Form
    {
        public enum UserEvents
        {
            PeriodClockToggle
        }
        public delegate void UserEventsHandler(UserEvents userEvents);
        public Region GameInfo;
        public int periodTimeRemaining_ds;
        public int periodCount;
        public Region HomeTeamInfo;
        public string HomeTeamName;
        public string HomeTeamABB;
        public string HomeTeamHexCode;
        public int HomeTeamGoals;
        public int HomeTeamPenalties;
        public bool HomeTeamDelayedPenalty;
        public bool HomeTeamEmptyNet;
        public int HomeTeam_Pen1Remaining_ds;
        public int HomeTeam_Pen2Remaining_ds;
        public Region RoadTeamInfo;
        public string RoadTeamName;
        public string RoadTeamABB;
        public string RoadTeamHexCode;
        public int RoadTeamGoals;
        public int RoadTeamPenalties;
        public bool RoadTeamDelayedPenalty;
        public bool RoadTeamEmptyNet;
        public int RoadTeam_Pen1Remaining_ds;
        public int RoadTeam_Pen2Remaining_ds;


        public Main_GUI()
        {
            InitializeComponent();
            this.periodTimeRemaining_ds = (20*60*10);
        }
        public Main_GUI(String name, int halfstart_m, int halfstart_s, int halfstart_ds)
        {
            InitializeComponent();
 //           setName(name);
 //           groupBox.Text = name;
            this.periodTimeRemaining_ds = (halfstart_m * 600) + (halfstart_s * 10) + halfstart_ds;
            int minutes = (halfstart_m - (periodTimeRemaining_ds % 600)) / 600;
            int seconds = (halfstart_s - (periodTimeRemaining_ds % 10)) / 10;
            int decaseconds = halfstart_ds;
        }
        private void TogglePeriodTimer_Click(object sender, EventArgs e)
        {
            if (periodTimer.Enabled.Equals(false))
            {
                periodTimer.Enabled = true;
                this.togglePeriodTimer.Text = "STOP ";
            }
            else {
                periodTimer.Enabled = false;
                if (this.periodTimeRemaining_ds < (20*60*10))
                {
                    togglePeriodTimer.Text = "RESUME";
                }
                else
                {
                    togglePeriodTimer.Text = "START";
                }
            };
        }

        private void PeriodTimer_Tick(object sender, EventArgs e)
        {
            if (this.periodTimeRemaining_ds > 0)
            {
                this.periodTimeRemaining_ds--; 
                int minutes = (periodTimeRemaining_ds - (periodTimeRemaining_ds % 600)) / 600;
                int seconds = ((periodTimeRemaining_ds % 600) - (periodTimeRemaining_ds % 10)) / 10;
                int decaseconds = periodTimeRemaining_ds % 10;
                updateClockTextBox(minutes, seconds, decaseconds);
            }
        }
        public void ScorebugHandler ()
        {
            // SCOREBUG UPDATE
            // GAME CLOCK
            var Game = new ScorebugData.Game { 
                DS_Left = periodTimeRemaining_ds,
                ClockString = ScorebugTimeHandler(periodTimeRemaining_ds, false),
            };
            var HomeTeam = new ScorebugData.Team
            {
                Name = HomeTeamName,
                Abbreviation = HomeTeamABB,
                Goals = HomeTeamGoals,
                HexCode = HomeTeamHexCode,
                DelayedPenalty = HomeTeamDelayedPenalty,
                EmptyNet = HomeTeamEmptyNet,
                Pen1DS_Left = HomeTeam_Pen1Remaining_ds,
                Pen2DS_Left = HomeTeam_Pen2Remaining_ds,
                Pen1String = ScoreboardTimeHandler(HomeTeam_Pen1Remaining_ds, true),
                Pen2String = ScoreboardTimeHandler(HomeTeam_Pen2Remaining_ds, true),
            };
            var RoadTeam = new ScorebugData.Team
            {
                Name = RoadTeamName,
                Abbreviation = RoadTeamABB,
                Goals = RoadTeamGoals,
                HexCode = RoadTeamHexCode,
                DelayedPenalty = RoadTeamDelayedPenalty,
                EmptyNet = RoadTeamEmptyNet,
                Pen1DS_Left = RoadTeam_Pen1Remaining_ds,
                Pen2DS_Left = RoadTeam_Pen2Remaining_ds,
                Pen1String = ScoreboardTimeHandler(RoadTeam_Pen1Remaining_ds, true),
                Pen2String = ScoreboardTimeHandler(RoadTeam_Pen2Remaining_ds, true),
            };
            var options = new JsonSerializerOptions { WriteIndented = true };
            string JSON_Game = JsonSerializer.Serialize(Game,options);
            string JSON_HomeTeam = JsonSerializer.Serialize(HomeTeam,options);
            string JSON_RoadTeam = JsonSerializer.Serialize(RoadTeam,options);

        }
        // IN GUI
        public void updateClockTextBox(int mins, int secs, int decs)
        {
            String time;
            String mins_display;
            if (mins < 10) {
                mins_display = "0" + mins.ToString();
            } 
            else {
                mins_display = mins.ToString();
            }
            if (secs < 10)
            {
                time =  mins_display + ":0" + secs.ToString();
            }
            else
            {
                time = mins_display + ":" + secs.ToString();
            }
            this.periodTimeDisplay.Text = time;
        }
        // IN SCOREBUG
        public void updateScorebugClockTextBox(int total, int mins, int secs, int decs)
        {
            String time;
            String mins_display;
            if (mins < 10)
            {
                mins_display = "0" + mins.ToString();
            }
            else
            {
                mins_display = mins.ToString();
            }
            if (mins < 1)
            {
                time = secs.ToString() + "." + decs.ToString();
            }
            else if (secs < 10)
            {
                time = mins_display + ":0" + secs.ToString();
            }
            else
            {
                time = mins_display + ":" + secs.ToString();
            }
            
        }
        public string ScoreboardTimeHandler(int timer, bool penalty)
        {
            string time;
            string mins_display;
            int mins = (timer - (timer % 600)) / 600;
            int secs = ((timer % 600) - (timer % 10)) / 10;
            int decs = timer % 10;
            if (mins < 10)
            {
                mins_display = "0" + mins.ToString();
            }
            else
            {
                mins_display = mins.ToString();
            }
            if (secs < 10)
            {
                time = mins_display + ":0" + secs.ToString();
            }
            else
            {
                time = mins_display + ":" + secs.ToString();
            }
            return time;
        }
        public string ScorebugTimeHandler (int timer, bool penalty)
        {
            string time;
            string mins_display;
            int mins = (timer - (timer % 600)) / 600;
            int secs = ((timer % 600) - (timer % 10)) / 10;
            int decs = timer % 10;
            if (penalty)
            {
                if (mins < 10)
                {
                    mins_display = "0" + mins.ToString();
                }
                else
                {
                    mins_display = mins.ToString();
                }
                if (secs < 10)
                {
                    time = mins_display + ":0" + secs.ToString();
                }
                else
                {
                    time = mins_display + ":" + secs.ToString();
                } 
            }
            else
            {
                if (mins < 10)
                {
                    mins_display = "0" + mins.ToString();
                }
                else
                {
                    mins_display = mins.ToString();
                }
                if (mins < 1)
                {
                    time = secs.ToString() + "." + decs.ToString();
                }
                else if (secs < 10)
                {
                    time = mins_display + ":0" + secs.ToString();
                }
                else
                {
                    time = mins_display + ":" + secs.ToString();
                }
            }
            return time;
        }
        private void resetClock_Click(object sender, EventArgs e)
        {
            periodTimer.Enabled = false;
            periodTimeRemaining_ds = (20 * 60 * 10);
            int minutes = (periodTimeRemaining_ds - (periodTimeRemaining_ds % 600)) / 600;
            int seconds = ((periodTimeRemaining_ds % 600) - (periodTimeRemaining_ds % 10)) / 10;
            int decaseconds = periodTimeRemaining_ds % 10;

            updateClockTextBox(minutes, seconds, decaseconds);
        }

        private void homeHeader_Click(object sender, EventArgs e)
        {

        }

        private void awayHeader_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_GUI_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeColour_Click(object sender, EventArgs e)
        {
            var newHomeColour = homeTeamColourDialog.ShowDialog();
            if (newHomeColour == DialogResult.OK)
            {
                HomeTeamHexCode = (homeTeamColourDialog.Color.ToArgb() &0x00FFFFFF).ToString("X6");
                HomeColourPreview.BackColor = homeTeamColourDialog.Color;
            }    
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class ScorebugData
    {
        // GAME INFO
        public class Game
        {
            public int DS_Left { get; set; }
            public string ClockString { get; set; }
            public int PeriodInt { get; set; }
            public string PeriodString { get; set; }
        };
        public class Team
        {
            public string Name { get; set; }
            public string Abbreviation { get; set; }
            public int Goals { get; set; }
            public string HexCode { get; set; }
            public bool DelayedPenalty { get; set; }
            public bool EmptyNet { get; set; }
            public int Pen1DS_Left { get; set; }
            public string Pen1String { get; set; }
            public int Pen2DS_Left { get; set; }
            public string Pen2String { get; set; }

        }
    }
}
