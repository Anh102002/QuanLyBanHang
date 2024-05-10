using System;
using System.Collections;
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
    public partial class frm_GioHang_Hieu : Form
    {
        private string manv, makh;
        public frm_GioHang_Hieu()
        {
            InitializeComponent();
        }
        public frm_GioHang_Hieu(string manv,string makh)
        {
            InitializeComponent();
            this.manv = manv;
            this.makh = makh;
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
            dgv_giohang_hieu.Rows.Clear();
            foreach (GioHang item in Ds_HH)
            {
                dgv_giohang_hieu.Rows.Add(item.Mahang, item.Tenhang, item.Soluong, item.Dvt, item.Dongia, item.Thanhtien, "  X");
            }
        }

        private void frm_GioHang_Hieu_Load(object sender, EventArgs e)
        {
            try
            {
                tb_makh_hieu.Text = this.makh;
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
                ketnoi();
                String sql = "select *from Hanghoa";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
                ds = new DataSet();
                sqlda.Fill(ds);

                dgv_danhsachsanpham_hieu.DataSource = ds.Tables[0];
                dgv_danhsachsanpham_hieu.Columns[0].HeaderText = "Mã hàng";
                dgv_danhsachsanpham_hieu.Columns[1].HeaderText = "Mã loại";
                dgv_danhsachsanpham_hieu.Columns[2].HeaderText = "Tên hàng";
                dgv_danhsachsanpham_hieu.Columns[3].HeaderText = "Đơn vị tính";
                dgv_danhsachsanpham_hieu.Columns[4].HeaderText = "Đơn giá";
            }
            catch 
            {
                MessageBox.Show("Dữ liệu nhập sai !!!", "Thông báo");
            }
        }

        private void dgv_danhsachsanpham_hieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mahang_hieu.Text = dgv_danhsachsanpham_hieu.CurrentRow.Cells[0].Value.ToString();
            tb_tenhang_hieu.Text = dgv_danhsachsanpham_hieu.CurrentRow.Cells[2].Value.ToString();
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

        private void dgv_giohang_hieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell clickedCell = dgv_giohang_hieu.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (clickedCell is DataGridViewButtonCell)
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn bỏ mặt hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (tb == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0)
                    {
                        int rowIndex = e.RowIndex;
                        Ds_HH.RemoveAt(rowIndex);
                        UpdateGioHang();
                        frm_GioHang_Hieu_Load(sender, e);
                    }
                }
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
                                tb_sohd_hieu.Clear();
                                tb_tongtien_hieu.Text = 0.ToString();
                                tb_tienkhachdua_hieu.Text = 0.ToString();
                                tb_tralai_hieu.Text = 0.ToString();
                                UpdateGioHang();
                            }
                        }
                        catch 
                        {
                            MessageBox.Show("Thêm không thành công có thể mã hóa đơn bị trùng ", "Thông báo");
                        }
                    }
                }
            }
        }

        private void tb_tienkhachdua_hieu_TextChanged(object sender, EventArgs e)
        {
            frm_GioHang_Hieu_Load(sender, e);
        }

        private void b_thoat_hieu_Click(object sender, EventArgs e)
        {
            if (Ds_HH.Count > 0)
            {
                DialogResult tb = MessageBox.Show("Trong danh sách có mặt hàng chưa lập hóa đơn . Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tb == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void b_themvaogio_hieu_Click(object sender, EventArgs e)
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
                /*string testten = dt.Rows[0]["TenHang"].ToString();*/
                //MessageBox.Show("" + sql + "", "Thông báo");
                if (dt.Rows.Count > 0)
                {
                    string mahang = dt.Rows[0]["MaHang"].ToString();
                    string tenhang = "";
                    int soluong = 0;
                    string dvt = "";
                    float dongia = 0;
                    float thanhtien = 0;
                    bool ktra = false;
                    int soluongtemp = 0;
                    if (Ds_HH.Count > 0)
                    {
                        foreach (GioHang item in Ds_HH)
                        {
                            if (item.Mahang.Equals(mahang))
                            {
                                soluongtemp = item.Soluong;
                                ktra = true;
                            }
                        }
                    }
                    if (ktra)
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
                    frm_GioHang_Hieu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Ko có dữ liệu", "Thông báo");
                }
            }
        }
    }
}
