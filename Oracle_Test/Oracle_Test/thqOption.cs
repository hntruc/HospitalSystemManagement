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
    public partial class thqOption : Form
    {
        public thqOption()
        {
            InitializeComponent();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            thqScreen t = new thqScreen();
            t.Show();
            this.Close();
        }

        private void role_btn_Click(object sender, EventArgs e)
        {
            thqScreen t = new thqScreen();
            t.Show();
            this.Close();
        }
    }
}
