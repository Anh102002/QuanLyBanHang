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
    public partial class Frm_QuanLyKhachHang_NTThang : Form

    {
        private string manv;
        string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
        public Frm_QuanLyKhachHang_NTThang()
        {
            InitializeComponent();
        }
        public Frm_QuanLyKhachHang_NTThang(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Frm_QuanLyKhachHang_NTThang_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT * FROM Khachhang"; 
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_dskh_thang.DataSource = dataTable;
            }
        }

        private void dgv_dskh_thang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_dskh_thang.Rows[e.RowIndex];
            string maKH = selectedRow.Cells["MaKH"].Value.ToString();
            string tenKH = selectedRow.Cells["TenKH"].Value.ToString();
            string Diachi = selectedRow.Cells["Diachi"].Value.ToString();
            string Quan = selectedRow.Cells["Quan"].Value.ToString();
            string ThanhPho = selectedRow.Cells["ThanhPho"].Value.ToString();
            string LoaiKH = selectedRow.Cells["LoaiKH"].Value.ToString();
            tb_makh_thang.Text = maKH;
            tb_hoten_thang.Text = tenKH;
            tb_diachi_thang.Text = Diachi;
            tb_quan_thang.Text = Quan;
            tb_thanhpho_thang.Text = ThanhPho;
            cb_loaikh_thang.Text = LoaiKH;
        }

        private void bt_thoat_thang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_them_thang_Click(object sender, EventArgs e)
        {
            string maKH = tb_makh_thang.Text;
            string tenKH = tb_hoten_thang.Text;
            string diachi = tb_diachi_thang.Text;
            string quan = tb_quan_thang.Text;
            string thanhPho = tb_thanhpho_thang.Text;
            string loaiKH = cb_loaikh_thang.Text;

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(quan) || string.IsNullOrEmpty(thanhPho) || string.IsNullOrEmpty(loaiKH))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin khách hàng.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM Khachhang WHERE MaKH = @MaKH";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@MaKH", maKH);
                    int existingCount = (int)checkCmd.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Mã Khách hàng đã tồn tại. Vui lòng chọn Mã Khách hàng khác.");
                        return; 
                    }
                }
                string insertQuery = "INSERT INTO Khachhang (MaKH, TenKH, LoaiKH, Diachi, Quan, ThanhPho) VALUES (@MaKH, @TenKH, @LoaiKH, @Diachi, @Quan, @ThanhPho)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@LoaiKH", loaiKH);
                    cmd.Parameters.AddWithValue("@Diachi", diachi);
                    cmd.Parameters.AddWithValue("@Quan", quan);
                    cmd.Parameters.AddWithValue("@ThanhPho", thanhPho);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu.");
                    }
                    Frm_QuanLyKhachHang_NTThang_Load(sender, e);
                }
            }
        }

        private void bt_sua_thang_Click(object sender, EventArgs e)
        {
            string maKH = tb_makh_thang.Text;
            string tenKH = tb_hoten_thang.Text;
            string diachi = tb_diachi_thang.Text;
            string quan = tb_quan_thang.Text;
            string thanhPho = tb_thanhpho_thang.Text;
            string loaiKH = cb_loaikh_thang.Text;

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "UPDATE Khachhang SET TenKH = @TenKH, LoaiKH = @LoaiKH, Diachi = @Diachi, Quan = @Quan, ThanhPho = @ThanhPho WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@LoaiKH", loaiKH);
                    cmd.Parameters.AddWithValue("@Diachi", diachi);
                    cmd.Parameters.AddWithValue("@Quan", quan);
                    cmd.Parameters.AddWithValue("@ThanhPho", thanhPho);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được cập nhật thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật dữ liệu.");
                    }
                    Frm_QuanLyKhachHang_NTThang_Load(sender, e);
                }
            }
        }

        private void bt_xoa_thang_Click(object sender, EventArgs e)
        {
            string maKH = tb_makh_thang.Text;

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "DELETE FROM Khachhang WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    
                    try
                    {
                        // Thực thi truy vấn DELETE
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa dữ liệu.");
                        }
                        Frm_QuanLyKhachHang_NTThang_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Có ràng buộc không thể xóa !!");
                    }
                   
                }
            }
        }

        private void bt_timkiem_thang_Click(object sender, EventArgs e)
        {
            Frm_TimKiemKhachHang_NTThang fr = new Frm_TimKiemKhachHang_NTThang(manv);
            fr.Show();
        }
    }
}
