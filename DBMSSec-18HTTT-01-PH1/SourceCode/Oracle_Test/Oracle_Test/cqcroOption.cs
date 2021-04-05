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
    public partial class cqcroOption : Form
    {
        public cqcroOption()
        {
            InitializeComponent();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            cqcro_Screen cx = new cqcro_Screen();
            cx.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            cqcro_Screen_Update cb = new cqcro_Screen_Update();
            cb.Show();
            this.Hide();
        }
    }
}
