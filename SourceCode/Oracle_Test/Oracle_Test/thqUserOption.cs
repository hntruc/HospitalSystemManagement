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
    public partial class thqUserOption : Form
    {
        public thqUserOption()
        {
            InitializeComponent();
        }

        private void r_btn_Click(object sender, EventArgs e)
        {
            thuHoiRoleScreen t = new thuHoiRoleScreen();
            t.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }

        private void qtbpf_btn_Click(object sender, EventArgs e)
        {
            thuHoiQuyenOption t = new thuHoiQuyenOption();
            t.Show();
            this.Hide();
        }
    }
}
