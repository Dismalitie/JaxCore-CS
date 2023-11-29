using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaxCore
{
    public partial class DevTools : Form
    {
        public DevTools()
        {
            InitializeComponent();
        }

        Functions f = new Functions();

        private void DevTools_Load(object sender, EventArgs e)
        {
            f.devtools_active = true;
        }

        private void DevTools_Deactivate(object sender, EventArgs e)
        {
            f.devtools_active = false;
        }
    }
}
