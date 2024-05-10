namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    partial class frm_GioHang_Hieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_laysohd_hieu = new System.Windows.Forms.Button();
            this.b_luu_hieu = new System.Windows.Forms.Button();
            this.tb_manv_hieu = new System.Windows.Forms.TextBox();
            this.tb_makh_hieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tralai_hieu = new System.Windows.Forms.TextBox();
            this.tb_tienkhachdua_hieu = new System.Windows.Forms.TextBox();
            this.tb_sohd_hieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tongtien_hieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_giohang_hieu = new System.Windows.Forms.DataGridView();
            this.ColMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngay_hieu = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachsanpham_hieu = new System.Windows.Forms.DataGridView();
            this.b_themvaogio_hieu = new System.Windows.Forms.Button();
            this.tb_tenhang_hieu = new System.Windows.Forms.TextBox();
            this.tb_mahang_hieu = new System.Windows.Forms.TextBox();
            this.nud_soluong_hieu = new System.Windows.Forms.NumericUpDown();
            this.b_thoat_hieu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang_hieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsanpham_hieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong_hieu)).BeginInit();
            this.SuspendLayout();
            // 
            // b_laysohd_hieu
            // 
            this.b_laysohd_hieu.Location = new System.Drawing.Point(170, 135);
            this.b_laysohd_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.b_laysohd_hieu.Name = "b_laysohd_hieu";
            this.b_laysohd_hieu.Size = new System.Drawing.Size(75, 25);
            this.b_laysohd_hieu.TabIndex = 50;
            this.b_laysohd_hieu.Text = "Lấy số HD";
            this.b_laysohd_hieu.UseVisualStyleBackColor = true;
            this.b_laysohd_hieu.Click += new System.EventHandler(this.b_laysohd_hieu_Click);
            // 
            // b_luu_hieu
            // 
            this.b_luu_hieu.Location = new System.Drawing.Point(306, 286);
            this.b_luu_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.b_luu_hieu.Name = "b_luu_hieu";
            this.b_luu_hieu.Size = new System.Drawing.Size(123, 27);
            this.b_luu_hieu.TabIndex = 49;
            this.b_luu_hieu.Text = "Lưu và xuất hóa đơn";
            this.b_luu_hieu.UseVisualStyleBackColor = true;
            this.b_luu_hieu.Click += new System.EventHandler(this.b_luu_hieu_Click);
            // 
            // tb_manv_hieu
            // 
            this.tb_manv_hieu.Location = new System.Drawing.Point(170, 26);
            this.tb_manv_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_manv_hieu.Name = "tb_manv_hieu";
            this.tb_manv_hieu.ReadOnly = true;
            this.tb_manv_hieu.Size = new System.Drawing.Size(110, 20);
            this.tb_manv_hieu.TabIndex = 48;
            // 
            // tb_makh_hieu
            // 
            this.tb_makh_hieu.Location = new System.Drawing.Point(170, 64);
            this.tb_makh_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_makh_hieu.Name = "tb_makh_hieu";
            this.tb_makh_hieu.ReadOnly = true;
            this.tb_makh_hieu.Size = new System.Drawing.Size(110, 20);
            this.tb_makh_hieu.TabIndex = 47;
            this.tb_makh_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Trả lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Khách trả";
            // 
            // tb_tralai_hieu
            // 
            this.tb_tralai_hieu.Location = new System.Drawing.Point(444, 110);
            this.tb_tralai_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tralai_hieu.Name = "tb_tralai_hieu";
            this.tb_tralai_hieu.ReadOnly = true;
            this.tb_tralai_hieu.Size = new System.Drawing.Size(96, 20);
            this.tb_tralai_hieu.TabIndex = 42;
            this.tb_tralai_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_tienkhachdua_hieu
            // 
            this.tb_tienkhachdua_hieu.Location = new System.Drawing.Point(444, 66);
            this.tb_tienkhachdua_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tienkhachdua_hieu.Name = "tb_tienkhachdua_hieu";
            this.tb_tienkhachdua_hieu.Size = new System.Drawing.Size(96, 20);
            this.tb_tienkhachdua_hieu.TabIndex = 41;
            this.tb_tienkhachdua_hieu.Text = "0";
            this.tb_tienkhachdua_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_tienkhachdua_hieu.TextChanged += new System.EventHandler(this.tb_tienkhachdua_hieu_TextChanged);
            // 
            // tb_sohd_hieu
            // 
            this.tb_sohd_hieu.Location = new System.Drawing.Point(170, 102);
            this.tb_sohd_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_sohd_hieu.Name = "tb_sohd_hieu";
            this.tb_sohd_hieu.ReadOnly = true;
            this.tb_sohd_hieu.Size = new System.Drawing.Size(110, 20);
            this.tb_sohd_hieu.TabIndex = 40;
            this.tb_sohd_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số hóa đơn";
            // 
            // tb_tongtien_hieu
            // 
            this.tb_tongtien_hieu.Location = new System.Drawing.Point(444, 27);
            this.tb_tongtien_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tongtien_hieu.Name = "tb_tongtien_hieu";
            this.tb_tongtien_hieu.ReadOnly = true;
            this.tb_tongtien_hieu.Size = new System.Drawing.Size(96, 20);
            this.tb_tongtien_hieu.TabIndex = 38;
            this.tb_tongtien_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_giohang_hieu);
            this.groupBox2.Location = new System.Drawing.Point(64, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(692, 237);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // dgv_giohang_hieu
            // 
            this.dgv_giohang_hieu.AllowUserToAddRows = false;
            this.dgv_giohang_hieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_giohang_hieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giohang_hieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaHang,
            this.ColTenHang,
            this.ColSoLuong,
            this.ColDvt,
            this.ColDonGia,
            this.ColThanhTien,
            this.ColXoa});
            this.dgv_giohang_hieu.Location = new System.Drawing.Point(4, 17);
            this.dgv_giohang_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_giohang_hieu.Name = "dgv_giohang_hieu";
            this.dgv_giohang_hieu.ReadOnly = true;
            this.dgv_giohang_hieu.RowHeadersWidth = 51;
            this.dgv_giohang_hieu.RowTemplate.Height = 24;
            this.dgv_giohang_hieu.Size = new System.Drawing.Size(678, 215);
            this.dgv_giohang_hieu.TabIndex = 0;
            this.dgv_giohang_hieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_giohang_hieu_CellContentClick);
            // 
            // ColMaHang
            // 
            this.ColMaHang.HeaderText = "Mã Hàng";
            this.ColMaHang.MinimumWidth = 6;
            this.ColMaHang.Name = "ColMaHang";
            this.ColMaHang.ReadOnly = true;
            this.ColMaHang.Width = 90;
            // 
            // ColTenHang
            // 
            this.ColTenHang.HeaderText = "Tên Hàng";
            this.ColTenHang.MinimumWidth = 6;
            this.ColTenHang.Name = "ColTenHang";
            this.ColTenHang.ReadOnly = true;
            this.ColTenHang.Width = 200;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.HeaderText = "SL";
            this.ColSoLuong.MinimumWidth = 6;
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.ReadOnly = true;
            this.ColSoLuong.Width = 80;
            // 
            // ColDvt
            // 
            this.ColDvt.HeaderText = "DVT";
            this.ColDvt.MinimumWidth = 6;
            this.ColDvt.Name = "ColDvt";
            this.ColDvt.ReadOnly = true;
            this.ColDvt.Width = 70;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn Giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            this.ColDonGia.Width = 150;
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.HeaderText = "Thành Tiền";
            this.ColThanhTien.MinimumWidth = 6;
            this.ColThanhTien.Name = "ColThanhTien";
            this.ColThanhTien.ReadOnly = true;
            this.ColThanhTien.Width = 150;
            // 
            // ColXoa
            // 
            this.ColXoa.HeaderText = "Xóa";
            this.ColXoa.MinimumWidth = 6;
            this.ColXoa.Name = "ColXoa";
            this.ColXoa.ReadOnly = true;
            this.ColXoa.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số lượng";
            // 
            // dtp_ngay_hieu
            // 
            this.dtp_ngay_hieu.Enabled = false;
            this.dtp_ngay_hieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay_hieu.Location = new System.Drawing.Point(170, 172);
            this.dtp_ngay_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngay_hieu.Name = "dtp_ngay_hieu";
            this.dtp_ngay_hieu.Size = new System.Drawing.Size(110, 20);
            this.dtp_ngay_hieu.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_danhsachsanpham_hieu);
            this.groupBox1.Location = new System.Drawing.Point(553, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(226, 278);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgv_danhsachsanpham_hieu
            // 
            this.dgv_danhsachsanpham_hieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_danhsachsanpham_hieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsanpham_hieu.Location = new System.Drawing.Point(11, 17);
            this.dgv_danhsachsanpham_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_danhsachsanpham_hieu.Name = "dgv_danhsachsanpham_hieu";
            this.dgv_danhsachsanpham_hieu.RowHeadersWidth = 51;
            this.dgv_danhsachsanpham_hieu.RowTemplate.Height = 24;
            this.dgv_danhsachsanpham_hieu.Size = new System.Drawing.Size(211, 257);
            this.dgv_danhsachsanpham_hieu.TabIndex = 0;
            this.dgv_danhsachsanpham_hieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsanpham_hieu_CellContentClick);
            // 
            // b_themvaogio_hieu
            // 
            this.b_themvaogio_hieu.Location = new System.Drawing.Point(132, 286);
            this.b_themvaogio_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.b_themvaogio_hieu.Name = "b_themvaogio_hieu";
            this.b_themvaogio_hieu.Size = new System.Drawing.Size(141, 27);
            this.b_themvaogio_hieu.TabIndex = 30;
            this.b_themvaogio_hieu.Text = "Thêm vào giỏ hàng";
            this.b_themvaogio_hieu.UseVisualStyleBackColor = true;
            this.b_themvaogio_hieu.Click += new System.EventHandler(this.b_themvaogio_hieu_Click);
            // 
            // tb_tenhang_hieu
            // 
            this.tb_tenhang_hieu.Location = new System.Drawing.Point(170, 243);
            this.tb_tenhang_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenhang_hieu.Name = "tb_tenhang_hieu";
            this.tb_tenhang_hieu.Size = new System.Drawing.Size(161, 20);
            this.tb_tenhang_hieu.TabIndex = 29;
            this.tb_tenhang_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mahang_hieu
            // 
            this.tb_mahang_hieu.Location = new System.Drawing.Point(62, 243);
            this.tb_mahang_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mahang_hieu.Name = "tb_mahang_hieu";
            this.tb_mahang_hieu.Size = new System.Drawing.Size(81, 20);
            this.tb_mahang_hieu.TabIndex = 28;
            this.tb_mahang_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_soluong_hieu
            // 
            this.nud_soluong_hieu.Location = new System.Drawing.Point(372, 243);
            this.nud_soluong_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.nud_soluong_hieu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soluong_hieu.Name = "nud_soluong_hieu";
            this.nud_soluong_hieu.Size = new System.Drawing.Size(56, 20);
            this.nud_soluong_hieu.TabIndex = 27;
            this.nud_soluong_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_soluong_hieu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_thoat_hieu
            // 
            this.b_thoat_hieu.Location = new System.Drawing.Point(464, 286);
            this.b_thoat_hieu.Margin = new System.Windows.Forms.Padding(2);
            this.b_thoat_hieu.Name = "b_thoat_hieu";
            this.b_thoat_hieu.Size = new System.Drawing.Size(76, 27);
            this.b_thoat_hieu.TabIndex = 86;
            this.b_thoat_hieu.Text = "Thoát";
            this.b_thoat_hieu.UseVisualStyleBackColor = true;
            this.b_thoat_hieu.Click += new System.EventHandler(this.b_thoat_hieu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Ngày bán ";
            // 
            // frm_GioHang_Hieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.b_thoat_hieu);
            this.Controls.Add(this.b_laysohd_hieu);
            this.Controls.Add(this.b_luu_hieu);
            this.Controls.Add(this.tb_manv_hieu);
            this.Controls.Add(this.tb_makh_hieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tralai_hieu);
            this.Controls.Add(this.tb_tienkhachdua_hieu);
            this.Controls.Add(this.tb_sohd_hieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tongtien_hieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ngay_hieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_themvaogio_hieu);
            this.Controls.Add(this.tb_tenhang_hieu);
            this.Controls.Add(this.tb_mahang_hieu);
            this.Controls.Add(this.nud_soluong_hieu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_GioHang_Hieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_GioHang_Hieu";
            this.Load += new System.EventHandler(this.frm_GioHang_Hieu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang_hieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsanpham_hieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong_hieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_laysohd_hieu;
        private System.Windows.Forms.Button b_luu_hieu;
        private System.Windows.Forms.TextBox tb_manv_hieu;
        private System.Windows.Forms.TextBox tb_makh_hieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tralai_hieu;
        private System.Windows.Forms.TextBox tb_tienkhachdua_hieu;
        private System.Windows.Forms.TextBox tb_sohd_hieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tongtien_hieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_giohang_hieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn ColXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngay_hieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_danhsachsanpham_hieu;
        private System.Windows.Forms.Button b_themvaogio_hieu;
        private System.Windows.Forms.TextBox tb_tenhang_hieu;
        private System.Windows.Forms.TextBox tb_mahang_hieu;
        private System.Windows.Forms.NumericUpDown nud_soluong_hieu;
        private System.Windows.Forms.Button b_thoat_hieu;
        private System.Windows.Forms.Label label10;
    }
}