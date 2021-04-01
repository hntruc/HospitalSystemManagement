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
    public partial class functionScreen : Form
    {
        public functionScreen()
        {
            InitializeComponent();
        }

        private void ttvq_btn_Click(object sender, EventArgs e)
        {
            ttvqOption01 t = new ttvqOption01();
            t.Show();
            this.Hide();
        }

        private void thq_btn_Click(object sender, EventArgs e)
        {
            thqOption t = new thqOption();
            t.Show();
            this.Hide();
        }

        private void xdsnd_btn_Click(object sender, EventArgs e)
        {
            xdsndScreen x = new xdsndScreen();
            x.Show();
            this.Hide();    
        }

        private void cq_btn_Click(object sender, EventArgs e)
        {
            cqOption c = new cqOption();
            c.Show();
            this.Hide();
        }

        private void txsur_btn_Click(object sender, EventArgs e)
        {
            txsurOption t = new txsurOption();
            t.Show();
            this.Hide();  
        }

        private void csqur_btn_Click(object sender, EventArgs e)
        {
            csqurOption c = new csqurOption();
            c.Show();
            this.Hide();
        }
    }
}
