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
    public partial class Frm_QuenMatKhau_HAnh : Form
    {
        public Frm_QuenMatKhau_HAnh()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        DataTable tb;
        private void ketnoi()
        {
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            sqlcon = new SqlConnection(kn);
            sqlcon.Open();
        }
        private void btn_Cancel_Hanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LayMK_HAnh_Click(object sender, EventArgs e)
        {
            ketnoi();
            if(string.IsNullOrWhiteSpace(txt_UserQuenMK_HAnh.Text))
            {
                MessageBox.Show("Vui điền tên đăng nhập !!","Cảnh Báo");
            }
            else
            {
                string sql = "select MatKhau from Nhanvien where MaNV='"+txt_UserQuenMK_HAnh.Text+"' ";
                tb = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(sql,sqlcon);
                sqlda.Fill(tb);
                if(tb.Rows.Count > 0)
                {
                    string matkhau = tb.Rows[0]["MatKhau"].ToString();
                    txt_kq_HAnh.Text = matkhau;
                    
                }
                else
                {
                    txt_kq_HAnh.Text = "Tên đăng nhập sai. Vui lòng nhập lại !!";
                    txt_UserQuenMK_HAnh.Clear();
                    txt_UserQuenMK_HAnh.Focus();
                }

            }
        }

        private void Fr_QuenMatKhau_HAnh_Load(object sender, EventArgs e)
        {

        }
    }
}
