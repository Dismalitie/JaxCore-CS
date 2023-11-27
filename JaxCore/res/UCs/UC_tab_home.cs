using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaxCore.res.UCs
{
    public partial class UC_tab_home : UserControl
    {
        public UC_tab_home()
        {
            InitializeComponent();
        }

        DevTools devtools = new DevTools();
        int devclick = 0;

        private void discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/core-community-880445067754610688");
        }

        private void deviant_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.deviantart.com/jaxoriginals");
        }

        private void site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jaxcore.app/");
        }

        private void kofi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/jaxoriginals");
        }

        private void jaxsplash_Click(object sender, EventArgs e)
        {
            if (devclick == 5)
            {
                devtools.Show();
                devclick = 0;
            }
            else
            {
                devclick++;
            }
        }
    }
}
