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
    public partial class Frm_Menu_HAnh : Form
    {
        private string quyen;
        private string tennv;
        private string manv;
        public Frm_Menu_HAnh(string manv,string tennv,string quyen)
        {
            InitializeComponent();
            this.manv = manv;
            this.quyen = quyen;
            this.tennv = tennv;
        }

        

        private void Frm_Menu_HAnh_Load(object sender, EventArgs e)
        {
            lb_tentk_HAnh.Text ="Tài Khoản :"+ tennv;
            string name = "User";
            if(quyen == name)
            {
                menuitem_doanhthu.Visible = false;
                menuitem_nhanvien.Visible = false;
                quảnLýHóaĐơnBánHàngToolStripMenuItem.Visible = false;

            }
                
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap_HAnh fr = new Frm_DangNhap_HAnh();
            fr.ShowDialog();
        }
        SqlConnection sqlcon;
        private void ketnoi()
        {
            //string kn = @"Data Source=DESKTOP-F2KOJ6C\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            sqlcon = new SqlConnection(kn);
            sqlcon.Open();

        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ketnoi();
            string sql = "SELECT * FROM Nhanvien WHERE MaNV = '" +manv + "' ";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataTable tb = new DataTable();
            sqlda.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                string matkhau = tb.Rows[0]["MatKhau"].ToString();                               
                                               
                Frm_DoiMatKhau_HAnh fr = new Frm_DoiMatKhau_HAnh(manv,matkhau);
                fr.Show();
            }
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyKhachHang_NTThang fr = new Frm_QuanLyKhachHang_NTThang(manv);
            fr.Show();
        }

        private void menuitem_doanhthu_Click(object sender, EventArgs e)
        {
            Frm_thongkedoanhthu_HAnh fr = new Frm_thongkedoanhthu_HAnh();
            fr.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TimKiemKhachHang_NTThang fr = new Frm_TimKiemKhachHang_NTThang(manv);
            fr.Show();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyHangHoa_DDung fr = new Frm_QuanLyHangHoa_DDung();
            fr.Show();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyLoaiHang_ADD fr = new Frm_QuanLyLoaiHang_ADD();
            fr.Show();
        }

        private void menuitem_nhanvien_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNhanVien_HAnh fr = new Frm_QuanLyNhanVien_HAnh();
            fr.Show();
        }

        private void quảnLýHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyHoaDon_HAnh fr = new Frm_QuanLyHoaDon_HAnh(tennv);
            fr.Show();
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lậpHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LapHoaDon_Hieu frm = new frm_LapHoaDon_Hieu(manv);
            frm.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_about_HAnh fr = new Frm_about_HAnh();
            fr.Show();
        }
    }
}
