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
    public partial class Frm_thongkedoanhthu_HAnh : Form
    {
        public Frm_thongkedoanhthu_HAnh()
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
        private void Frm_thongkedoanhthu_HAnh_Load(object sender, EventArgs e)
        {
            dtp_ngay_Hanh.Text = DateTime.Today.ToString("yyyy/MM/dd");
            
            ketnoi();
            string sql = "select MaNV from Nhanvien where Quyen='User'";

            SqlDataAdapter sqlda = new SqlDataAdapter(sql,sqlcon);
            tb = new DataTable();
            sqlda.Fill(tb);
           
            foreach (DataRow item in tb.Rows)
            {
                cmb_nhanvien_HAnh.Items.Add(item[0]);
            }
            
        }

        private void btn_thongke_HAnh_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cmb_nhanvien_HAnh.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên. Vui lòng chọn nhân viên !!");
            }
            else
            {
                DateTime selectedDate = dtp_ngay_Hanh.Value;
                string sqlFormattedDate = selectedDate.ToString("yyyy-MM-dd");
                string sql = "SELECT Hoadon.SoHD, Hoadon.Ngayban, Hoadon.MaKH,Hoadon.MaNV," +
                "CTHoadon.Mahang,Hanghoa.Tenhang,CTHoadon.Soluong,CTHoadon.Dongia," +
                "Hanghoa.DVT,(CTHoadon.Soluong*CTHoadon.Dongia) as Thanhtien " +
                "FROM Hoadon  JOIN CTHoadon  ON Hoadon.SoHD = CTHoadon.SoHD JOIN Hanghoa  ON CTHoadon.Mahang = Hanghoa.Mahang " +
                "WHERE Hoadon.Ngayban = '" + sqlFormattedDate + "' and  Hoadon.MaNV = '" + cmb_nhanvien_HAnh.Text + "' ";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
                tb = new DataTable();
                sqlda.Fill(tb);
                dgv_thongke_HAnh.DataSource = tb;

                dgv_thongke_HAnh.Columns[0].HeaderText = "Số hóa đơn";
                dgv_thongke_HAnh.Columns[1].HeaderText = "Ngày bán";
                dgv_thongke_HAnh.Columns[2].HeaderText = "Mã khách hàng";
                dgv_thongke_HAnh.Columns[3].HeaderText = "Mã nhân viên";
                dgv_thongke_HAnh.Columns[4].HeaderText = "Mã hàng";
                dgv_thongke_HAnh.Columns[5].HeaderText = "Tên hàng";
                dgv_thongke_HAnh.Columns[6].HeaderText = "Số lượng";
                dgv_thongke_HAnh.Columns[7].HeaderText = "Đơn giá";
                dgv_thongke_HAnh.Columns[8].HeaderText = "Đơn vị tính";
                dgv_thongke_HAnh.Columns[9].HeaderText = "Thành tiền";

                double tong = 0;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    tong += (double)tb.Rows[i]["Thanhtien"];
                }
                txt_tongtien_HAnh.Text = tong.ToString();
            }
            
            
        }

        private void btn_thoat_HAnh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
