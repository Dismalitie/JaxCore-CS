using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaxCore_Installer
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        WebClient loader  = new WebClient();

        private void cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void install_Click(object sender, EventArgs e)
        {

        }
    }
}
