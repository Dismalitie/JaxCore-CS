using JaxCore.res.UCs;
using System;
using System.Windows.Forms;

namespace JaxCore
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

        Functions f = new Functions();

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_tab_home home = new UC_tab_home();

            Text = f.title;
            title.Text = f.title;

            cont.Controls.Add(home);
        }

        private void cls_MouseEnter(object sender, EventArgs e)
        {
            cls.BackgroundImage = Properties.Resources.x_alt;
        }

        private void cls_MouseLeave(object sender, EventArgs e)
        {
            cls.BackgroundImage = Properties.Resources.x;
        }

        private void min_MouseEnter(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.minus_alt;
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.minus;
        }

        private void cls_Click(object sender, EventArgs e)
        {
            fd_out.Enabled = true;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fd_in_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1)
            {
                Opacity = Opacity + 0.2;
            }
            else
            {
                fd_in.Enabled = false;
            }
        }

        private void fd_out_Tick(object sender, EventArgs e)
        {
            if (Opacity != 0)
            {
                Opacity = Opacity - 0.2;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
