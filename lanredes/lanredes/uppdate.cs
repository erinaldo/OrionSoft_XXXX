using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanredes
{
    public partial class uppdate : Form
    {
        public uppdate()
        {
            InitializeComponent();
        }

        private void uppdate_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jhonfv/OrionSoft_XXXX");
        }
    }
}
