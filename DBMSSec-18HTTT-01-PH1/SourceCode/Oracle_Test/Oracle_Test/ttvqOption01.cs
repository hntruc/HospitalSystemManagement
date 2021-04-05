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
    public partial class ttvqOption01 : Form
    {
        public ttvqOption01()
        {
            InitializeComponent();
        }

        private void ttvqcutcdtdl_btn_Click(object sender, EventArgs e)
        {
            ttvqOption t = new ttvqOption();
            t.Show();
            this.Hide();
        }

        private void ttvqcu_btn_Click(object sender, EventArgs e)
        {
            ttvqUserScreen t = new ttvqUserScreen();
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
