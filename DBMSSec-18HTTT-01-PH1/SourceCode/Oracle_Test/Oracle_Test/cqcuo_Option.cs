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
    public partial class cqcuo_Option : Form
    {
        public cqcuo_Option()
        {
            InitializeComponent();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            cqcuo_Screen c = new cqcuo_Screen();
            c.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            cqcuo_Screen_Update c = new cqcuo_Screen_Update();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cqOption c = new cqOption();
            c.Show();
            this.Hide();
        }
    }
}
