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
    public partial class themroleScreen : Form
    {
        public themroleScreen()
        {
            InitializeComponent();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            /* con.ConnectionString = "User Id=SYSTEM;Password=123456;Data Source=localhost:1521/xe";*/
            string x = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            //MessageBox.Show(x);
            con.ConnectionString = x;
            con.Open();
            //string connect_string = "grant create session to " + username_text.Text + ";";

            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.createRole", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo role thành công!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Role đã tồn tại.");
            }
            con.Close();

            txsur_role_Option t = new txsur_role_Option();
            t.Show();
            this.Dispose();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            txsur_role_Option t = new txsur_role_Option();
            t.Show();
            this.Dispose();
        }
    }
}
