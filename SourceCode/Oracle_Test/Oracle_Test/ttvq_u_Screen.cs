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

            try
            {
                string name = "admin1.xemQuyenRoleObject";
                OracleCommand cmd = new OracleCommand(name, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text.Text;
                cmd.ExecuteNonQuery();

                using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
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
