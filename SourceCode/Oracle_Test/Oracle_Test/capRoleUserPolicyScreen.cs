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
    public partial class capRoleUserPolicyScreen : Form
    {
        public capRoleUserPolicyScreen()
        {
            InitializeComponent();
        }
        string role_text;

        private void capRoleUserPolicyScreen_Load(object sender, EventArgs e)
        {
            role_combo.Items.Add("Bác sĩ");
            role_combo.Items.Add("Tiếp tân và điều phối bệnh");
        }
        private void role_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (role_combo.SelectedItem.ToString() == "Bác sĩ")
            {
                role_text = "bacsi";
            }
            else if (role_combo.SelectedItem.ToString() == "Tiếp tân và điều phối bệnh")
            {
                role_text = "tieptan_dieuphoi";
            }
        }
        private void cq_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();

            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.grantRoleUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                    cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp role thành công!");
                    functionScreen f = new functionScreen();
                    f.Show();
                    this.Close();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }
    }
}
