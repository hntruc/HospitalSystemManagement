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
    public partial class txsur_user_Option : Form
    {
        public txsur_user_Option()
        {
            InitializeComponent();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            themuserScreen t = new themuserScreen();
            t.Show();
            this.Hide();
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            xoauserScreen x = new xoauserScreen();
            x.Show();
            this.Hide();
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            suauserScreen s = new suauserScreen();
            s.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            txsurOption t = new txsurOption();
            t.Show();
            this.Hide();
        }
    }
}
