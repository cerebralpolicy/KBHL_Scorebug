using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using Timer = System.Timers.Timer;
using System.Windows.Threading;

namespace KBHL_Scorebug_GUI
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        OverlayWindow ScorebugOverlay = new OverlayWindow();
        public static int periodTimeElapsed_ds = 0;
        public static int periodTimeRemaining_ds = Mins2Dec(20);
        public static int periodCount = 1;
        public static bool ShowOverlay = false;
        // HomeTeamInfo
        public string? HomeTeamName;
        public string? HomeTeamABB;
        public string? HomeTeamHexCode;
        public int HomeTeamGoals;
        public int HomeTeamPenalties;
        public bool HomeTeamDelayedPenalty;
        public bool HomeTeamEmptyNet;
        public int? HomeTeam_Pen1Remaining_ds;
        public int? HomeTeam_Pen2Remaining_ds;
        // RoadTeamInfo;
        public string? RoadTeamName;
        public string? RoadTeamABB;
        public string? RoadTeamHexCode;
        public int RoadTeamGoals;
        public int? RoadTeamPenalties;
        public bool RoadTeamDelayedPenalty;
        public bool RoadTeamEmptyNet;
        public int? RoadTeam_Pen1Remaining_ds;
        public int? RoadTeam_Pen2Remaining_ds;
        public Timer _periodTimer;

        // BINDINGS
        public string PeriodTimeRemaining_str => Handlers.TimeHandler(periodTimeRemaining_ds, false);
        public string PeriodTimeRemaining_bug => Handlers.BugTimeHandler(periodTimeRemaining_ds, false);
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
    }

    /// <summary>
    /// Interaction logic for OverlayWindow.xaml
    /// </summary>
    public partial class OverlayWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string ScorebugTime_Str = "20:00";
        public static int periodTimeRemaining_ds = MainWindow.periodTimeRemaining_ds;
        public string PeriodTimeRemaining_bug => Handlers.BugTimeHandler(periodTimeRemaining_ds, false);
        public OverlayWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += DisplayRefresh;
            timer.Start();
            timer.Tick += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeriodTimeRemaining_bug)));
        }
        void DisplayRefresh(object sender, EventArgs e)
        {         
          periodTimeRemaining_ds = MainWindow.periodTimeRemaining_ds;
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
    public class Handlers
    {
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
