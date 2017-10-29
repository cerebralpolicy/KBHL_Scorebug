using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms;
using WindowsFormsApplication1;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        // Declaring private fields
        private Scene currentScene;
        private bool dragAllowed;

        // Constructor
        public MainForm()
        {
            // Initializes form and creates a new scene
            InitializeComponent();
            this.currentScene = new Scene();
            this.dragAllowed = true;
            sceneNameLabel.Text = this.currentScene.getName();
            updateForm();
        }

        // Closes the program
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Shows the add panels window which allows you to add panels to the current scene
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new addPanelForm(this);
            newWindow.Show();
        }

        // Function that gets called from the add panels window to add a panel to the scene
        public void addBlockPanel(BlockPanel panel)
        {
            this.currentScene.addBlock(panel);
            updateForm();
        }

        // Shows the help form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new HelpForm();
            newWindow.Show();
        }

        // Update the FlowLayout container with current scene's block array
        private void updateBlockContainer()
        {
            flowLayoutPanel.Controls.Clear();
            if (this.currentScene.getBlockArray().Count > 0)
            {
                this.noPanelsLabel.Hide();
                for (int x = 0; x < this.currentScene.getBlockArray().Count; x++)
                {
                    this.flowLayoutPanel.Controls.Add(this.currentScene.getBlockArray()[x]);
                }
            }
            else
            {
                this.noPanelsLabel.Show();
            }

        }

        // A public method to update the form after changes were made to it
        public void updateForm()
        {
            updateBlockContainer();
            sceneNameLabel.Text = this.currentScene.getName();
        }

        // Controls drag and drop inside the FlowLayout container
        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (dragAllowed == true)
            {

            }
        }

        // Locks drag and drop as well as other scene menus
        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lockToolStripMenuItem.Text == "Lock")
            {
                addItemToolStripMenuItem.Enabled = false;
                removePanelToolStripMenuItem.Enabled = false;
                this.dragAllowed = false;
                lockToolStripMenuItem.Text = "Unlock";
            }
            else if (lockToolStripMenuItem.Text == "Unlock")
            {
                addItemToolStripMenuItem.Enabled = true;
                removePanelToolStripMenuItem.Enabled = true;
                this.dragAllowed = true;
                lockToolStripMenuItem.Text = "Lock";
            }

        }

        // Opens the remove panel window
        private void removePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new RemovePanelForm(this);
            newWindow.Show();
        }

        // Public method to obtain the current scene from anywhere
        public Scene getCurrentScene()
        {
            return this.currentScene;
        }

        // Opens the settings page for the current scene
        private void sceneSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new SceneSettingsForm(this);
            newWindow.Show();
        }

        // Asks the user before wiping the scene
        private void newSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to create a new scene? (Make sure you save the scene before clicking Yes)", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.currentScene = new Scene();
                updateForm();
            }
        }

        // Loads the instance of the current scene from a file and loads it into the current session
        private void loadSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "Scene Files | .sbb";
            DialogResult saveDialog = openFileDialog1.ShowDialog();

            if (saveDialog == DialogResult.OK || !saveFileDialog1.CheckPathExists)
            {
                using (Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    this.currentScene = (Scene)bformatter.Deserialize(stream);
                    updateForm();
                }
            }
        }

        // Saves the instance of the current scene to a file
        private void saveSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog1.FileName = this.currentScene.getName() + ".sbb";
            saveFileDialog1.Filter = "Scene Files | .sbb";
            DialogResult saveDialog = saveFileDialog1.ShowDialog();

            if (saveDialog == DialogResult.OK || !saveFileDialog1.CheckPathExists) 
            {
                using (Stream stream = File.Open(saveFileDialog1.FileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, this.currentScene);
                }
            }


        }
    }
}
