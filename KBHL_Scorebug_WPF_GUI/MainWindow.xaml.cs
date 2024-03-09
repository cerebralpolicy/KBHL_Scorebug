using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KBHL_Scorebug_WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///  
    public partial class MainWindow : Window
    {
        public required Region GameInfo;
        public required int periodTimeRemaining_ds;
        public required int periodCount;
        public required Region HomeTeamInfo;
        public required string HomeTeamName;
        public required string HomeTeamABB;
        public required string HomeTeamHexCode;
        public required int HomeTeamGoals;
        public int? HomeTeamPenalties;
        public required bool HomeTeamDelayedPenalty;
        public required bool HomeTeamEmptyNet;
        public int? HomeTeam_Pen1Remaining_ds;
        public int? HomeTeam_Pen2Remaining_ds;
        public required Region RoadTeamInfo;
        public required string RoadTeamName;
        public required string RoadTeamABB;
        public required string RoadTeamHexCode;
        public required int RoadTeamGoals;
        public int? RoadTeamPenalties;
        public required bool RoadTeamDelayedPenalty;
        public required bool RoadTeamEmptyNet;
        public int? RoadTeam_Pen1Remaining_ds;
        public int? RoadTeam_Pen2Remaining_ds;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClockToggle_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GUIStartup(object sender, RoutedEventArgs e)
        {
            // initialize period timer
            DispatcherTimer periodTimer = new DispatcherTimer();
            periodTimer.Tick -= new EventHandler(periodTimer_Tick);
            periodTimer.Interval = TimeSpan.FromMilliseconds(100);
            periodTimeRemaining_ds = (20)*(60)*(1000);
            this.GameClockDisplay.Content = periodTimeRemaining_ds;
        }

        private void periodTimer_Tick(object? sender, EventArgs e)
        {
            periodTimeRemaining_ds--;
            this.GameClockDisplay.Content = periodTimeRemaining_ds;
            throw new NotImplementedException();
        }

        public string ScorebugTimeHandler(int timer, bool penalty)
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

    }

    public class ScorebugData
    {
        // GAME INFO
        public class Game
        {
            public int DS_Left { get; set; }
            public string? ClockString { get; set; }
            public int PeriodInt { get; set; }
            public string? PeriodString { get; set; }
        };
        public class Team
        {
            public required string Name { get; set; }
            public required string Abbreviation { get; set; }
            public int Goals { get; set; }
            public required string HexCode { get; set; }
            public bool DelayedPenalty { get; set; }
            public bool EmptyNet { get; set; }
            public int Pen1DS_Left { get; set; }
            public string? Pen1String { get; set; }
            public int Pen2DS_Left { get; set; }
            public string? Pen2String { get; set; }

        }
    }
}