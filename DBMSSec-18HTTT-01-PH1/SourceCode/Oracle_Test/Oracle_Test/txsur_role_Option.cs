using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Test
{
    public partial class txsur_role_Option : Form
    {
        public txsur_role_Option()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            txsurOption t = new txsurOption();
            t.Show();
            this.Hide();

        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            themroleScreen t = new themroleScreen();
            t.Show();
            this.Hide();
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            xoaroleScreen x = new xoaroleScreen();
            x.Show();
            this.Hide();
        }
    }
}
