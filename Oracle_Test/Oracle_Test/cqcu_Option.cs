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
    public partial class cqcu_Option : Form
    {
        public cqcu_Option()
        {
            InitializeComponent();
        }

        private void yobject_btn_Click(object sender, EventArgs e)
        {
            cqcuo_Screen c = new cqcuo_Screen();
            c.Show();
            this.Hide();
        }

        private void nobject_btn_Click(object sender, EventArgs e)
        {
            cqcuScreen c = new cqcuScreen();
            c.Show();
            this.Hide();
        }
    }
}
