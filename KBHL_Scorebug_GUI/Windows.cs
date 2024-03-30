using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;
using Timer = System.Timers.Timer;
using System.Windows.Threading;
using SharpVectors;


namespace KBHL_Scorebug_GUI
{
    public enum Teams
    {
        Home,
        Away
    };
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        OverlayWindow ScorebugOverlay = new OverlayWindow();
        public static int periodTimeElapsed_ds = 0;
        public static int periodTimeRemaining_ds = Mins2Dec(20);
        public static int periodCount = 1;
        public static bool ShowOverlay;
        // HomeTeamInfo
        public string? HomeTeamName;
        public string? HomeTeamABB;
        public string? HomeTeamHexCode;
        public int HomeTeamGoals = 0;
        public int HomeTeamPenalties;
        public bool HomeTeamDelayedPenalty;
        public bool HomeTeamEmptyNet;
        public int? HomeTeam_Pen1Remaining_ds;
        public int? HomeTeam_Pen2Remaining_ds;
        // RoadTeamInfo;
        public string? RoadTeamName;
        public string? RoadTeamABB;
        public string? RoadTeamHexCode;
        public int RoadTeamGoals = 0;
        public int? RoadTeamPenalties;
        public bool RoadTeamDelayedPenalty;
        public bool RoadTeamEmptyNet;
        public int? RoadTeam_Pen1Remaining_ds;
        public int? RoadTeam_Pen2Remaining_ds;
        public Timer _periodTimer;

