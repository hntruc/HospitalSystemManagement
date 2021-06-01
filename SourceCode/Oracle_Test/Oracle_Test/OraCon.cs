using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Test
{
    public class OraCon
    {
        OracleConnection con;
        public void Connect()
        {
/*            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "123456";
            ocsb.UserID = "SYSTEM";
            ocsb.DataSource = "localhost:1521/xe";

            // connect
            con.ConnectionString = ocsb.ConnectionString;
            con.Open();*/

            con = new OracleConnection();
            con.ConnectionString = "User Id=SYSTEM;Password=123456;Data Source=localhost:1521/xe";
            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
        }

        public void Command(string cmd)
        {
            OracleCommand query = new OracleCommand(cmd, con);
        }

        public void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
}
