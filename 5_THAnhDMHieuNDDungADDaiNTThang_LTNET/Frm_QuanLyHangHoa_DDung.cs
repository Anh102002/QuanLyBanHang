using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    public partial class Frm_QuanLyHangHoa_DDung : Form
    {
        SqlConnection conn;
        public void ketnoi()
        {
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            conn = new SqlConnection(kn);
            conn.Open();
        }
        bool kiemtra(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            return false;
        }
      
        //bool IsNumeric(string input)
        //{
        //        return double.TryParse(input, out _);
        //}
        
        public Frm_QuanLyHangHoa_DDung()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadML()
        {
            
            string sql = "Select MaLoai from Loaihang";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i]["MaLoai"].ToString();
                cmb_maloai_DDung.Items.Add(ma);
            }
        }
        private void Fr_QuanLyHangHoa_DDung_Load(object sender, EventArgs e)
        {
            ketnoi();
            string sql = "Select * from HangHoa";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
            cmb_maloai_DDung.Items.Clear();
            loadML();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(kiemtra(txtMahang.Text)&& kiemtra(cmb_maloai_DDung.Text) && kiemtra(txtTenhang.Text) && kiemtra(txtDVT.Text) && kiemtra(txtDongia.Text) )
            {
                MessageBox.Show("Bạn chưa nhập thông tin  !!!", "Thông báo");
            }
            else if(kiemtra(txtMahang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng !!!", "Thông báo");
                txtMahang.Focus();
            }
            else if(kiemtra(cmb_maloai_DDung.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã loại !!!", "Thông báo");
                
            }
            else if(kiemtra(txtTenhang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng !!!", "Thông báo");
                txtTenhang.Focus();
            }
            else if (kiemtra(txtDVT.Text))
            {
                MessageBox.Show("Bạn chưa nhập DVT!!!", "Thông báo");
                txtDVT.Focus();
            }
            else if (kiemtra(txtDongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập Đơn giá!!!", "Thông báo");
                txtDongia.Focus();
            }
            else
            {

                try
                {
                    ketnoi();
                    string sql = "insert into HangHoa values(N'" + txtMahang.Text + "',N'" + cmb_maloai_DDung.Text + "',N'" + txtTenhang.Text + "'" +
                        ",N'" + txtDVT.Text + "',N'" + txtDongia.Text + "')";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    Fr_QuanLyHangHoa_DDung_Load(sender, e);
                }
                catch 
                {
                    MessageBox.Show("\t Lỗi chưa thêm được \n (bạn nhập trùng mã) hoặc (nhập mã loại không có trong cơ sở dữ liệu)", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmb_maloai_DDung.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTenhang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDVT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txtDongia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketnoi();
            string sql = "update HangHoa  set MaLoai=N'" + cmb_maloai_DDung.Text + "',TenHang=N'" + txtTenhang.Text + "',DVT=N'" + txtDVT.Text + "',DonGia=N'" + txtDongia.Text + "' where  MaHang=N'" +txtMahang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công ", "Thông báo");
                Fr_QuanLyHangHoa_DDung_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi !\n Sửa thất bại ", "Thông báo");
            }

        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
                MessageBox.Show("Hãy nhập đơn giá dạng số !!!", "Thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                ketnoi();
                string sql = "delete HangHoa where MaHang=N'" + txtMahang.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Fr_QuanLyHangHoa_DDung_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi! Xóa thất bại", "Thông báo");
                }
                

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            ketnoi();
            
            DataTable data = ((DataTable)dataGridView1.DataSource);
            DataView dataview = data.DefaultView;
            string doc = "";
            if (kiemtra(txtTim.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm  !!!", "Thông báo");
                return;
            }
            else
            {
                if (radioMahang.Checked == null && radioMaloai.Checked &&radioTenhang.Checked)
                {
                    MessageBox.Show("Bạn chưa chọn phương thức cần tìm !!!", "Thông báo");
                }
                else if (radioMahang.Checked)
                {
                    doc = string.Format("MaHang LIKE '%{0}%' OR MaHang LIKE '%{0}%' ",txtTim.Text);
                }
                else if (radioMaloai.Checked)
                {
                    doc = string.Format("MaHang LIKE '%{0}%' OR MaLoai LIKE '%{0}%' ", txtTim.Text);
                }else if(radioTenhang.Checked)
                {
                    doc = string.Format("MaHang LIKE '%{0}%' OR TenHang LIKE '%{0}%' ", txtTim.Text);
                }
            }
            dataview.RowFilter = doc;
            if(dataview.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTim.Focus();
            }



        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (!radioMahang.Checked && !radioMaloai.Checked && !radioTenhang.Checked)
            {
                txtTim.Text = string.Empty;
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm trước.");
            }
        }
    }
}
