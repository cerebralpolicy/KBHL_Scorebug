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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newWindow = new addPanelForm(this);
            newWindow.Show();
        }

        public void addBlockPanel(BlockPanel panel)
        {
                UserControl castedPanel = (UserControl)panel;
                this.flowLayoutPanel.Controls.Add(castedPanel);
                this.noPanelsLabel.Hide();
        }
    }
}
