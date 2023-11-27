using System;
using System.Windows.Forms;
using System.IO;

namespace JaxCore_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.first)
            {
                StreamReader sr = new StreamReader(".\\launcher.path");
                Properties.Settings.Default.path = sr.ReadToEnd() + "JaxCore.exe";
                Properties.Settings.Default.first = true;
                Properties.Settings.Default.Save();
                System.Diagnostics.Process.Start(Properties.Settings.Default.path);
            }
            else
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.path);
            }
        }
    }
}
