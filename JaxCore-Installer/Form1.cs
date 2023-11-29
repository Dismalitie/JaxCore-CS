using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaxCore_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "<none>";

        private void select_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            dlg.Description = "Select a folder to install JaxCore-CS to";
            dlg.ShowNewFolderButton = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = dlg.SelectedPath.ToString();
                    if (dlg.SelectedPath.Length > 36) // idk how but this solves a bug?
                    {
                        select_dir.Text = path;
                    }
                    else
                    {
                        select_dir.Text = path;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private async void install_Click(object sender, EventArgs e)
        {
            if (path == "<none>")
            {
                Directory.CreateDirectory(Environment.SpecialFolder.MyDocuments.ToString()+"\\JaxCore-CS");
                path = Environment.SpecialFolder.MyDocuments.ToString() + "\\JaxCore-CS".ToString();
                MessageBox.Show("Looks like you didn't set a install directory! Don't worry, we'll just install it in your documents under a new folder.", "JaxCore-CS Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            WebClient wc = new WebClient();
            await wc.DownloadFileTaskAsync("dbg", path);
        }
    }
}
