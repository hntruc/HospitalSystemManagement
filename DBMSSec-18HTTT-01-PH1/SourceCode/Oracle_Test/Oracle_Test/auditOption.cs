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
    public partial class auditOption : Form
    {
        public auditOption()
        {
            InitializeComponent();
        }

        private void audit_lo_Click(object sender, EventArgs e)
        {
            auditLogOn a = new auditLogOn();
            a.Show();
            this.Hide();
        }

        private void audit_dt_Click(object sender, EventArgs e)
        {
            auditDT a = new auditDT();
            a.Show();
            this.Hide();
        }

        private void audit_hsbn_Click(object sender, EventArgs e)
        {
            auditHSBN a = new auditHSBN();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }
        public OracleConnection con = new OracleConnection();
        private void enable_btn_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "User Id=" + globalConnect.userid +
         ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                string command = "admin1.EN_AUD_LOGON";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string command = "admin1.EN_AUD_HOSOBENHAN";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string command = "admin1.EN_AUD_DONTHUOC";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Khởi động audit toàn hệ thống thành công!");
            con.Close();
        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "User Id=" + globalConnect.userid +
        ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                string command = "admin1.DIS_AUD_LOGON";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string command = "admin1.DIS_AUD_HOSOBENHAN";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string command = "admin1.DIS_AUD_DONTHUOC";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Tắt audit toàn hệ thống thành công!");
            con.Close();
        }
    }
}
