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

            currentTimeTextBox.Text = Convert.ToString(minutes) + ":" + Convert.ToString(seconds);

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

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.currentTimeInSeconds > 0)
            {
                this.currentTimeInSeconds--;
            }
            else
            {
                timer.Enabled = false;
            }
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            this.currentTimeInSeconds++;
        }

        private void minusOneButton_Click(object sender, EventArgs e)
        {
            this.currentTimeInSeconds--;
        }
    }
}
