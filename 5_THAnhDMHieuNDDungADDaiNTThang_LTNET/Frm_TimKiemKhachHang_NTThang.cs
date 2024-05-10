using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    public partial class Frm_TimKiemKhachHang_NTThang : Form
    {
        private string manv ;
        //string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
        string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
        public Frm_TimKiemKhachHang_NTThang()
        {
            InitializeComponent();
        }
        public Frm_TimKiemKhachHang_NTThang(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Frm_TimKiemKhachHang_NTThang_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT * FROM Khachhang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_ketquatimkiem_thang.DataSource = dataTable;
            }
        }

        private void bt_thoat_thang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_timkiem_thang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT * FROM Khachhang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                string timKiemText = tb_timkiem_thang.Text.ToLower();
                IEnumerable<DataRow> rows = dataTable.AsEnumerable();
                bool radioButtonSelected = false;

                if (rbt_makh_thang.Checked)
                {
                    rows = rows.Where(row => row.Field<string>("MaKH").ToLower().Contains(timKiemText));
                    radioButtonSelected = true;

                    if (rows.Count() == 0)
                    {
                        MessageBox.Show($"Không tìm thấy khách nào có Mã Khách hàng là '{timKiemText}'.");
                        return;
                    }
                }
                else if (rbt_loaikh_thang.Checked)
                {
                    rows = rows.Where(row => row.Field<string>("LoaiKH").ToLower().Contains(timKiemText));
                    radioButtonSelected = true;

                    if (rows.Count() == 0)
                    {
                        MessageBox.Show($"Không tìm thấy khách nào là loại khách hàng '{timKiemText}'.");
                        return;
                    }
                }
                else if (rbt_tenkh_thang.Checked)
                {
                    rows = rows.Where(row => row.Field<string>("TenKH").ToLower().Contains(timKiemText));
                    radioButtonSelected = true;

                    if (rows.Count() == 0)
                    {
                        MessageBox.Show($"Không tìm thấy khách nào có Tên Khách hàng là '{timKiemText}'.");
                        return;
                    }
                }
                else if (rbt_thanhpho_thang.Checked)
                {
                    rows = rows.Where(row => row.Field<string>("ThanhPho").ToLower().Contains(timKiemText));
                    radioButtonSelected = true;

                    if (rows.Count() == 0)
                    {
                        MessageBox.Show($"Không tìm thấy khách nào có Thành phố là '{timKiemText}'.");
                        return;
                    }
                }

                if (!radioButtonSelected)
                {
                    MessageBox.Show("Vui lòng chọn kiểu tìm kiếm.");
                    return;
                }

                DataTable resultTable = rows.CopyToDataTable();
                dgv_ketquatimkiem_thang.DataSource = resultTable;
            }
        }

        private void dgv_ketquatimkiem_thang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_makh_thang.Text = dgv_ketquatimkiem_thang.CurrentRow.Cells[0].Value.ToString();
        }

        private void bt_laphoadon_thang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_makh_thang.Text))
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT LoaiKH FROM Khachhang WHERE MaKH ='" + tb_makh_thang.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        DataTable dataTable = new DataTable();
                        object kq = cmd.ExecuteScalar();
                        string loaikhach = kq.ToString();
                        if (loaikhach.Equals("Đại lý", StringComparison.OrdinalIgnoreCase) || loaikhach.Equals("Thân thiết", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Khách hàng" + loaikhach + "", "Thông báo");
                            frm_GioHang_Hieu frm = new frm_GioHang_Hieu(manv, tb_makh_thang.Text);
                            frm.Show();
                        }
                        else if (loaikhach.Equals("Thường", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Khách hàng" + loaikhach + "", "Thông báo");
                            frm_LapHoaDon_Hieu frm = new frm_LapHoaDon_Hieu(manv, tb_makh_thang.Text);
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("không tìm thấy", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã Khách hàng có thể không hợp lệ", "Thông báo");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống mã khách hàng ", "Thông báo");
            }
        }
    }
}
