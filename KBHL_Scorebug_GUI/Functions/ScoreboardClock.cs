namespace KBHL_Scorebug_GUI.Functions
{
    using System;
    using System.ComponentModel;
    using System.Timers;
    using Timer = System.Timers.Timer;
    internal class ScoreboardClock : INotifyPropertyChanged
    {
        private Timer ThisTimer;
        public int timeLeft = 0;
        public int timeStart = 0;
        public bool penaltyFormat;
        public event PropertyChangedEventHandler PropertyChanged;
        public string timeString => TimeHandler(timeLeft, false);
        public ScoreboardClock(int timer_val, bool penalty, bool running) { 
            timeLeft = timer_val;
            ThisTimer = new Timer
            {
                Interval = 100,
            };
            if (penalty )
            {
                penaltyFormat = true;
            };
            ThisTimer.Elapsed += (sender, o) => PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(timeString)));
            if (running)
            {
                ThisTimer.Start();
            }
            else 
            { 
                ThisTimer.Stop();
            }

        }
        public string TimeHandler(int timer,
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
}
