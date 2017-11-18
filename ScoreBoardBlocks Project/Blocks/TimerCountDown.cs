using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Blocks
{
    public partial class TimerCountDown : BlockPanel
    {
        private int currentTimeInSeconds;

        public TimerCountDown()
        {
            InitializeComponent();
        }

        public TimerCountDown(String name, int startingMinutes, int startingSeconds)
        {
            InitializeComponent();
            setName(name);
            groupBox.Text = name;
            this.currentTimeInSeconds = (startingMinutes * 60) + startingSeconds;
            int minutes = (currentTimeInSeconds - (currentTimeInSeconds % 60)) / 60;
            int seconds = currentTimeInSeconds % 60;

            updateInitialClockTextBox(minutes, seconds);

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override List<string> returnProperties()
        {
            List<string> properties = new List<string>();
            properties.Add(this.getName());
            properties.Add(Convert.ToString(this.currentTimeInSeconds));

            return properties;
            
        }

        public override void applyProperties(List<String> properties)
        {
            this.setName(properties[1]);
            this.groupBox.Text = getName();
            this.currentTimeInSeconds = Convert.ToInt32(properties[2]);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            timer.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            timer.Enabled = false;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int minutes = Convert.ToInt32(minuteTextBox.Text);
            int seconds = Convert.ToInt32(secondsTextBox.Text);

            if (seconds > 60 || seconds < 0 || minutes < 0)
            {
                MessageBox.Show("Invalid time input.");
            }
            else
            {
                updateClockTextBox(minutes, seconds);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.currentTimeInSeconds > 0)
            {
                this.currentTimeInSeconds--;

                int minutes = (currentTimeInSeconds - (currentTimeInSeconds % 60)) / 60;
                int seconds = currentTimeInSeconds % 60;

                updateClockTextBox(minutes, seconds);

                minuteTextBox.Text = minutes.ToString();
                secondsTextBox.Text = seconds.ToString();
            }
            else
            {
                timer.Enabled = false;
            }
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            this.currentTimeInSeconds++;

            int minutes = (currentTimeInSeconds - (currentTimeInSeconds % 60)) / 60;
            int seconds = currentTimeInSeconds % 60;

            updateClockTextBox(minutes, seconds);
        }

        private void minusOneButton_Click(object sender, EventArgs e)
        {
            this.currentTimeInSeconds--;

            int minutes = (currentTimeInSeconds - (currentTimeInSeconds % 60)) / 60;
            int seconds = currentTimeInSeconds % 60;

            updateClockTextBox(minutes, seconds);
        }

        public void updateClockTextBox(int mins, int secs)
        {
            String time;
            if (secs < 10)
            {
                time = mins.ToString() + ":0" + secs.ToString();
            } else
            {
                time = mins.ToString() + ":" + secs.ToString();
            }

            this.currentTimeTextBox.Text = time;
            writeToFile(time);
        }

        public void updateInitialClockTextBox(int mins, int secs)
        {
            String time;
            if (secs < 10)
            {
                time = mins.ToString() + ":0" + secs.ToString();
            }
            else
            {
                time = mins.ToString() + ":" + secs.ToString();
            }

            this.currentTimeTextBox.Text = time;
        }
    }
}
