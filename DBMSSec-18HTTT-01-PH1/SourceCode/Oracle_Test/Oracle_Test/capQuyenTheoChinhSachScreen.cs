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
    public partial class capQuyenTheoChinhSachScreen : Form
    {
        public capQuyenTheoChinhSachScreen()
        {
            InitializeComponent();
        }
        int flag = 0;
        string user_name;
        private void capQuyenTheoChinhSachScreen_Load(object sender, EventArgs e)
        {
            tblrole_combo.Items.Add("Bác sĩ");
            tblrole_combo.Items.Add("Tiếp tân và điều phối bệnh");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Close();
        }
        private void tblrole_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblquyen_combo.Items.Clear();
            if (tblrole_combo.SelectedItem.ToString() == "Bác sĩ")
            {
                tblquyen_combo.Items.Add("Xem Hồ Sơ Bệnh Nhân");
            }
            else if (tblrole_combo.SelectedItem.ToString() == "Tiếp tân và điều phối bệnh")
            {
                tblquyen_combo.Items.Add("Xem Danh Sách Dịch Vụ");
            }
        }
        private void tblquyen_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblquyen_combo.SelectedItem.ToString() == "Xem Hồ Sơ Bệnh Nhân")
            {
                flag = 2;
                user_name = "bacsi";
            }
            else if (tblquyen_combo.SelectedItem.ToString() == "Xem Danh Sách Dịch Vụ")
            {
                flag = 1;
                user_name = "tieptan_dieuphoi"; 
            }
        }
        private void cq_btn_Click(object sender, EventArgs e)
        {
            int check = 0;
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.grantExecuteFunction", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = user_name;
                    cmd.Parameters.Add("check_num", OracleDbType.Int32).Value = flag;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                check = 1;
            }
            con.Close();
            if (check != 1)
            {
                MessageBox.Show("Cấp quyền thành công!");
            }
        }
    }
}
