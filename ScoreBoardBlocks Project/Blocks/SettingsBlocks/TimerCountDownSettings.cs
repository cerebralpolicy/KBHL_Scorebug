using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Blocks.SettingsBlocks
{
    public partial class TimerCountDownSettings : SettingsBlock
    {
        public TimerCountDownSettings(MainForm mainWindow)
        {
            InitializeComponent();
        }

        public override BlockPanel makeNewBlockUsingSettings()
        {
            return new TimerCountDown(nameTextBox.Text, Convert.ToInt32(minutesTextBox.Text), Convert.ToInt32(secondsTextBox.Text));
        }
    }
}
