using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialScreen());

            /*OracleConnection con = new OracleConnection();*/

            /*// create connection string using builder
            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "autumn117";
            ocsb.UserID = "john";
            ocsb.DataSource = "database.url:port/databasename";*/

            /*// connect
            con.ConnectionString = ocsb.ConnectionString;
            con.Open();
            Console.WriteLine("Connection established (" + con.ServerVersion + ")");*/

            
        }
    }
}
