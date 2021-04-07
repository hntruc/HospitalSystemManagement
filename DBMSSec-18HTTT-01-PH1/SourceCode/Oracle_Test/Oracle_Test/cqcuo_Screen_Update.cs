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
    public partial class cqcuo_Screen_Update : Form
    {
        public cqcuo_Screen_Update()
        {
            InitializeComponent();
        }
        int flag = 0;

        private void cqcuo_Screen_Update_Load(object sender, EventArgs e)
        {
            tblname_combo.Items.Add("Bệnh nhân");
            tblname_combo.Items.Add("Triệu chứng ban đầu");
            tblname_combo.Items.Add("Hồ sơ bệnh nhân");
            tblname_combo.Items.Add("Hóa đơn khám bệnh");
            tblname_combo.Items.Add("Hồ sơ dịch vụ");
            tblname_combo.Items.Add("Dịch vụ");
            tblname_combo.Items.Add("Hóa đơn dịch vụ");
            tblname_combo.Items.Add("Đơn thuốc");
            tblname_combo.Items.Add("Thuốc");
            tblname_combo.Items.Add("Chi tiết đơn thuốc");
            tblname_combo.Items.Add("Hóa đơn thuốc");
            tblname_combo.Items.Add("Bác sĩ");
            tblname_combo.Items.Add("Khoa");
            tblname_combo.Items.Add("Nhân viên");
            tblname_combo.Items.Add("Lịch trực");
            tblname_combo.Items.Add("Loại nhân viên");
            tblname_combo.Items.Add("Bảng chấm công");
        }

        private void tblname_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cotname_combo.Items.Clear();
            if (tblname_combo.SelectedItem == "Bệnh nhân")
            {
                cotname_combo.Items.Add("MAKB, TEN, NAMSINH, DIACHI, SDT");
            }
            else if (tblname_combo.SelectedItem == "Triệu chứng ban đầu")
            {
                cotname_combo.Items.Add("MAKB, STT, TRIEUCHUNGBENH, NGAYGIO");
            }
            else if (tblname_combo.SelectedItem == "Hồ sơ bệnh nhân")
            {
                cotname_combo.Items.Add("MAKB, STT, NGAY, MABS, TRIEUCHUNG, KETLUAN");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn khám bệnh")
            {
                cotname_combo.Items.Add("TONGTIEN (HDKB)");
            }
            else if (tblname_combo.SelectedItem == "Hồ sơ dịch vụ")
            {
                cotname_combo.Items.Add("KETLUAN");
            }
            else if (tblname_combo.SelectedItem == "Dịch vụ")
            {
                cotname_combo.Items.Add("DONGIA");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn dịch vụ")
            {
                cotname_combo.Items.Add("TONGTIEN (HDDV)");
            }
            else if (tblname_combo.SelectedItem == "Đơn thuốc")
            {
                cotname_combo.Items.Add("MADT, MAKB, MABS, DANDO, NGAYGIO");
            }
            else if (tblname_combo.SelectedItem == "Thuốc")
            {
                cotname_combo.Items.Add("GIATIEN");
            }
            else if (tblname_combo.SelectedItem == "Chi tiết đơn thuốc")
            {
                cotname_combo.Items.Add("MADT, MATHUOC, SOLUONG, DONVI, DANDO");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn thuốc")
            {
                cotname_combo.Items.Add("TONGTIEN (HDT)");
            }
            else if (tblname_combo.SelectedItem == "Bác sĩ")
            {
                cotname_combo.Items.Add("PHUCAP, LUONGCOBAN (BS)");
                cotname_combo.Items.Add("MABS, TENBS, MACK, PHUCAP, LUONGCOBAN");
            }
            else if (tblname_combo.SelectedItem == "Khoa")
            {
                cotname_combo.Items.Add("MAKHOA, TENKHOA");
            }
            else if (tblname_combo.SelectedItem == "Nhân viên")
            {
                cotname_combo.Items.Add("PHUCAP, LUONGCOBAN (NV)");
                cotname_combo.Items.Add("MANV, TENNVM, MALOAI, PHUCAP, LUONGCOBAN");
            }
            else if (tblname_combo.SelectedItem == "Lịch trực")
            {
                cotname_combo.Items.Add("MABS, THOIGIAN, PHONGTRUC");
            }
            else if (tblname_combo.SelectedItem == "Loại nhân viên")
            {
                cotname_combo.Items.Add("MALOAI, TENLOAI");
            }
            else if (tblname_combo.SelectedItem == "Bảng chấm công")
            {
                cotname_combo.Items.Add("MANV, NGAYCONG");
            }
        }

        private void cotname_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cotname_combo.SelectedItem == "MAKB, TEN, NAMSINH, DIACHI, SDT")
            {
                flag = 1;
            }
            else if (cotname_combo.SelectedItem == "MAKB, STT, TRIEUCHUNGBENH, NGAYGIO")
            {
                flag = 2;
            }
            else if (cotname_combo.SelectedItem == "MAKB, STT, NGAY, MABS, TRIEUCHUNG, KETLUAN")
            {
                flag = 3;
            }
            else if (cotname_combo.SelectedItem == "TONGTIEN (HDKB)")
            {
                flag = 4;
            }
            else if (cotname_combo.SelectedItem == "KETLUAN")
            {
                flag = 6;
            }
            else if (cotname_combo.SelectedItem == "DONGIA")
            {
                flag = 7;
            }
            else if (cotname_combo.SelectedItem == "TONGTIEN (HDDV)")
            {
                flag = 8;
            }
            else if (cotname_combo.SelectedItem == "MADT, MAKB, MABS, DANDO, NGAYGIO")
            {
                flag = 10;
            }
            else if (cotname_combo.SelectedItem == "GIATIEN")
            {
                flag = 11;
            }
            else if (cotname_combo.SelectedItem == "MADT, MATHUOC, SOLUONG, DONVI, DANDO")
            {
                flag = 12;
            }
            else if (cotname_combo.SelectedItem == "TONGTIEN (HDT)")
            {
                flag = 14;
            }
            else if (cotname_combo.SelectedItem == "PHUCAP, LUONGCOBAN (BS)")
            {
                flag = 16;
            }
            else if (cotname_combo.SelectedItem == "MABS, TENBS, MACK, PHUCAP, LUONGCOBAN")
            {
                flag = 15;
            }
            else if (cotname_combo.SelectedItem == "MAKHOA, TENKHOA")
            {
                flag = 18;
            }
            else if (cotname_combo.SelectedItem == "PHUCAP, LUONGCOBAN (NV)")
            {
                flag = 20;
            }
            else if (cotname_combo.SelectedItem == "MANV, TENNVM, MALOAI, PHUCAP, LUONGCOBAN")
            {
                flag = 19;
            }
            else if (cotname_combo.SelectedItem == "MABS, THOIGIAN, PHONGTRUC")
            {
                flag = 22;
            }
            else if (cotname_combo.SelectedItem == "MALOAI, TENLOAI")
            {
                flag = 23;
            }
            else if (cotname_combo.SelectedItem == "MANV, NGAYCONG")
            {
                flag = 24;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cqOption c = new cqOption();
            this.Hide();
            c.Show();
        }

        private void cq_btn_Click(object sender, EventArgs e)
        {
            int check = 0;
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();

            if (withgrantoption.Checked == true)
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.GRANT_UPDATE_GO", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("FLAG", OracleDbType.Int32).Value = flag;
                        cmd.Parameters.Add("USER_ROLE", OracleDbType.Varchar2).Value = username_text.Text;
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
            else
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin1.GRANT_UPDATE", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("FLAG", OracleDbType.Int32).Value = flag;
                        cmd.Parameters.Add("USER_ROLE", OracleDbType.Varchar2).Value = username_text.Text;
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
}
