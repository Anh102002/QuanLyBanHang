using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    public partial class frm_LapHoaDon_Hieu : Form
    {
        private string manv, makh;
        private bool ktra;
        public frm_LapHoaDon_Hieu()
        {
            InitializeComponent();
        }
        public frm_LapHoaDon_Hieu(string manv, string makh)
        {
            InitializeComponent();
            this.manv = manv;
            this.makh = makh;
            tb_makh_hieu.Text = this.makh;
            tb_makh_hieu.ReadOnly = true;
            tb_hoten_hieu.ReadOnly = true;
            tb_diachi_hieu.ReadOnly = true;
            cb_loaikh_hieu.Enabled = false;
            tb_quan_hieu.ReadOnly = true;
            tb_thanhpho_hieu.ReadOnly = true;
            ktra = false;
            
        }
        public frm_LapHoaDon_Hieu(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            ktra = true;
        }
        ArrayList Ds_HH = new ArrayList();
        SqlConnection sqlcon;
        DataSet ds;
        private void ketnoi()
        {
            String kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
            sqlcon = new SqlConnection(kn);
            sqlcon.Open();
        }
        private void UpdateGioHang()
        {
            dgv_danhsachhangmua_hieu.Rows.Clear();
            foreach (GioHang item in Ds_HH)
            {
                dgv_danhsachhangmua_hieu.Rows.Add(item.Mahang, item.Tenhang, item.Soluong, item.Dvt, item.Dongia, item.Thanhtien);
            }
        }
        private void frm_LapHoaDon_Hieu_Load(object sender, EventArgs e)
        {
            try
            {

                tb_manv_hieu.Text = this.manv;
                float tongtien = 0;
                foreach (GioHang item in Ds_HH)
                {
                    tongtien = tongtien + item.Thanhtien;
                }
                tb_tongtien_hieu.Text = tongtien.ToString();
                float tienthua = 0;
                float khachtra = float.Parse(tb_tienkhachdua_hieu.Text);
                tienthua = khachtra - tongtien;
                tb_tralai_hieu.Text = tienthua.ToString();
            }
            catch 
            {
                MessageBox.Show("Dữ liệu nhập sai !!!", "Thông báo");
            }
        }

        private void b_themvaodanhsach_hieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_mahang_hieu.Text))
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng !!!", "Thông báo");
            }
            else
            {
                ketnoi();
                String sql = "select *from Hanghoa WHERE MaHang='" + tb_mahang_hieu.Text + "'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string mahang = dt.Rows[0]["MaHang"].ToString();
                    string tenhang = "";
                    int soluong = 0;
                    string dvt = "";
                    float dongia = 0;
                    float thanhtien = 0;
                    bool ktragh = false;
                    int soluongtemp = 0;
                    if (Ds_HH.Count > 0)
                    {
                        foreach (GioHang item in Ds_HH)
                        {
                            if (item.Mahang.Equals(mahang))
                            {
                                soluongtemp = item.Soluong;
                                ktragh = true;
                            }
                        }
                    }
                    if (ktragh)
                    {
                        //tenhang = dt.Rows[0]["TenHang"].ToString();
                        soluong = (Convert.ToInt32(nud_soluong_hieu.Value)) + soluongtemp;
                        //dvt = dt.Rows[0]["DVT"].ToString();
                        dongia = float.Parse(dt.Rows[0]["DonGia"].ToString());
                        thanhtien = dongia * soluong;
                        //GioHang gh = new GioHang("" + mahang + "", "" + tenhang + "", soluong, "" + dvt + "", dongia, thanhtien);
                        foreach (GioHang item in Ds_HH)
                        {
                            if (item.Mahang.Equals(mahang))
                            {
                                item.Soluong = soluong;
                                item.Thanhtien = thanhtien;
                            }
                        }

                    }
                    else
                    {
                        tenhang = dt.Rows[0]["TenHang"].ToString();
                        soluong = Convert.ToInt32(nud_soluong_hieu.Value);
                        dvt = dt.Rows[0]["DVT"].ToString();
                        dongia = float.Parse(dt.Rows[0]["DonGia"].ToString());
                        thanhtien = dongia * soluong;
                        GioHang gh = new GioHang("" + mahang + "", "" + tenhang + "", soluong, "" + dvt + "", dongia, thanhtien);
                        Ds_HH.Add(gh);
                        
                    }
                    nud_soluong_hieu.Value = 1;
                    UpdateGioHang();
                    frm_LapHoaDon_Hieu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Ko có dữ liệu", "Thông báo");
                }
            }
        }
        private int layma()
        {
            ketnoi();
            DateTime thoigian = dtp_ngay_hieu.Value;
            string ngay = thoigian.Day.ToString() + thoigian.Month.ToString() + thoigian.Year.ToString();
            String sql = "SELECT TOP 1 SUBSTRING(SoHD,10,LEN(SoHD)-9) AS SoHD_So FROM Hoadon WHERE SoHD LIKE '" + ngay + "%'ORDER BY SoHD DESC";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            object kq = cmd.ExecuteScalar();
            if (kq != null && kq != DBNull.Value)
            {
                int maHD = int.Parse(kq.ToString());
                return maHD;
            }
            else
            {
                return 0;
            }

        }

        private void b_laysohd_hieu_Click(object sender, EventArgs e)
        {
            DateTime thoigian = dtp_ngay_hieu.Value;
            string ngay = thoigian.Day.ToString() + thoigian.Month.ToString() + thoigian.Year.ToString();
            string test = layma().ToString();
            int so = layma() + 1;
            string So = so.ToString("D3");
            string sohoadon = ngay + "-" + So;
            tb_sohd_hieu.Text = sohoadon;
        }
        private int themkhachhang()
        {
            if (ktra)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(tb_makh_hieu.Text) && !string.IsNullOrWhiteSpace(tb_hoten_hieu.Text) && !string.IsNullOrWhiteSpace(tb_diachi_hieu.Text) && !string.IsNullOrWhiteSpace(cb_loaikh_hieu.Text) && !string.IsNullOrWhiteSpace(tb_quan_hieu.Text) && !string.IsNullOrWhiteSpace(tb_thanhpho_hieu.Text))
                    {
                        ketnoi();
                        String sql = "INSERT INTO Khachhang VALUES ('" + tb_makh_hieu.Text + "',N'" + tb_hoten_hieu.Text + "',N'" + cb_loaikh_hieu.Text + "',N'" + tb_diachi_hieu.Text + "',N'" + tb_quan_hieu.Text + "',N'" + tb_thanhpho_hieu.Text + "')";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.Connection = sqlcon;
                        int kq = cmd.ExecuteNonQuery();
                        return kq;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không để trống thông tin khách hàng ", "Thông báo");
                        return -1;
                    }

                }
                catch
                {
                    MessageBox.Show("Thêm không thành công có thể mã khách hàng bị trùng ", "Thông báo");
                    return -1;
                }
            }
            else
            {
                return 1;
            }
            
        }
        private int kiemtrattkhachhang()
        {
            int sohoadon = 0;
            try
            {
                ketnoi();
                String sql = "SELECT Hoadon.SoHD, Hoadon.MaKH, SUM(CTHoadon.SoLuong * CTHoadon.DonGia) AS ThanhTien FROM HoaDon JOIN CTHoaDon  ON Hoadon.SoHD = CTHoadon.SoHD WHERE Hoadon.MaKH = '"+tb_makh_hieu.Text+ "' GROUP BY Hoadon.SoHD, Hoadon.MaKH HAVING SUM(CTHoadon.SoLuong * CTHoadon.DonGia) > 500000";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlcon);
                ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                sohoadon = ds.Tables[0].Rows.Count;
                return sohoadon;
            }
            catch
            {
                MessageBox.Show("Lỗi khi cập nhập loại khách hàng ", "Thông báo");
                return sohoadon;
            }
            
        }
        private void UpdateLoaiKhach()
        {
            try
            {
                ketnoi();
                String sql = "UPDATE KhachHang SET LoaiKH = N'Thân thiết' WHERE MaKH = '" + tb_makh_hieu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Chúc mừng khách hàng " + tb_makh_hieu.Text + " lên khách hàng thân thiết ", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật loại khách hàng ", "Thông báo");
            }
            
        }
        private void b_luu_hieu_Click(object sender, EventArgs e)
        {
            if (Ds_HH.Count == 0)
            {
                MessageBox.Show("Trong giỏ hàng chưa có sản phẩm nào !!!", "Thông báo");

            }
            else
            {
                if (string.IsNullOrWhiteSpace(tb_sohd_hieu.Text))
                {
                    MessageBox.Show("Vui lòng điền mã hóa đơn !!!", "Thông báo");
                }
                else
                {
                    if (int.Parse(tb_tralai_hieu.Text) < 0)
                    {
                        MessageBox.Show("Khách chưa trả tiền !!!", "Thông báo");
                    }
                    else
                    {
                        if(themkhachhang()>0)
                        {
                            try
                            {
                                ketnoi();
                                DateTime thoigian = dtp_ngay_hieu.Value;
                                string ngaymua = thoigian.ToString("yyyy-MM-dd");
                                string sql = "INSERT INTO Hoadon Values('" + tb_sohd_hieu.Text + "','" + ngaymua + "','" + tb_makh_hieu.Text + "','" + tb_manv_hieu.Text + "')";
                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = sql;
                                cmd.Connection = sqlcon;
                                int kq = cmd.ExecuteNonQuery();
                                /*if (kq > 0)
                                {
                                    MessageBox.Show("Thêm thành công ", "Thông báo");
                                }*/
                                int kq2 = 0;
                                foreach (GioHang item in Ds_HH)
                                {
                                    sql = "INSERT INTO CTHoadon Values('" + tb_sohd_hieu.Text + "','" + item.Mahang + "'," + item.Soluong + "," + item.Dongia + ")";
                                    SqlCommand cmd2 = new SqlCommand();
                                    cmd2.CommandType = CommandType.Text;
                                    cmd2.CommandText = sql;
                                    cmd2.Connection = sqlcon;
                                    kq2 = cmd2.ExecuteNonQuery();
                                    /*if (kq > 0)
                                    {
                                        MessageBox.Show("Thêm thành công ", "Thông báo");
                                    }*/
                                }
                                if (kq > 0 && kq2 > 0)
                                {
                                    MessageBox.Show("Thêm thành công ", "Thông báo");
                                    Frm_HoaDonBanHang_HAnh fr = new Frm_HoaDonBanHang_HAnh(tb_makh_hieu.Text);
                                    fr.Show();
                                    Ds_HH.Clear();
                                    tb_tongtien_hieu.Text = 0.ToString();
                                    tb_tienkhachdua_hieu.Text = 0.ToString();
                                    tb_tralai_hieu.Text = 0.ToString();
                                    tb_makh_hieu.ReadOnly = true;
                                    tb_hoten_hieu.ReadOnly=true;
                                    tb_diachi_hieu.ReadOnly = true;
                                    cb_loaikh_hieu.Enabled = false;
                                    tb_quan_hieu.ReadOnly = true;
                                    tb_thanhpho_hieu.ReadOnly = true;
                                    tb_sohd_hieu.Clear();
                                    ktra = false;
                                    UpdateGioHang();
                                    if(kiemtrattkhachhang()>=3)
                                    {
                                        UpdateLoaiKhach();
                                        DialogResult tb = MessageBox.Show("Bạn có muốn sáng giao diện cho khách hàng thân thiết không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if(tb == DialogResult.Yes)
                                        {
                                            frm_GioHang_Hieu frm = new frm_GioHang_Hieu(manv,tb_makh_hieu.Text);
                                            frm.Show();
                                            this.Close();
                                        }    
                                    }    
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Thêm không thành công có thể mã hóa đơn bị trùng ", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm thông tin khách hàng mới thất bại ", "Thông báo ");
                        }   
                        
                    }
                }
            }
        }

        private void b_thoat_hieu_Click(object sender, EventArgs e)
        {
            if(Ds_HH.Count>0)
            {
                DialogResult tb = MessageBox.Show("Trong danh sách có mặt hàng chưa lập hóa đơn . Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tb == DialogResult.Yes)
                {
                    this.Close();
                }    
            }
            else
            {
                this.Close();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_tienkhachdua_hieu_TextChanged(object sender, EventArgs e)
        {
            frm_LapHoaDon_Hieu_Load(sender, e);
        }
    }
}
