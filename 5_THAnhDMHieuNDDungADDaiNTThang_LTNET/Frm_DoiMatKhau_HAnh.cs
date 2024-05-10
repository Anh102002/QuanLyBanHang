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
    public partial class Frm_DoiMatKhau_HAnh : Form
    {
        private string matkhau;
        private string manv;
        

        public Frm_DoiMatKhau_HAnh(string manv,string matkhau)
        {
            InitializeComponent();
            this.matkhau = matkhau;
            this.manv = manv;
        }
        SqlConnection sqlcon;
        private void ketnoi()
        {
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            sqlcon = new SqlConnection(kn);
            sqlcon.Open();

        }

        private bool kiemtra(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            return false;
        }
        private void btn_Luu_HAnh_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_mk_HAnh.Text) && kiemtra(txt_mkMoi_HAnh.Text) && kiemtra(txt_mkNhapLai_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin  !!!", "Thông báo");
            }
            else if (kiemtra(txt_mk_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!!!", "Thông báo");
            }
            else if (kiemtra(txt_mkMoi_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới !!!", "Thông báo");
            }
            else if (kiemtra(txt_mkNhapLai_HAnh.Text))
            {
                MessageBox.Show("Bạn nhập lại mật khẩu mới !!!", "Thông báo");
            }
            else
            {
                if(txt_mk_HAnh.Text == matkhau)
                {
                    if (txt_mkMoi_HAnh.Text == txt_mkNhapLai_HAnh.Text)
                    {
                        ketnoi();
                        string sql = "update Nhanvien set MatKhau='" + txt_mkNhapLai_HAnh.Text + "' where MaNV='" + manv + "' ";
                        SqlCommand sqlda = new SqlCommand(sql, sqlcon);
                        int kq = sqlda.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Bạn đổi mật khẩu thành công", "Thông báo");
                            
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không trùng mật khẩu hãy nhập lại !!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu. Vui lòng nhập lại !!!", "Thông báo");
                }
                
            }
        }

        private void btn_huy_HAnh_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void chb_hienMk_HAnh_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_hienMk_HAnh.Checked)
            {
                txt_mkMoi_HAnh.PasswordChar = (char)0;
                txt_mkNhapLai_HAnh.PasswordChar = (char)0;
            }
            else
            {
                txt_mkMoi_HAnh.PasswordChar = '*';
                txt_mkNhapLai_HAnh.PasswordChar = '*';
            }
        }

        private void btn_nhaplai_HAnh_Click(object sender, EventArgs e)
        {
            txt_mk_HAnh.Clear();
            txt_mkMoi_HAnh.Clear();
            txt_mkNhapLai_HAnh.Clear();
        }

        private void Frm_DoiMatKhau_HAnh_Load(object sender, EventArgs e)
        {

        }
    }
}
