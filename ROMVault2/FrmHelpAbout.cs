﻿/******************************************************
 *     ROMVault2 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2014                                 *
 ******************************************************/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ROMVault2
{
    public partial class FrmHelpAbout : Form
    {
        public FrmHelpAbout()
        {
            InitializeComponent();
            Text = "Version " + Program.Version + "." + Program.SubVersion + " : " + Application.StartupPath;
            lblVersion.Text = "Version " + Program.Version + "." + Program.SubVersion;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string url = "http://www.romvault.com/";
            Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "mailto:support@romvault.com?subject=Support " + Program.Version + "." + Program.SubVersion;
                Process.Start(url);
            }
            catch
            {
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://paypal.me/romvault");
        }
        
    }
}