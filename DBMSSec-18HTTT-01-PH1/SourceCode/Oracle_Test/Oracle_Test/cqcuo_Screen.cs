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
    public partial class cqcuo_Screen : Form
    {
        public cqcuo_Screen()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void cqcuo_Screen_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            cqOption c = new cqOption();
            c.Show();
            this.Hide();
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
                cotname_combo.Items.Add("MAKB, TRIEUCHUNGBENH, NGAYGIO");
                cotname_combo.Items.Add("MAKB, STT, TRIEUCHUNGBENH, NGAYGIO");
            }
            else if (tblname_combo.SelectedItem == "Hồ sơ bệnh nhân")
            {
                cotname_combo.Items.Add("MAKB, NGAY, MABS, TRIEUCHUNG, KETLUAN");
                cotname_combo.Items.Add("MAKB, STT, NGAY, MABS, TRIEUCHUNG, KETLUAN");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn khám bệnh")
            {
                cotname_combo.Items.Add("MAHDKB, MAKB, MANV, TONGTIEN");
            }
            else if (tblname_combo.SelectedItem == "Hồ sơ dịch vụ")
            {
                cotname_combo.Items.Add("MAHDDV, MADV, NGAYGIO, MANV");
                cotname_combo.Items.Add("MADV, NGAYGIO, MANV, KETLUAN");
                cotname_combo.Items.Add("MAHDDV, MADV, NGAYGIO, MANV, KETLUAN");
            }
            else if (tblname_combo.SelectedItem == "Dịch vụ")
            {
                cotname_combo.Items.Add("MADV, TENDV");
                cotname_combo.Items.Add("MADV, TENDV, DONGIA");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn dịch vụ")
            {
                cotname_combo.Items.Add("MAHDDV, MAKB, TONGTIEN, MANV, NGAYGIO");
            }
            else if (tblname_combo.SelectedItem == "Đơn thuốc")
            {
                cotname_combo.Items.Add("MADT, MAKB, MABS, DANDO, NGAYGIO");
            }
            else if (tblname_combo.SelectedItem == "Thuốc")
            {
                cotname_combo.Items.Add("MATHUOC, TENTHUOC, LOAITHUOC");
                cotname_combo.Items.Add("TENTHUOC, LOAITHUOC, DONVI, GIATIEN");
                cotname_combo.Items.Add("MATHUOC, TENTHUOC, LOAITHUOC, DONVI, GIATIEN, SOLUONGTON");
            }
            else if (tblname_combo.SelectedItem == "Chi tiết đơn thuốc")
            {
                cotname_combo.Items.Add("MADT, MATHUOC, SOLUONG, DONVI, DANDO");
            }
            else if (tblname_combo.SelectedItem == "Hóa đơn thuốc")
            {
                cotname_combo.Items.Add("MAHDT, NGAYGIO, MANV, TONGTIEN, MADT");
            }
            else if (tblname_combo.SelectedItem == "Bác sĩ")
            {
                cotname_combo.Items.Add("MABS, TENBS, MACK");
                cotname_combo.Items.Add("MABS, PHUCAP, LUONGCOBAN");
                cotname_combo.Items.Add("MABS, TENBS, MACK, PHUCAP, LUONGCOBAN");
            }
            else if (tblname_combo.SelectedItem == "Khoa")
            {
                cotname_combo.Items.Add("MAKHOA, TENKHOA");
            }
            else if (tblname_combo.SelectedItem == "Nhân viên")
            {
                cotname_combo.Items.Add("MANV, PHUCAP, LUONGCOBAN");
                cotname_combo.Items.Add("MANV, TENNV, MALOAI");
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
        private void cotname_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cotname_combo.SelectedItem == "MAKB, TEN, NAMSINH, DIACHI, SDT")
            {
                flag = 1;
            }
            else if (cotname_combo.SelectedItem == "MAKB, TRIEUCHUNGBENH, NGAYGIO")
            {
                flag = 4;
            }
            else if (cotname_combo.SelectedItem == "MAKB, STT, TRIEUCHUNGBENH, NGAYGIO")
            {
                flag = 6;
            }
            else if (cotname_combo.SelectedItem == "MAKB, NGAY, MABS, TRIEUCHUNG, KETLUAN")
            {
                flag = 7;
            }
            else if (cotname_combo.SelectedItem == "MAKB, STT, NGAY, MABS, TRIEUCHUNG, KETLUAN")
            {
                flag = 8;
            }
            else if (cotname_combo.SelectedItem == "MAHDKB, MAKB, MANV, TONGTIEN")
            {
                flag = 10;
            }
            else if (cotname_combo.SelectedItem == "MAHDDV, MADV, NGAYGIO, MANV")
            {
                flag = 12;
            }
            else if (cotname_combo.SelectedItem == "MADV, NGAYGIO, MANV, KETLUAN")
            {
                flag = 13;
            }
            else if (cotname_combo.SelectedItem == "MAHDDV, MADV, NGAYGIO, MANV, KETLUAN")
            {
                flag = 14;
            }
            else if (cotname_combo.SelectedItem == "MADV, TENDV")
            {
                flag = 16;
            }
            else if (cotname_combo.SelectedItem == "MADV, TENDV, DONGIA")
            {
                flag = 15;
            }
            else if (cotname_combo.SelectedItem == "MAHDDV, MAKB, TONGTIEN, MANV, NGAYGIO")
            {
                flag = 22;
            }
            else if (cotname_combo.SelectedItem == "MADT, MAKB, MABS, DANDO, NGAYGIO")
            {
                flag = 25;
            }
            else if (cotname_combo.SelectedItem == "MATHUOC, TENTHUOC, LOAITHUOC")
            {
                flag = 28;
            }
            else if (cotname_combo.SelectedItem == "TENTHUOC, LOAITHUOC, DONVI, GIATIEN")
            {
                flag = 29;
            }
            else if (cotname_combo.SelectedItem == "MATHUOC, TENTHUOC, LOAITHUOC, DONVI, GIATIEN, SOLUONGTON")
            {
                flag = 27;
            }
            else if (cotname_combo.SelectedItem == "MADT, MATHUOC, SOLUONG, DONVI, DANDO")
            {
                flag = 34;
            }
            else if (cotname_combo.SelectedItem == "MAHDT, NGAYGIO, MANV, TONGTIEN, MADT")
            {
                flag = 37;
            }
            else if (cotname_combo.SelectedItem == "MABS, TENBS, MACK")
            {
                flag = 40;
            }
            else if (cotname_combo.SelectedItem == "MABS, PHUCAP, LUONGCOBAN")
            {
                flag = 41;
            }
            else if (cotname_combo.SelectedItem == "MABS, TENBS, MACK, PHUCAP, LUONGCOBAN")
            {
                flag = 39;
            }
            else if (cotname_combo.SelectedItem == "MAKHOA, TENKHOA")
            {
                flag = 44;
            }
            else if (cotname_combo.SelectedItem == "MANV, PHUCAP, LUONGCOBAN")
            {
                flag = 49;
            }
            else if (cotname_combo.SelectedItem == "MANV, TENNV, MALOAI")
            {
                flag = 48;
            }
            else if (cotname_combo.SelectedItem == "MANV, TENNVM, MALOAI, PHUCAP, LUONGCOBAN")
            {
                flag = 47;
            }
            else if (cotname_combo.SelectedItem == "MABS, THOIGIAN, PHONGTRUC")
            {
                flag = 52;
            }
            else if (cotname_combo.SelectedItem == "MALOAI, TENLOAI")
            {
                flag = 56;
            }
            else if (cotname_combo.SelectedItem == "MANV, NGAYCONG")
            {
                flag = 62;
            }
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
                    using (OracleCommand cmd = new OracleCommand("admin1.grantQuyenObjectGO", con))
                    {
                       
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
                        cmd.Parameters.Add("check_num", OracleDbType.Int32).Value = 3;
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
                    using (OracleCommand cmd = new OracleCommand("admin1.grantQuyenObject", con))
                    {
                       
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username_text.Text;
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
}
