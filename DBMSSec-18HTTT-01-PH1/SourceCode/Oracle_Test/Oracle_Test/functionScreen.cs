using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            thqUserOption t = new thqUserOption();
            t.Show();
            this.Close();
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
            if (globalConnect.userid == "admin1" || globalConnect.userid == "ADMIN1")
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            
            else
            {
                OracleConnection con = new OracleConnection();

                con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
                con.Open();
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.logOut", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = globalConnect.userid;
                        cmd.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }
    }
}
