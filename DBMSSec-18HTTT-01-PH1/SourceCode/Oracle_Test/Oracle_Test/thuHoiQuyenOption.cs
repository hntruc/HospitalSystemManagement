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
    public partial class thuHoiQuyenOption : Form
    {
        public thuHoiQuyenOption()
        {
            InitializeComponent();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            thuHoiQuyenUserScreen th = new thuHoiQuyenUserScreen();
            th.Show();
            this.Hide();
        }

        private void role_btn_Click(object sender, EventArgs e)
        {
            thuHoiQuyenRoleScreen tb = new thuHoiQuyenRoleScreen();
            tb.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thqUserOption t = new thqUserOption();
            t.Show();
            this.Hide();
        }
    }
}
