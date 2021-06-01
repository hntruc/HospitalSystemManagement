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
                string name = "admin1.checkLogin";
                OracleCommand cmd = new OracleCommand(name, con);
             
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("sth", OracleDbType.Int16, 21, ParameterDirection.ReturnValue);

                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username_text.Text;
                
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["sth"].Value.ToString();

                if (result == "1") // Admin
                {
                    con.Close();

                    globalConnect.userid = username_text.Text;
                    globalConnect.password = password_text.Text;

                    OracleConnection new_con = new OracleConnection();
                    new_con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
                    new_con.Open();

                    functionScreen f = new functionScreen(new_con);
                    f.Show();
                    this.Hide();
                }
                else if (result == "2") // BacSi
                {
                    con.Close();

                    globalConnect.userid = username_text.Text;
                    globalConnect.password = password_text.Text;

                    OracleConnection new_con = new OracleConnection();
                    new_con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
                    new_con.Open();

                    HoSoBenhNhan h = new HoSoBenhNhan(new_con);
                    h.Show();
                    this.Hide();

                }
                else if (result == "3") // Tiep tan va dieu phoi benh
                {
                    con.Close();

                    globalConnect.userid = username_text.Text;
                    globalConnect.password = password_text.Text;

                    OracleConnection new_con = new OracleConnection();
                    new_con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
                    new_con.Open();

                    XemDSDichVu x = new XemDSDichVu(new_con);
                    x.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại!");
                //MessageBox.Show(ex.ToString());
            }
            con.Close(); 
        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            /*if (globalConnect.userid == "admin1" || globalConnect.userid == "ADMIN1")
            {
                Application.Exit();
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
                con.Close();*/
                Application.Exit();
        }
    }
}
