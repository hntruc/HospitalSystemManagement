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
    public partial class cqOption : Form
    {
        public cqOption()
        {
            InitializeComponent();
        }

        private void cqcu_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void crcu_btn_Click(object sender, EventArgs e)
        {
            capRoleUserScreen c = new capRoleUserScreen();
            c.Show();
            this.Hide();
        }
    }
}
