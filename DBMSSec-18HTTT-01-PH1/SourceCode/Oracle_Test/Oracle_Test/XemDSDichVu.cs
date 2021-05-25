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
    public partial class XemDSDichVu : Form
    {
        public XemDSDichVu(OracleConnection oc)
        {
            oc.Close();
            InitializeComponent();
        }

        public OracleConnection con = new OracleConnection();
        public void FillDSDV()
        {
            con.ConnectionString = "User Id=" + globalConnect.userid +
        ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                string command = "admin1.DichVu_TT";
                OracleCommand cmd = new OracleCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                /*cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));*/
                cmd.ExecuteNonQuery();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dsDV.DataSource = dt;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XemDSDichVu_Load(object sender, EventArgs e)
        {
            FillDSDV();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
