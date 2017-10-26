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
            updateBlockContainer();
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
            updateBlockContainer();
        }

        // Shows the help form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new HelpForm();
            newWindow.Show();
        }

        // Update the FlowLayout container with current scene's block array
        public void updateBlockContainer()
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
                modifyOrderToolStripMenuItem.Enabled = false;
                this.dragAllowed = false;
                lockToolStripMenuItem.Text = "Unlock";
            }
            else if (lockToolStripMenuItem.Text == "Unlock")
            {
                addItemToolStripMenuItem.Enabled = true;
                removePanelToolStripMenuItem.Enabled = true;
                modifyOrderToolStripMenuItem.Enabled = true;
                this.dragAllowed = true;
                lockToolStripMenuItem.Text = "Lock";
            }

        }

        private void removePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new RemovePanelForm(this);
            newWindow.Show();
        }

        public Scene getCurrentScene()
        {
            return this.currentScene;
        }
    }
}
