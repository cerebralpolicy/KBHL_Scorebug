using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class RemovePanelForm : Form
    {
        private MainForm mainWindow;
        public RemovePanelForm(MainForm mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            updateBlockList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (blockListBox.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Remove Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    mainWindow.getCurrentScene().removeBlock(blockListBox.SelectedIndex);
                    updateBlockList();
                    mainWindow.updateForm();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBlockList()
        {
            blockListBox.Items.Clear();
            if (mainWindow.getCurrentScene().getBlockArray().Count > 0)
            {
                for (int x = 0; x < mainWindow.getCurrentScene().getBlockArray().Count; x++)
                {
                    String blockName = mainWindow.getCurrentScene().getBlockArray()[x].toString();
                    String temp = Convert.ToString(mainWindow.getCurrentScene().getBlockArray()[x].GetType());
                    String[] blockType = temp.Split('.');
                    blockListBox.Items.Add(blockType[1] + " | Name: " + blockName);
                }

                blockListBox.SelectedIndex = 0;
            }
        }

        private void RemovePanelForm_Activated(object sender, EventArgs e)
        {
            updateBlockList();
        }
    }
}
