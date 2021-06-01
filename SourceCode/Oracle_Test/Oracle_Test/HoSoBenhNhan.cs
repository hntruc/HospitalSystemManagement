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
    public partial class HoSoBenhNhan : Form
    {
/*        public HoSoBenhNhan()
        {
            InitializeComponent();
        }*/

        public HoSoBenhNhan(OracleConnection oc)
        {
            oc.Close();
            InitializeComponent();
        }

        public OracleConnection con = new OracleConnection();
        public void FillHSBN()
        {
            //con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
            con.ConnectionString = "User Id=" + globalConnect.userid +
        ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                string command = "admin1.showHSBN";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                cmd.ExecuteNonQuery();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dsHSBN.DataSource = dt;
                    
                }
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillDT(string makb, string mabs, string ngaygio)
        {
            try
            {
                string command = "admin1.DonThuoc_BS";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));

                cmd.Parameters.Add("makb", OracleDbType.Varchar2).Value = makb;
                cmd.Parameters.Add("mabs", OracleDbType.Varchar2).Value = mabs;
                cmd.Parameters.Add("ngaygio", OracleDbType.Varchar2).Value = ngaygio;

                
                cmd.ExecuteNonQuery();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dsDT.DataSource = dt;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HoSoBenhNhan_Load(object sender, EventArgs e)
        {
            FillHSBN();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            con.Close();
            if (globalConnect.userid == "admin1" || globalConnect.userid == "ADMIN1")
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }

            else
            {
                OracleConnection new_con = new OracleConnection();

                new_con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
                new_con.Open();
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.logOut", new_con))
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
                new_con.Close();

                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void dsHSBN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillDT(this.dsHSBN.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dsHSBN.Rows[e.RowIndex].Cells[3].Value.ToString(), this.dsHSBN.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("Hệ thống tạm thời bị lỗi!");
            }
        }
    }
}
