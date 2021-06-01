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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=SYSTEM;Password=123456;Data Source=XE";
            con.Open();
            //Console.Write("Connect to Oracle" + con.ServerVersion);
            //label1.Text(con.ServerVersion);
            label1.Text = con.ServerVersion;

            con.Close();
            con.Dispose();*/

            OracleConnection con = new OracleConnection();

            // create connection string using builder
            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "123456";
            ocsb.UserID = "SYSTEM";
            ocsb.DataSource = "localhost:1521/xe";

            // connect
            con.ConnectionString = ocsb.ConnectionString;
            con.Open();

            label1.Text = "Connection established" + con.ServerVersion;

            try
            {
                using (OracleCommand cmd = new OracleCommand("SELECT username FROM dba_users", con))
                {
         
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
