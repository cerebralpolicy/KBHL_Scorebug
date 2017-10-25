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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void youtubeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            youtubeLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/user/LCTVNEWS");
        }

        private void githubMainLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubMainLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MarcusOy/ScoreBoardBlocksOBS");
        }

        private void githubWikiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubWikiLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MarcusOy/ScoreBoardBlocksOBS/wiki");
        }

        private void discordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            discordLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.discord.gg/kxCjsJJ");
        }
    }
}
