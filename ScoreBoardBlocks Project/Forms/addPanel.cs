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
    public partial class addPanelForm : Form
    {
        private MainForm mainWindow;
        public addPanelForm(MainForm mainWindow)
        {
            InitializeComponent();
            itemComboBox.SelectedIndex = 0;
            this.mainWindow = mainWindow;

        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (itemComboBox.SelectedIndex)
            {
                case 0:
                    descriptionTextBox.Text = "Pick an Item from the combobox above.";
                    updatePanels(null, null);
                    break;
                case 1:
                    descriptionTextBox.Text = "The String Text allows for text input. Basically anything ranging from all the leters to numbers and symbols can be inputed using this panel."
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Team Name" + Environment.NewLine + "Location Name";

                    updatePanels(new StringText(), new StringTextSettings());
                    break;
                case 2:
                    descriptionTextBox.Text = "The Incremental Numerical allows for numerical input and incrementations. Only numbers can be present in this panel, no numbers or symbols. "
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Score" + Environment.NewLine + "Indicator of Half or Quarter" + Environment.NewLine + 
                        "Number of shots on goal";

                    updatePanels(new Blocks.IncrementalNumerical(), new Blocks.SettingsBlocks.IncrementalNumericalSettings());
                    break;
                case 3:
                    descriptionTextBox.Text = "The Timer allows for a countdown clock. "
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Game Clock" + Environment.NewLine + "Time out Clock";
                    break;
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
                default:
                    SettingsBlock currentSettings = (SettingsBlock)settingsGroupBox.Controls[0];
                    this.mainWindow.addBlockPanel(currentSettings.makeNewBlockUsingSettings());
                    break;
            }
            
        }

        private void updatePanels(BlockPanel block, SettingsBlock settingsBlock)
        {
            if (block != null)
            {
                previewGroupBox.Controls.Clear();
                UserControl previewControl = block;
                previewGroupBox.Controls.Add(previewControl);
                previewControl.Location = new Point((previewGroupBox.Height / 2) - (previewControl.Size.Height / 2), (previewGroupBox.Width / 2) - (previewControl.Size.Width / 2));

                settingsGroupBox.Controls.Clear();
                UserControl newSettings = settingsBlock;
                newSettings.Location = new Point(1, 16);
                settingsGroupBox.Controls.Add((UserControl)newSettings);

            }
            else
            {
                previewGroupBox.Controls.Clear();
                settingsGroupBox.Controls.Clear();

                Label newLabel = new Label();
                newLabel.Text = "The currently selected item has no settings or defaults to configure.";
                newLabel.Dock = DockStyle.Fill;
                newLabel.AutoSize = false;
                settingsGroupBox.Controls.Add(newLabel);
            }
        }
    }
}
