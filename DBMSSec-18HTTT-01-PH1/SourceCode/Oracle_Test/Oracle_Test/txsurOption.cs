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
    public partial class txsurOption : Form
    {
        public txsurOption()
        {
            InitializeComponent();
        }

        private void role_btn_Click(object sender, EventArgs e)
        {
            txsur_role_Option t = new txsur_role_Option();
            t.Show();
            this.Close();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            txsur_user_Option t = new txsur_user_Option();
            t.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }
    }
}
