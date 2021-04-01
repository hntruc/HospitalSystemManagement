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
    public partial class ttvq_u_Screen : Form
    {
        public ttvq_u_Screen()
        {
            InitializeComponent();
        }

        private void xem_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();

            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();

            string command = "select GRANTEE, TABLE_NAME, PRIVILEGE, TYPE from dba_tab_privs where GRANTEE =" + "'" + role_text.Text.ToUpper() + "'";
            try
            {
                using (OracleCommand cmd = new OracleCommand(command, con))
                {

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            ttvqOption t = new ttvqOption();
            t.Show();
            this.Dispose();
        }
    }
}
