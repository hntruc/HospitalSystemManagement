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
    public partial class xoauserScreen : Form
    {
        public xoauserScreen()
        {
            InitializeComponent();
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.deleteUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa user thành công!");
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
    }
}
