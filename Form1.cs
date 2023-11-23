using JaxCore.res.UCs;
using System;
using System.Drawing;
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
        UC_tab_home tab_home = new UC_tab_home();
        UC_tab_shop tab_shop = new UC_tab_shop();
        UC_tab_lib tab_lib = new UC_tab_lib();
        UC_tab_info tab_inf = new UC_tab_info();

        private void settab(Siticone.UI.WinForms.SiticoneGradientButton button, UserControl tab)
        {
            home.FillColor = Color.FromArgb(30, 30, 30);
            home.FillColor2 = Color.FromArgb(30, 30, 30);
            shop.FillColor = Color.FromArgb(30, 30, 30);
            shop.FillColor2 = Color.FromArgb(30, 30, 30);
            lib.FillColor = Color.FromArgb(30, 30, 30);
            lib.FillColor2 = Color.FromArgb(30, 30, 30);
            inf.FillColor = Color.FromArgb(30, 30, 30);
            inf.FillColor2 = Color.FromArgb(30, 30, 30);
            settings.FillColor = Color.FromArgb(30, 30, 30);
            settings.FillColor2 = Color.FromArgb(30, 30, 30);

            button.FillColor = Color.FromArgb(255, 183, 0);
            button.FillColor2 = Color.FromArgb(240, 52, 0);

            cont.Controls.Clear();
            cont.Controls.Add(tab);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = f.title;

            cont.Controls.Add(tab_home);
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

        private void shop_Click(object sender, EventArgs e)
        {
            settab(shop, tab_shop);
        }

        private void home_Click(object sender, EventArgs e)
        {
            settab(home, tab_home);
        }

        private void lib_Click(object sender, EventArgs e)
        {
            settab(lib, tab_lib);
        }

        private void inf_Click(object sender, EventArgs e)
        {
            settab(inf, tab_inf);
        }
    }
}
