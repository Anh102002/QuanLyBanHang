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

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    public partial class Frm_QuanLyLoaiHang_ADD : Form
    {
        
        public Frm_QuanLyLoaiHang_ADD()
        {
            InitializeComponent();
        }

    private string kn()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
        }


        private void LoadData()
        {
            string connectionString = kn();
            string query = "SELECT MaLoai, TenLoai FROM Loaihang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                data_loaihang.DataSource = dataTable;
            }
            data_loaihang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Fr_QuanLyLoaiHang_ADD_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Mã Loại và Tên Loại không được để trống.");
                return;
            }

            string connectionString = kn();

            // Kiểm tra xem Tên Loại đã tồn tại chưa
            string checkTenLoaiQuery = "SELECT MaLoai FROM Loaihang WHERE TenLoai = @TenLoai";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(checkTenLoaiQuery, connection))
                {
                    command.Parameters.AddWithValue("@TenLoai", txtTen.Text);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string maLoai = reader.GetString(0);
                            MessageBox.Show($"Loại hàng này đã có. Mã Loại tương ứng là {maLoai}.");
                            return;
                        }
                    }
                    connection.Close();
                }
            }

            // Thêm dữ liệu mới
            string insertQuery = "INSERT INTO Loaihang (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaLoai", txtMa.Text);
                    command.Parameters.AddWithValue("@TenLoai", txtTen.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Gọi phương thức LoadData để cập nhật DataGridView
            LoadData();
            MessageBox.Show("Thêm thành công!");
        }
        private void data_loaihang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng có nhấp vào một dòng hợp lệ không
            {
                DataGridViewRow row = data_loaihang.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MaLoai"].Value.ToString();
                txtTen.Text = row.Cells["TenLoai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các textbox có trống không
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Mã Loại và Tên Loại không được để trống.");
                return;
            }

            string connectionString = kn();

            // Kiểm tra xem Tên Loại đã tồn tại chưa
            string checkTenLoaiQuery = "SELECT MaLoai FROM Loaihang WHERE TenLoai = @TenLoai AND MaLoai != @MaLoai";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(checkTenLoaiQuery, connection))
                {
                    command.Parameters.AddWithValue("@TenLoai", txtTen.Text);
                    command.Parameters.AddWithValue("@MaLoai", txtMa.Text);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string maLoai = reader.GetString(0);
                            MessageBox.Show($"Tên Loại đã tồn tại. Mã Loại tương ứng là {maLoai}.");
                            return;
                        }
                    }
                    connection.Close();
                }
            }

            // Cập nhật dữ liệu
            string updateQuery = "UPDATE Loaihang SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaLoai", txtMa.Text);
                    command.Parameters.AddWithValue("@TenLoai", txtTen.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Gọi phương thức LoadData để cập nhật DataGridView
            LoadData();

            // Thông báo cập nhật thành công
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textbox Mã Loại có trống không
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Mã Loại không được để trống.");
                return;
            }

            string connectionString = kn();

            // Xóa dữ liệu
            string deleteQuery = "DELETE FROM Loaihang WHERE MaLoai = @MaLoai";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaLoai", txtMa.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Gọi phương thức LoadData để cập nhật DataGridView
            LoadData();

            // Thông báo xóa thành công
            MessageBox.Show("Xóa thành công!");
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textbox Tìm kiếm có trống không
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                return;
            }

            string connectionString = kn();
            string searchQuery;

            // Kiểm tra RadioButton nào được chọn và thiết lập câu truy vấn tìm kiếm tương ứng
            if (radioButtonMa.Checked)
            {
                searchQuery = "SELECT * FROM Loaihang WHERE MaLoai LIKE @TenLoai";
            }
            else if (radioButtonTen.Checked)
            {
                searchQuery = "SELECT * FROM Loaihang WHERE TenLoai = @MaLoai";
            }
            else 
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, connection);
                if (radioButtonMa.Checked)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@TenLoai", "%" + txtTim.Text + "%");
                }
                else
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@MaLoai", txtTim.Text);
                }
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Hiển thị kết quả tìm kiếm trên DataGridView
                data_loaihang.DataSource = dataTable;
            }

            data_loaihang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (!radioButtonMa.Checked && !radioButtonTen.Checked)
            {
                txtTim.Text = string.Empty;
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm trước.");
            }
        }
    }
}
