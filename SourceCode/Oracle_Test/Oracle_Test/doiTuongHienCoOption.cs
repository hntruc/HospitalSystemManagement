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
    public partial class doiTuongHienCoOption : Form
    {
        public doiTuongHienCoOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }

        private void xem_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();

            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                if (role_radio.Checked == true)
                {
                    string name = "admin1.xemDanhSachRole";
                    OracleCommand cmd = new OracleCommand(name, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter
                        ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                    cmd.ExecuteNonQuery();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dsObject.DataSource = dt;
                    }


                    con.Close();
                }
                else if (table_radio.Checked == true)
                {
                    string name = "admin1.xemDanhSachTable";
                    OracleCommand cmd = new OracleCommand(name, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter
                        ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                    cmd.ExecuteNonQuery();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dsObject.DataSource = dt;
                    }


                    con.Close();
                }
                else if (view_radio.Checked == true)
                {
                    string name = "admin1.xemDanhSachView";
                    OracleCommand cmd = new OracleCommand(name, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter
                        ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                    cmd.ExecuteNonQuery();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dsObject.DataSource = dt;
                    }


                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống bị lỗi tạm thời!");
            }
        }
    }
}
