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
    public partial class themuserScreen : Form
    {
        public themuserScreen()
        {
            InitializeComponent();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            //con.ConnectionString = "User Id=SYSTEM;Password=123456;Data Source=localhost:1521/xe";
            string x = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe;";
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe;"; 
       
            con.Open();

            //string connect_string = "grant create session to " + username_text.Text + ";";

            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.createUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                    cmd.Parameters.Add("pass_word", OracleDbType.NVarchar2).Value = password_text.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo user thành công!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Tài khoản đã tồn tại.");
            }
            con.Close();

            con.ConnectionString = "User Id=SYS" +
                ";Password=123456" + ";Data Source=localhost:1521/xe;DBA Privilege=SYSDBA";
            con.Open();
            string cmd_x = "grant execute on sys.dbms_crypto to " + username_text.Text;
            try
            {
                using (OracleCommand cmd = new OracleCommand(cmd_x, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Tạo user thành công!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("Tài khoản đã tồn tại.");
            }
            con.Close();

            txsur_user_Option t = new txsur_user_Option();
            t.Show();
            this.Dispose();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            txsur_user_Option t = new txsur_user_Option();
            t.Show();
            this.Dispose();
        }
    }
}
