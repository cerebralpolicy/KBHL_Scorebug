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
        // Declaring private fields
        private MainForm mainWindow;

        // Constructor, takes the main window as a parameter in order to preform commands to the main window
        public addPanelForm(MainForm mainWindow)
        {
            InitializeComponent();
            itemComboBox.SelectedIndex = 0;
            this.mainWindow = mainWindow;

        }

        // Changes preview and settings group box based on what item is selected in the combobox
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Different content is displayed based on the selected item
            switch (itemComboBox.SelectedIndex)
            {
                // No item is selecetd
                case 0:
                    descriptionTextBox.Text = "Pick an Item from the combobox above.";
                    updatePanels(null, null);
                    break;
                // String Text is selected
                case 1:
                    descriptionTextBox.Text = "The String Text allows for text input. Basically anything ranging from all the leters to numbers and symbols can be inputed using this panel."
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Team Name" + Environment.NewLine + "Location Name";

                    updatePanels(new StringText(), new StringTextSettings());
                    break;
                // Incremental Numerical is selected
                case 2:
                    descriptionTextBox.Text = "The Incremental Numerical allows for numerical input and incrementations. Only numbers can be present in this panel, no numbers or symbols. "
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Score" + Environment.NewLine + "Indicator of Half or Quarter" + Environment.NewLine + 
                        "Number of shots on goal";

                    updatePanels(new Blocks.IncrementalNumerical(), new Blocks.SettingsBlocks.IncrementalNumericalSettings());
                    break;
                // Timer is selecetd
                case 3:
                    descriptionTextBox.Text = "The Timer allows for a countdown clock. "
                        + Environment.NewLine + Environment.NewLine + "Examples:" + Environment.NewLine + "Game Clock" + Environment.NewLine + "Time out Clock";
                    break;
            }
        }

        // Closes the add panels form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Adds the panel using the mainform's public function to add a panel to the current scene
        private void addButton_Click(object sender, EventArgs e)
        {
            switch (itemComboBox.SelectedIndex)
            {
                // If no item is selected
                case 0:
                    MessageBox.Show("You have not selected an item to add. Please choose an item from the combobox.");
                    break;
                // If any item is selected
                default:
                    SettingsBlock currentSettings = (SettingsBlock)settingsGroupBox.Controls[0];
                    this.mainWindow.addBlockPanel(currentSettings.makeNewBlockUsingSettings());
                    break;
            }
            
        }

        // Updates the preview and settings group boxes
        private void updatePanels(BlockPanel block, SettingsBlock settingsBlock)
        {
            // If block is null, then display no preivew and no settings, otherwise...
            if (block != null)
            {
                // Clears the preview box, creates a block based on user input and inserts it in the dead middle of the preview group box
                previewGroupBox.Controls.Clear();
                UserControl previewControl = block;
                previewGroupBox.Controls.Add(previewControl);
                previewControl.Location = new Point((previewGroupBox.Height / 2) - (previewControl.Size.Height / 2), (previewGroupBox.Width / 2) - (previewControl.Size.Width / 2));

                // Clears the settings box, creates a settings block based on user input and inserts it into the settings group box
                settingsGroupBox.Controls.Clear();
                UserControl newSettings = settingsBlock;
                newSettings.Location = new Point(1, 16);
                settingsGroupBox.Controls.Add((UserControl)newSettings);

            }
            else
            {
                // Clears both group boxes
                previewGroupBox.Controls.Clear();
                settingsGroupBox.Controls.Clear();

                // Adds a "No settings..." label if no item is selected in the combo box
                Label newLabel = new Label();
                newLabel.Text = "The currently selected item has no settings or defaults to configure.";
                newLabel.Dock = DockStyle.Fill;
                newLabel.AutoSize = false;
                settingsGroupBox.Controls.Add(newLabel);
            }
        }
    }
}
