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
    public partial class UC_tab_shop : UserControl
    {
        public UC_tab_shop()
        {
            InitializeComponent();
        }

        private void mixer_vekl_buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/s/f06be1d398");
        }

        private void flyouts_sleek_buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/s/da32a5e6d2");
        }

        private void flyouts_vekl_buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/s/749a882821");
        }

        private void valli_vekl_buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/s/e4ba7e5dd1");
        }
    }
}

