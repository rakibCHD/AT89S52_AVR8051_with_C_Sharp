using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT89S52_AVR8051_Programmer
{
    public partial class AT89S52_about : Form
    {
        public AT89S52_about()
        {
            InitializeComponent();
        }

        private void AT89S52_about_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.AT89S52_about;

        }

        private void Linkedin_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/rakibchd/");
        }

        private void Facebook_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/rakib.chd");
        }
    }
}
