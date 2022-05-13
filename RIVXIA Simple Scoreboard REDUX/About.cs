using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIVXIA_Simple_Scoreboard_REDUX
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void aboutGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/DylanVeeeee");
        }

        private void aboutTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutTwitter.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "https://twitter.com/DylanVeeeee");
        }

        private void aboutEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutEmail.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "mailto:dylanverallo@gmail.com");
        }
    }
}