        // BINDINGS
        public string PeriodTimeRemaining_str => Handlers.TimeHandler(periodTimeRemaining_ds, false);
        public string PeriodCount_str => Handlers.PeriodHandler(periodCount);
        public string HomeTeamGoals_str => Handlers.PeriodHandler(HomeTeamGoals);
        public string PeriodTimeRemaining_bug => Handlers.BugTimeHandler(periodTimeRemaining_ds, false);
        public string PeriodCount_bug => Handlers.BugPeriodHandler(periodCount);
        public MainWindow()
        {
            InitializeComponent();
            _periodTimer = new Timer
            {
                Interval = 100
            };
            _periodTimer.Elapsed += PeriodTimer_Tick;
            _periodTimer.Elapsed += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_str)));
            _periodTimer.Elapsed += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_bug)));
        }
        private void ClockToggle_Click(object sender, RoutedEventArgs e)
        {
            Color redFill = (Color)ColorConverter.ConvertFromString("#FF804040");
            Color redStroke = (Color)ColorConverter.ConvertFromString("#FF603030");
            Color greenFill = (Color)ColorConverter.ConvertFromString("#FF408040");
            Color greenStroke = (Color)ColorConverter.ConvertFromString("#FF306030");
            if (_periodTimer.Enabled)
            {
                _periodTimer.Stop();
                ClockToggle.Background = new SolidColorBrush(greenFill);
                ClockToggle.BorderBrush = new SolidColorBrush(greenStroke);
                if (periodTimeRemaining_ds < Mins2Dec(20))
                {
                    ClockToggle.Content = "Start";
                }
                else
                {
                    ClockToggle.Content = "Resume";
                }
            }
            else
            {
                _periodTimer.Start();
                ClockToggle.Background = new SolidColorBrush(redFill);
                ClockToggle.BorderBrush = new SolidColorBrush(redStroke);
                ClockToggle.Content = "Stop";
            }
        }
        void PeriodTimer_Tick(object? sender, EventArgs e)
        {
            if (periodTimeRemaining_ds > 0)
            {
                periodTimeRemaining_ds--;
            }
            else
            {
                _periodTimer.Stop();
            }
        }

        public static int Mins2Dec(int mins)
        {
            int secs = mins * 60;
            int decs = secs * 10;
            return decs;
        }
        public static int Secs2Dec(int secs)
        {
            int decs = secs * 10;
            return decs;
        }

        private void ResetClock_Click(object sender, RoutedEventArgs e)
        {
            Color greenFill = (Color)ColorConverter.ConvertFromString("#FF408040");
            Color greenStroke = (Color)ColorConverter.ConvertFromString("#FF306030");
            if (_periodTimer.Enabled)
            {
                _periodTimer.Stop();
                ClockToggle.Background = new SolidColorBrush(greenFill);
                ClockToggle.BorderBrush = new SolidColorBrush(greenStroke);
                ClockToggle.Content = "Start";
                periodTimeRemaining_ds = Mins2Dec(20);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_str)));
            }
        }

        private void SetClock_Click(object sender, RoutedEventArgs e)
        {
            int new_mins = int.Parse(MinOverride.Text);
            int new_secs = int.Parse(SecOverride.Text);
            periodTimeRemaining_ds = Mins2Dec(new_mins) + Secs2Dec(new_secs);
        }

        private void OpenScorebug_Click(object sender, RoutedEventArgs e)
        {
            if (ShowOverlay)
            {
                ScorebugOverlay.Hide();
                ShowOverlay = false;
            }
            else
            {
                ScorebugOverlay.Show();
                ShowOverlay = true;
            }
        }
        private void PeriodUp_Click(object sender, RoutedEventArgs e)
        {
            periodCount++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodCount_str)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodCount_bug)));
        }
        private void PeriodDown_Click(object sender, RoutedEventArgs e)
        {
            periodCount--;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodCount_str)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodCount_bug)));
        }
        private void HomeGoal_Click(object sender, RoutedEventArgs e)
        {
            Color greenFill = (Color)ColorConverter.ConvertFromString("#FF408040");
            Color greenStroke = (Color)ColorConverter.ConvertFromString("#FF306030");
            _periodTimer.Stop();
            ClockToggle.Background = new SolidColorBrush(greenFill);
            ClockToggle.BorderBrush = new SolidColorBrush(greenStroke);
            ClockToggle.Content = "Start";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_str)));
            HomeTeamGoals++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HomeTeamGoals_str)));
        }
    }

    /// <summary>
    /// Interaction logic for OverlayWindow.xaml
    /// </summary>
   
    public partial class OverlayWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string ScorebugTime_Str = "20:00";
        public static int periodTimeRemaining_ds = MainWindow.periodTimeRemaining_ds;
        public static int periodCount = MainWindow.periodCount;
        public static bool offsetPenalties;
        public string PeriodTimeRemaining_bug => Handlers.BugTimeHandler(periodTimeRemaining_ds, false);
        public string PeriodCount_bug => Handlers.BugPeriodHandler(periodCount);
        public OverlayWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000/30); // 30 hz Refresh
            timer.Tick += DisplayRefresh;
            timer.Start();
            timer.Tick += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_bug)));
            timer.Tick += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodCount_bug)));
        }
        void DisplayRefresh(object sender, EventArgs e)
        {         
            periodTimeRemaining_ds = MainWindow.periodTimeRemaining_ds;
            periodCount = MainWindow.periodCount;
        }
        public static int AssignColumn (int teamSelection)
        {
            var teamSelected = (Teams)teamSelection;
            var team = nameof(teamSelected);
            if (team == "Home")
            {
                return 1;
            }
            else
            {
                return 3;
            }
        }
        void checkBools (object sender, EventArgs e)
        {


        }
    }

    public class SvgTool
    {

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
    public class Handlers
    {
        public static string PeriodHandler(int period)
        {
            return period.ToString("D2");
        }
        public static string AddOrdinalIndicator(int intNumber)
        {
            string strIndicator = "";

            if (intNumber < 20)
            {
                switch (intNumber)
                {
                case 1:
                {
                    strIndicator = "st";
                    break;
                }

                case 2:
                {
                    strIndicator = "nd";
                    break;
                }

                case 3:
                {
                    strIndicator = "rd";
                    break;
                }

                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                {
                    strIndicator = "th";
                    break;
                }
                }
            }
            else
            {
                string strNumber = "";
                strNumber = Convert.ToString(intNumber);

                char chrLast = strNumber[strNumber.Length - 1];

                switch (Convert.ToString(chrLast))
                {
                case "1":
                {
                    strIndicator = "st";
                    break;
                }

                case "2":
                {
                    strIndicator = "nd";
                    break;
                }

                case "3":
                {
                    strIndicator = "rd";
                    break;
                }

                default:
                {
                    strIndicator = "th";
                    break;
                }
                }
            }
            return Convert.ToString(intNumber) + strIndicator;
        }
        public static string BugPeriodHandler(int period)
        {
            if (period < 3)
            {
                return AddOrdinalIndicator(period);
            }
            else if (period == 3)
            {
                return "OT";
            }
            else
            {
                int ot_frame = period - 2;
                return Convert.ToString(ot_frame) + "OT";
            }
        }
        public static string TimeHandler(int timer,
                          bool penalty)
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
                    if (secs < 10)
                    {
                        time = "  " + secs.ToString() + "." + decs.ToString();
                    }
                    else
                    {
                        time = " " + secs.ToString() + "." + decs.ToString();
                    }
                }
                else
                {
                    if (secs < 10)
                    {
                        time = mins_display + ":0" + secs.ToString();
                    }
                    else
                    {
                        time = mins_display + ":" + secs.ToString();
                    }
                }
            }
            return time;
        }
        public static string BugTimeHandler(int timer,
                          bool penalty)
        {
            string time;
            string mins_display;
            int mins = (timer - (timer % 600)) / 600;
            int secs = ((timer % 600) - (timer % 10)) / 10;
            int decs = timer % 10;
            if (penalty)
            {
                mins_display = mins.ToString();
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
                mins_display = mins.ToString();
                if (mins < 1)
                {
                    if (secs < 10)
                    {
                        time = "  " + secs.ToString() + "." + decs.ToString();
                    }
                    else
                    {
                        time = " " + secs.ToString() + "." + decs.ToString();
                    }
                }
                else
                {
                    if (secs < 10)
                    {
                        time = mins_display + ":0" + secs.ToString();
                    }
                    else
                    {
                        time = mins_display + ":" + secs.ToString();
                    }
                }
            }
            return time;
        }
    }
}
