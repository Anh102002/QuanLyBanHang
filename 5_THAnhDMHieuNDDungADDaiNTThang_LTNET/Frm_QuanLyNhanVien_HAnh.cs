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
    public partial class Frm_QuanLyNhanVien_HAnh : Form
    {
        public Frm_QuanLyNhanVien_HAnh()
        {
            InitializeComponent();
        }
        bool kiemtra(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            return false;
        }
        SqlConnection sqlcon;
        DataTable tb;
        private void ketnoi()
        {
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            sqlcon = new SqlConnection(kn);
            sqlcon.Open();

        }
        private void Fr_QuanLyNhanVien_HAnh_Load(object sender, EventArgs e)
        {
            ketnoi();
            String sql = "select *from Nhanvien";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            tb = new DataTable();
            sqlda.Fill(tb);
            dgv_nv_HAnh.DataSource = tb;


            dgv_nv_HAnh.Columns[0].HeaderText = "Mã nhân viên";
            dgv_nv_HAnh.Columns[1].HeaderText = "Tên nhân viên";
            dgv_nv_HAnh.Columns[2].HeaderText = "Địa chỉ";
            dgv_nv_HAnh.Columns[3].HeaderText = "Mật khẩu";
            dgv_nv_HAnh.Columns[4].HeaderText = "Quyền";

            dgv_nv_HAnh.Columns[0].Width = 150;
            dgv_nv_HAnh.Columns[1].Width = 150;
            dgv_nv_HAnh.Columns[2].Width = 150;
            dgv_nv_HAnh.Columns[3].Width = 150;
            dgv_nv_HAnh.Columns[4].Width = 150;
        }

        private void btn_thoat_HAnh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_nv_HAnh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv_HAnh.Text = dgv_nv_HAnh.CurrentRow.Cells[0].Value.ToString();
            txt_tennv_HAnh.Text = dgv_nv_HAnh.CurrentRow.Cells[1].Value.ToString();
            txt_diachi_HAnh.Text = dgv_nv_HAnh.CurrentRow.Cells[2].Value.ToString();
            txt_matkhau_HAnh.Text = dgv_nv_HAnh.CurrentRow.Cells[3].Value.ToString();
            txt_quyen_HAnh.Text = dgv_nv_HAnh.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_them_HAnh_Click(object sender, EventArgs e)
        {
            if(kiemtra(txt_manv_HAnh.Text)|| kiemtra(txt_tennv_HAnh.Text) || kiemtra(txt_diachi_HAnh.Text) ||
                kiemtra(txt_matkhau_HAnh.Text) || kiemtra(txt_quyen_HAnh.Text) )
            {
                MessageBox.Show("Bạn đang để trống thông tin. Vui lòng nhập đầy đủ thông tin !","Cảnh báo");
            }
            else
            {
                try
                {
                    ketnoi();
                    string sql = "INSERT INTO Nhanvien VALUES ('" + txt_manv_HAnh.Text + "' ,N'" + txt_tennv_HAnh.Text + "',N'" + 
                        txt_diachi_HAnh.Text + "','" + txt_matkhau_HAnh.Text + "','"+txt_quyen_HAnh.Text+"')";
                    SqlCommand sqlcom = new SqlCommand();
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = sql;
                    sqlcom.Connection = sqlcon;

                    int kq = sqlcom.ExecuteNonQuery();
                    if(kq > 0)
                    {
                        MessageBox.Show("Thêm thông tin thành công ", "Thông báo");
                        Fr_QuanLyNhanVien_HAnh_Load(sender, e);
                    }


                }
                catch 
                {
                    MessageBox.Show("Mã nhân viên bị trùng  !!!", "Cảnh báo");
                }
                
            }
        }

        private void btn_sua_HAnh_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_manv_HAnh.Text) || kiemtra(txt_tennv_HAnh.Text) || kiemtra(txt_diachi_HAnh.Text) ||
                kiemtra(txt_matkhau_HAnh.Text) || kiemtra(txt_quyen_HAnh.Text))
            {
                MessageBox.Show("Bạn đang để trống thông tin. Vui lòng nhập đầy đủ thông tin !", "Cảnh báo");
            }
            else
            {
                try
                {
                    ketnoi();
                    String sql = "update Nhanvien set TenNV=N'" + txt_tennv_HAnh.Text + "' ,Diachi=N'" + txt_diachi_HAnh.Text + "',MatKhau='"+txt_matkhau_HAnh.Text+"',Quyen='"+txt_quyen_HAnh.Text+"' where  MaNV='" + txt_manv_HAnh.Text + "' ";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                    int kq = sqlcom.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo");
                        Fr_QuanLyNhanVien_HAnh_Load(sender, e);
                    }


                }
                catch
                {
                    MessageBox.Show("Lỗi không sửa được vui lòng kiểm tra lại  !!!", "Cảnh báo");
                }
            }
        }

        private void btn_xoa_HAnh_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_manv_HAnh.Text) || kiemtra(txt_tennv_HAnh.Text) || kiemtra(txt_diachi_HAnh.Text) ||
                kiemtra(txt_matkhau_HAnh.Text) || kiemtra(txt_quyen_HAnh.Text))
            {
                MessageBox.Show("Bạn đang để trống thông tin. Vui lòng nhập đầy đủ thông tin !", "Cảnh báo");
            }
            else
            {
                try
                {
                    ketnoi();
                    string sql = "delete from Nhanvien Where MaNV='"+txt_manv_HAnh.Text+"' ";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                    int kq = sqlcom.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo");
                        Fr_QuanLyNhanVien_HAnh_Load(sender, e);
                    }


                }
                catch
                {
                    MessageBox.Show("Lỗi không xóa được vui lòng kiểm tra lại  !!!", "Cảnh báo");
                }
            }
        }
        private void search(string sql)
        {
            ketnoi();
            
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            tb = new DataTable();
            sqlda.Fill(tb);
            dgv_nv_HAnh.DataSource = tb;

            if(tb.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin bạn cần tìm  !!!", "Thông báo");
                txt_timkiem_HAnh.Clear();
                txt_timkiem_HAnh.Focus();

            }

            dgv_nv_HAnh.Columns[0].HeaderText = "Mã nhân viên";
            dgv_nv_HAnh.Columns[1].HeaderText = "Tên nhân viên";
            dgv_nv_HAnh.Columns[2].HeaderText = "Địa chỉ";
            dgv_nv_HAnh.Columns[3].HeaderText = "Mật khẩu";
            dgv_nv_HAnh.Columns[4].HeaderText = "Quyền";

            dgv_nv_HAnh.Columns[0].Width = 150;
            dgv_nv_HAnh.Columns[1].Width = 150;
            dgv_nv_HAnh.Columns[2].Width = 150;
            dgv_nv_HAnh.Columns[3].Width = 150;
            dgv_nv_HAnh.Columns[4].Width = 150;
        }
        private void btn_timkiem_HAnh_Click(object sender, EventArgs e)
        {
            if(cmb_khoatk_HAnh.SelectedIndex==0)
            {
               
                string sql = "select *from Nhanvien where MaNV like '%"+txt_timkiem_HAnh.Text+"%' ";
                search(sql);
            }
            else
            {
              
                string sql = "select *from Nhanvien where TenNV like N'%" + txt_timkiem_HAnh.Text + "%' ";
                search(sql);
            }
        }

        private void cmb_khoatk_HAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_timkiem_HAnh.Clear();
        }
    }
}
