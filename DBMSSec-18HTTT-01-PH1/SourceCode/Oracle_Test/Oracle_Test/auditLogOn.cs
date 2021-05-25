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
    public partial class auditLogOn : Form
    {
        public auditLogOn()
        {
            InitializeComponent();
        }
        public OracleConnection con = new OracleConnection();
        private void auditLogOn_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "User Id=admin1;Password=abc;Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                string command = "admin1.showAuditLO";
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auditOption a = new auditOption();
            a.Show();
            this.Close();
        }
    }
}
