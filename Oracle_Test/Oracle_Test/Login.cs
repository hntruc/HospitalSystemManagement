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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void dangnhap_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
            con.Open();

            try
            {
                string name = "checkLogin";
                OracleCommand cmd = new OracleCommand(name, con);
             
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("sth", OracleDbType.Int16, 21, ParameterDirection.ReturnValue);

                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username_text.Text;
                
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["sth"].Value.ToString();

                if (result == "1")
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    globalConnect.userid = username_text.Text;
                    globalConnect.password = password_text.Text;

                    functionScreen f = new functionScreen();
                    f.Show();
                    this.Hide();

                    this.Dispose();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close(); 
        }
    }
}
