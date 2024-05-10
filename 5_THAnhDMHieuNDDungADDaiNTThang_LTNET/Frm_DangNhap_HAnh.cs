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
    public partial class Frm_DangNhap_HAnh : Form
    {
        public Frm_DangNhap_HAnh()
        {
            InitializeComponent();
        }
        
        
        bool kiemtra(String s)
        {
            if(String.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_user_HAnh.Focus();

        }

        SqlConnection sqlcon;
        private void ketnoi()
        {
            //string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";

            sqlcon = new SqlConnection(kn);
            sqlcon.Open();

        }
        private void btn_login_HAnh_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_user_HAnh.Text) && kiemtra(txt_Pass_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập !!!", "Thông báo");
            }
            else if (kiemtra(txt_user_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập !!!", "Thông báo");
            } else if (kiemtra(txt_Pass_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !!!", "Thông báo");
            }
            else
            {

                ketnoi();
                string sql = "SELECT * FROM Nhanvien WHERE MaNV = '"+txt_user_HAnh.Text+"'  AND MatKhau = '"+txt_Pass_HAnh.Text+"' ";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql,sqlcon);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                if(tb.Rows.Count > 0)
                {                    
                    string tennv = tb.Rows[0]["TenNV"].ToString();
                    string quyen = tb.Rows[0]["Quyen"].ToString();
                    string manv = tb.Rows[0]["MaNV"].ToString();
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK);                       
                    this.Hide();
                    Frm_Menu_HAnh fr = new Frm_Menu_HAnh(manv,tennv,quyen);
                    fr.Show();
                        
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai .Vui lòng nhập lại !!", "Cảnh báo", MessageBoxButtons.OK);
                    txt_Pass_HAnh.Clear();
                    txt_user_HAnh.Clear();
                    txt_user_HAnh.Focus();
                }

            }
        }

        private void btn_Exit_Hanh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLb_QuenMk_HAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_QuenMatKhau_HAnh fr = new Frm_QuenMatKhau_HAnh();
            fr.Show();
            
        }

        private void chb_HienMatKhau_HAnh_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_HienMatKhau_HAnh.Checked)
            {
                txt_Pass_HAnh.PasswordChar = (char)0;
            }
            else
            {
                txt_Pass_HAnh.PasswordChar = '*';
            }
        }
    }
}
