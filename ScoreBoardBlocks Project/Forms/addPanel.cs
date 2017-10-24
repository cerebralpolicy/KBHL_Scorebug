using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class addPanel : Form
    {
        private MainForm mainWindow;
        private SettingsBlock currentSettings;
        public addPanel(MainForm mainWindow)
        {
            InitializeComponent();
            itemComboBox.SelectedIndex = 0;
            this.mainWindow = mainWindow;
            this.currentSettings = null;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedIndex == 0)
            {
                descriptionTextBox.Text = "Pick an Item from the combobox above.";

                previewGroupBox.Controls.Clear();

            }
            else if (itemComboBox.SelectedIndex == 1)
            {
                descriptionTextBox.Text = "The String Text allows for text input. Basically anything ranging from all the leters to numbers and symbols can be inputed using this panel." + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Team Name" + Environment.NewLine +"Location Name";

                previewGroupBox.Controls.Clear();
                StringText previewControl = new StringText();
                previewGroupBox.Controls.Add(previewControl);
                previewControl.Location = new Point((previewGroupBox.Height / 2) - (previewControl.Size.Height / 2), (previewGroupBox.Width / 2) - (previewControl.Size.Width / 2));

                Point oldLocation = new Point(settingsGroupBox.Location.X, settingsGroupBox.Location.Y);
                Size oldSize = new Size(settingsGroupBox.Width, settingsGroupBox.Height);

                settingsGroupBox.Hide();

                StringTextSettings newSettings = new StringTextSettings();
                this.Controls.Add(newSettings);
                newSettings.Size = oldSize;
                newSettings.Location = oldLocation;
            }
            else if (itemComboBox.SelectedIndex == 2)
            {
                descriptionTextBox.Text = "The Incremental Numerical allows for numerical input and incrementations. Only numbers can be present in this panel, no numbers or symbols. " + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Score" + Environment.NewLine + "Indicator of Half or Quarter" + Environment.NewLine + "Number of shots on goal";

                previewGroupBox.Controls.Clear();
            } else if (itemComboBox.SelectedIndex == 3)
            {
                descriptionTextBox.Text = "The Timer allows for a countdown clock. " + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Game Clock" + Environment.NewLine + "Time out Clock";

                previewGroupBox.Controls.Clear();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (itemComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("You have not selected an item to add. Please choose an item from the combobox.");
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            //this.mainWindow.addBlockPanel();
        }

        private void updateSettingsPanel()
        {

        }
    }
}
