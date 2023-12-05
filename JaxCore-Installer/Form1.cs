using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsShortcutFactory;

namespace JaxCore_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams // creates dropshadow
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        string path = "<none>";
        bool installing = false;

        private void select_dir_Click(object sender, EventArgs e)
        {
            if (installing)
            {
                return;
            }

            FolderBrowserDialog dlg = new FolderBrowserDialog();

            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            dlg.Description = "Select a folder to install JaxCore-CS to - we'll make a new subfolder called \"JaxCore-CS\"";
            dlg.ShowNewFolderButton = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Directory.CreateDirectory(dlg.SelectedPath + "\\JaxCore-CS");
                    path = dlg.SelectedPath + "\\JaxCore-CS";
                    select_dir.Text = path;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private async void install_Click(object sender, EventArgs e)
        {
            installing = true;

            if (path == "<none>")
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\JaxCore-CS");
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\JaxCore-CS";
                MessageBox.Show("Looks like you didn't set a install directory! Don't worry, we'll just install it in a subfolder on your Desktop.", "JaxCore-CS Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            install.FillColor = Color.FromArgb(35, 209, 96);
            install.FillColor2 = Color.FromArgb(35, 209, 96);
            install.HoveredState.FillColor = Color.FromArgb(35, 209, 96);
            install.HoveredState.FillColor2 = Color.FromArgb(35, 209, 96);
            install.Image = Properties.Resources.waiting;

            select_dir.Text = "Installing JaxCore!";
            select_dir.Image = Properties.Resources.rocket;

            dep_prog.BackgroundImage = Properties.Resources.download;
            await Task.Run(async () =>
            {
                Process dep_install = new Process();
                dep_install.StartInfo.FileName = "cmd.exe";
                dep_install.StartInfo.RedirectStandardInput = true;
                dep_install.StartInfo.RedirectStandardOutput = true;
                dep_install.StartInfo.UseShellExecute = false;
                dep_install.StartInfo.CreateNoWindow = true;
                dep_install.Start();
                dep_install.StandardInput.WriteLine($"powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/Siticone.UI.dll -O {path}\\Siticone.UI.dll");
                dep_install.StandardInput.Flush();
                dep_install.StandardInput.Close();
                dep_install.WaitForExit();
            });
            dep_prog.BackgroundImage = Properties.Resources.check;

            core_prog.BackgroundImage = Properties.Resources.download;
            await Task.Run(async () =>
            {
                Process core_install = new Process();
                core_install.StartInfo.FileName = "cmd.exe";
                core_install.StartInfo.RedirectStandardInput = true;
                core_install.StartInfo.RedirectStandardOutput = true;
                core_install.StartInfo.UseShellExecute = false;
                core_install.StartInfo.CreateNoWindow = true;
                core_install.Start();
                core_install.StandardInput.WriteLine($"powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/JaxCore.exe -O {path}\\JaxCore.exe");
                core_install.StandardInput.Flush();
                core_install.StandardInput.Close();
                core_install.WaitForExit();
            });
            core_prog.BackgroundImage = Properties.Resources.check;

            extra_prog.BackgroundImage = Properties.Resources.download;
            await Task.Run(async () =>
            {
                WindowsShortcut lnk = new WindowsShortcut();
                lnk.Description = "JaxCore-CS";
                lnk.Path = path + "\\JaxCore.exe";
                lnk.Save(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\JaxCore-CS.lnk");
            });
            extra_prog.BackgroundImage = Properties.Resources.check;

            install.Image = Properties.Resources.check;

            MessageBox.Show("JaxCore successfully installed!", "JaxCore-CS Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start($"{path}\\JaxCore.exe");
            Application.Exit();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
    }
}
