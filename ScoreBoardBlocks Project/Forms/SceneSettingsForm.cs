using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace WindowsFormsApplication1.Forms
{
    public partial class SceneSettingsForm : Form
    {
        private MainForm mainForm;
        private int width;
        private int height;
        Size BASE_SIZE = new Size(512, 265);

        public SceneSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            nameTextBox.Text = mainForm.getCurrentScene().getName();
            folderPathTextBox.Text = mainForm.getCurrentScene().getFolderPath();
            sizeTextBox.Text = "Width: " + mainForm.Width + " | Height: " + mainForm.Height;

            widthNumericUpDown.Value = ((this.mainForm.Width - BASE_SIZE.Width) / 156) + 3;
            heightNumericUpDown.Value = ((this.mainForm.Height - BASE_SIZE.Height) / 156) + 1;
            updateBlockList();
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = SpecialFolder.Desktop;
                if (Directory.Exists(folderPathTextBox.Text))
                {
                    fbd.SelectedPath = folderPathTextBox.Text;
                }
                else
                {
                    fbd.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
                }
                

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString() + Environment.NewLine + files, "Message");

                    folderPathTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void applySettings()
        {
            mainForm.getCurrentScene().setName(nameTextBox.Text);
            mainForm.getCurrentScene().setFolderPath(folderPathTextBox.Text);

            mainForm.Size = new Size(this.width, this.height);

            mainForm.updateForm();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applySettings();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applySettings();
            this.Close();
        }

        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void heightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void updateSize()
        {
            this.width = BASE_SIZE.Width + (((Int32)widthNumericUpDown.Value - 3) * 156);
            this.height = BASE_SIZE.Height + (((Int32)heightNumericUpDown.Value - 1) * 156);

            sizeTextBox.Text = "Width: " + this.width + " | Height: " + this.height;
        }

        private void updateBlockList()
        {
            blockListBox.Items.Clear();
            if (mainForm.getCurrentScene().getBlockArray().Count > 0)
            {
                for (int x = 0; x < mainForm.getCurrentScene().getBlockArray().Count; x++)
                {
                    String blockName = mainForm.getCurrentScene().getBlockArray()[x].toString();
                    String temp = Convert.ToString(mainForm.getCurrentScene().getBlockArray()[x].GetType());
                    String[] blockType = temp.Split('.');
                    blockListBox.Items.Add(blockType[blockType.Length - 1] + " | Name: " + blockName);
                }

                blockListBox.SelectedIndex = 0;
            }
        }

        private void SceneSettingsForm_Activated(object sender, EventArgs e)
        {
            updateBlockList();
        }
    }
}
