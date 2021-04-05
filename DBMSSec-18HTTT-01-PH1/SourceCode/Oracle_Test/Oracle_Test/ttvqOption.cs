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
    public partial class ttvqOption : Form
    {
        public ttvqOption()
        {
            InitializeComponent();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            ttvqScreen t = new ttvqScreen();
            t.Show();
            this.Hide();
        }

        private void role_btn_Click(object sender, EventArgs e)
        {
            ttvq_u_Screen t = new ttvq_u_Screen();
            t.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }
    }
}
