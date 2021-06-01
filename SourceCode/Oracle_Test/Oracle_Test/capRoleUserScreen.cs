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
    public partial class capRoleUserScreen : Form
    {
        public capRoleUserScreen()
        {
            InitializeComponent();
        }

        private void cq_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();

            if (y_radio.Checked)
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.grantRoleUserOption", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                        cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cấp role thành công!");
                        txsur_user_Option t = new txsur_user_Option();
                        t.Show();
                        this.Dispose();
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.grantRoleUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                        cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cấp role thành công!");
                        cqOption c = new cqOption();
                        c.Show();
                        this.Hide();
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cqOption c = new cqOption();
            c.Show();
            this.Hide();
        }
    }
}
