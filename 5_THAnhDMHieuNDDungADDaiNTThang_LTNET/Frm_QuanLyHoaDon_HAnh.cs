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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    public partial class Frm_QuanLyHoaDon_HAnh : Form
    {
        private string tennv;
        public Frm_QuanLyHoaDon_HAnh(string tennv)
        {
            InitializeComponent();
            this.tennv = tennv;
        }

        private void btn_thoat_HAnh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection conn;
        DataTable tb;
        public void ketnoi()
        {
            string kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            conn = new SqlConnection(kn);
            conn.Open();
        }
        private bool ktra(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            return false;
        }
        private void LoadMa()
        {
            string sql = "select MaHang from Hanghoa";
            DataTable tb = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(tb);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmb_MaHang_HAnh.Items.Add(tb.Rows[i]["MaHang"].ToString());
            }
            ////
            //string sqlkh = "select MaKH from Khachhang";
            //DataTable tb_kh = new DataTable();
            //SqlDataAdapter sqlda_kh = new SqlDataAdapter(sqlkh, conn);
            //sqlda_kh.Fill(tb_kh);
            //for (int i = 0; i < tb_kh.Rows.Count; i++)
            //{
            //    cmb_MaKH_HAnh.Items.Add(tb_kh.Rows[i]["MaKH"].ToString());
            //}
        }
        private void Frm_QuanLyHoaDon_HAnh_Load(object sender, EventArgs e)
        {
            ketnoi();
            string sql = "select CTHoadon.SoHD,CTHoadon.MaHang,Hanghoa.TenHang,CTHoadon.DonGia,CTHoadon.Soluong,Hoadon.MaKH,(CTHoadon.DonGia*CTHoadon.Soluong) as Thanhtien from CTHoadon,Hanghoa,Hoadon" +
                " where CTHoadon.MaHang = Hanghoa.MaHang and CTHoadon.SoHD = Hoadon.SoHD ";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            tb = new DataTable();
            sqlda.Fill(tb);
            dgv_hoadon_HAnh.DataSource = tb;
            LoadMa();
            dgv_hoadon_HAnh.Columns[0].HeaderText = "Số Hóa Đơn";
            dgv_hoadon_HAnh.Columns[1].HeaderText = "Mã Hàng";
            dgv_hoadon_HAnh.Columns[2].HeaderText = "Tên hàng";
            dgv_hoadon_HAnh.Columns[3].HeaderText = "Đơn giá";
            dgv_hoadon_HAnh.Columns[4].HeaderText = "Số lượng";
            dgv_hoadon_HAnh.Columns[5].HeaderText = "Mã Khách Hàng";
            dgv_hoadon_HAnh.Columns[6].HeaderText = "Thành Tiền";

            dgv_hoadon_HAnh.Columns[0].Width = 100;
            dgv_hoadon_HAnh.Columns[1].Width = 100;
            dgv_hoadon_HAnh.Columns[2].Width = 150;
            dgv_hoadon_HAnh.Columns[3].Width = 100;
            dgv_hoadon_HAnh.Columns[4].Width = 100;
            dgv_hoadon_HAnh.Columns[5].Width = 100;
            dgv_hoadon_HAnh.Columns[6].Width = 100;
         

            double tong = 0;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tong +=(double) tb.Rows[i]["Thanhtien"];
            }
            txt_tongtien_HAnh.Text = tong.ToString();
        }

        private void btn_sua_HAnh_Click(object sender, EventArgs e)
        {
            //if (ktra(txt_SoHD_HAnh.Text) || ktra(cmb_MaHang_HAnh.Text)|| ktra(txt_Tenhang_HAnh.Text) 
            //    || ktra(txt_Dongia_HAnh.Text) || ktra(txt_soluong_HAnh.Text) )
            //{
            //    MessageBox.Show("Bạn đang để trống thông tin !!!");
            //}
            //else
            //{
            //    int n;
            //    if (int.TryParse(txt_soluong_HAnh.Text, out n))
            //    {
            //        try
            //        {
            //            string sql = "update  CTHoadon set  MaHang='" + cmb_MaHang_HAnh.Text + "',Soluong='" + txt_soluong_HAnh.Text + "'  where SoHD='" + txt_SoHD_HAnh.Text + "' ";
            //            SqlCommand cmd = new SqlCommand(sql, conn);
            //            int kq = cmd.ExecuteNonQuery();
            //            if (kq > 0)
            //            {
                           
            //               MessageBox.Show("Sửa thành công ", "Thông báo");
            //               Frm_QuanLyHoaDon_HAnh_Load(sender, e);                   
            //            }

            //        }
            //        catch(Exception ex)
            //        {
            //            MessageBox.Show("Lỗi không sửa được : "+ex.Message);
            //        }
            //    }

            //    else
            //    {
            //        MessageBox.Show("Lỗi nhập số lượng  !!!");
            //    }
            //}
        }

        private void dgv_hoadon_HAnh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SoHD_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[0].Value.ToString();
            cmb_MaHang_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[1].Value.ToString();
            txt_Tenhang_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[2].Value.ToString();
            txt_Dongia_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[3].Value.ToString();
            txt_soluong_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[4].Value.ToString();
            txt_MaKH_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[5].Value.ToString();
            txt_Thanhtien_HAnh.Text = dgv_hoadon_HAnh.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_xoa_HAnh_Click(object sender, EventArgs e)
        {
            if (ktra(txt_SoHD_HAnh.Text) || ktra(cmb_MaHang_HAnh.Text) || ktra(txt_Tenhang_HAnh.Text)
                || ktra(txt_Dongia_HAnh.Text) || ktra(txt_soluong_HAnh.Text))
            {
                MessageBox.Show("Bạn đang để trống thông tin !!!");
            }
            else
            {
                int n;
                if (int.TryParse(txt_soluong_HAnh.Text, out n))
                {
                    try
                    {
                        string sql = "delete from CTHoadon  where SoHD='" + txt_SoHD_HAnh.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {

                            string sql1 = "delete from Hoadon  where SoHD='" + txt_SoHD_HAnh.Text + "' ";
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            int kq1 = cmd1.ExecuteNonQuery();
                            if (kq1 > 0)
                            {

                                MessageBox.Show("Xóa thành công ", "Thông báo");
                                Frm_QuanLyHoaDon_HAnh_Load(sender, e);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không xóa được : " + ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Lỗi nhập số lượng  !!!");
                }
            }
        }
        private void export ()
        {
            //using System.IO;
            //using OfficeOpenXml;
            //using Excel = Microsoft.Office.Interop.Excel;
            // các thư viện cần dùng

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //application.Application.Workbooks.Add(Type.Missing); 
            Excel.Worksheet worksheet =(Excel.Worksheet) workbook.Worksheets[1];


            worksheet.Range["A7"].Font.Size = 12;
            worksheet.Range["A7"].Font.Bold = true;
            worksheet.Range["A7"].Value = "SIÊU THỊ HÀ NỘI";


            worksheet.Range["C9"].Value = "BÁO CÁO BÁN HÀNG";
            worksheet.Range["C9"].Font.Size = 14;
            worksheet.Range["C9"].Font.Bold = true;


            worksheet.Range["A10:G10"].Font.Size = 12;
            worksheet.Range["A10:G10"].Font.Bold = true;
            worksheet.Range["A10"].Value = "Số HĐ";
            worksheet.Range["B10"].Value = "Mã hàng";
            worksheet.Range["C10"].Value = "Tên hàng";
            worksheet.Range["D10"].Value = "Đơn Giá";
            worksheet.Range["E10"].Value = "Số lượng";
            worksheet.Range["F10"].Value = "Thành tiền";
            int dong = 11;
            for (int i = 0; i < dgv_hoadon_HAnh.Rows.Count-1; i++)
            {
                worksheet.Range["A" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[0].Value.ToString();
                worksheet.Range["B" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[1].Value.ToString();
                worksheet.Range["C" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[2].Value.ToString();
                worksheet.Range["D" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[3].Value.ToString() + " Vnd";
                worksheet.Range["E" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[4].Value.ToString();
                worksheet.Range["F" + (dong + i).ToString()].Value = dgv_hoadon_HAnh.Rows[i].Cells[6].Value.ToString() + " Vnd";
            }



            dong = dong + dgv_hoadon_HAnh.Rows.Count;
            worksheet.Range["A" + dong.ToString() + ":G" + dong.ToString()].Font.Size = 13;
            worksheet.Range["A" + dong.ToString() + ":G" + dong.ToString()].Font.Bold = true;
            worksheet.Range["A" + dong.ToString() + ":C" + dong.ToString()].MergeCells = true;
            worksheet.Range["A" + dong.ToString() + ":C" + dong.ToString()].Value = "Tổng Tiền ";
            worksheet.Range["F" + dong.ToString()].Value = txt_tongtien_HAnh.Text + " Vnd";

            worksheet.Range["F" + (dong + 1).ToString()].Font.Size = 13;
            worksheet.Range["F" + (dong + 1).ToString()].Font.Bold = true;           
            worksheet.Range["F" + (dong + 1).ToString()].Value = "Người lập báo cáo";            
            worksheet.Range["F" + (dong + 2).ToString()].Value = tennv;

            worksheet.Name = "Báo cáo bán hàng";
            application.Columns.AutoFit();
            workbook.Activate();

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx|All Files|*.*";
            if (saveFile.ShowDialog()==DialogResult.OK)
            {               
                workbook.SaveAs(saveFile.FileName.ToLower());
                MessageBox.Show("Xuất báo cáo thành công");
            }
            application.Quit();

        }
        private void btn_export_banhang_HAnh_Click(object sender, EventArgs e)
        {
            export();
        }
    }
}
