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
    public partial class Frm_HoaDonBanHang_HAnh : Form
    {
        private string makh;
        public Frm_HoaDonBanHang_HAnh(string makh)
        {
            InitializeComponent();
            this.makh=makh;
        }
        SqlConnection sqlcon;
        private void ketnoi()
        {
            //string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";

            sqlcon = new SqlConnection(kn);
            sqlcon.Open();

        }
     //   private DataTable GetSalesInvoiceData()
     //   {
     //       ketnoi();
     //       string sql = "SELECT CTHoadon.SoHD, Khachhang.TenKH, Nhanvien.TenNV, Hoadon.Ngayban, " +
     //"Hanghoa.TenHang, Hanghoa.DVT, CTHoadon.DonGia, CTHoadon.Soluong, (CTHoadon.DonGia * CTHoadon.Soluong) as Thanhtien " +
     //"FROM CTHoadon INNER JOIN " +
     //"Hanghoa ON CTHoadon.MaHang = Hanghoa.MaHang INNER JOIN " +
     //"Hoadon ON CTHoadon.SoHD = Hoadon.SoHD INNER JOIN " +
     //"Khachhang ON Hoadon.MaKH = Khachhang.MaKH INNER JOIN " +
     //"Nhanvien ON Hoadon.MaNV = Nhanvien.MaNV " +
     //"where CTHoadon.SoHD='HD01'";

     //       SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
     //       DataTable tb = new DataTable();
     //       sqlda.Fill(tb);
     //       return tb;
     //   }
     //private DataTable GetSalesInvoiceData()
     //   {
     //       ketnoi();
     //       string sql = "select * from Hanghoa";
     //       SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
     //       DataTable tb = new DataTable();
     //       sqlda.Fill(tb);
     //       return tb;
     //       // TODO: This line of code loads data into the 'QuanLyTapHoaDataSet.spHoadon' table. You can move, or remove it, as needed.

     //       rpv_hoadon_HAnh.LocalReport.ReportPath = "E:\\Test\\BTL\\5_THAnhDMHieuNDDungADDaiNTThang_LTNET\\5_THAnhDMHieuNDDungADDaiNTThang_LTNET\\Report_HD.rdlc";


     //       DataTable salesData = GetSalesInvoiceData();

     //       // Tạo một ReportDataSource và truyền dữ liệu vào
     //       //ReportDataSource reportDataSource = new ReportDataSource("tbhoadonban", salesData);
     //       // SalesInvoiceDataSet là tên DataSet trong report của bạn
     //       rpv_hoadon_HAnh.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", salesData));


     //       // Hiển thị report trong Report Viewer
     //       rpv_hoadon_HAnh.RefreshReport();
     //       this.Controls.Add(rpv_hoadon_HAnh);

     //       this.rpv_hoadon_HAnh.RefreshReport();
     //   }

        private void Frm_HoaDonBanHang_HAnh_Load(object sender, EventArgs e)
        {

            try
            {
                this.spHoadonTableAdapter.Fill(this.QuanLyTapHoaDataSet.spHoadon, makh);
            }
            catch
            {

            }                
                       
            this.rpv_hoadon_HAnh.RefreshReport();
            
        }

        private void btn_thoat_HAnh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rpv_hoadon_HAnh_Load(object sender, EventArgs e)
        {

        }
    }
}
