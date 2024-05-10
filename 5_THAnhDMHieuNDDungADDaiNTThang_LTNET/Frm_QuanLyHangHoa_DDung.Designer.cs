namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    partial class Frm_QuanLyHangHoa_DDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radioMaloai = new System.Windows.Forms.RadioButton();
            this.radioMahang = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioTenhang = new System.Windows.Forms.RadioButton();
            this.cmb_maloai_DDung = new System.Windows.Forms.ComboBox();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Hàng Hóa";
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.cmb_maloai_DDung);
            this.gr1.Controls.Add(this.txtDongia);
            this.gr1.Controls.Add(this.txtDVT);
            this.gr1.Controls.Add(this.txtTenhang);
            this.gr1.Controls.Add(this.txtMahang);
            this.gr1.Controls.Add(this.label6);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.lable2);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Location = new System.Drawing.Point(46, 53);
            this.gr1.Margin = new System.Windows.Forms.Padding(2);
            this.gr1.Name = "gr1";
            this.gr1.Padding = new System.Windows.Forms.Padding(2);
            this.gr1.Size = new System.Drawing.Size(520, 115);
            this.gr1.TabIndex = 1;
            this.gr1.TabStop = false;
            this.gr1.Text = "Chi tiết hàng hóa";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(358, 51);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(146, 20);
            this.txtDongia.TabIndex = 9;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(358, 17);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(146, 20);
            this.txtDVT.TabIndex = 8;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(91, 81);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(146, 20);
            this.txtTenhang.TabIndex = 7;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(91, 23);
            this.txtMahang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(146, 20);
            this.txtMahang.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DVT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên hàng";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(32, 55);
            this.lable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(45, 13);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Mã Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(46, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(520, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(80, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 24);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(202, 182);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 24);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(314, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 24);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(494, 227);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(66, 24);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(494, 182);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 24);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radioMaloai
            // 
            this.radioMaloai.AutoSize = true;
            this.radioMaloai.Location = new System.Drawing.Point(200, 230);
            this.radioMaloai.Margin = new System.Windows.Forms.Padding(2);
            this.radioMaloai.Name = "radioMaloai";
            this.radioMaloai.Size = new System.Drawing.Size(63, 17);
            this.radioMaloai.TabIndex = 22;
            this.radioMaloai.TabStop = true;
            this.radioMaloai.Text = "Mã Loại";
            this.radioMaloai.UseVisualStyleBackColor = true;
            // 
            // radioMahang
            // 
            this.radioMahang.AutoSize = true;
            this.radioMahang.Location = new System.Drawing.Point(129, 231);
            this.radioMahang.Margin = new System.Windows.Forms.Padding(2);
            this.radioMahang.Name = "radioMahang";
            this.radioMahang.Size = new System.Drawing.Size(67, 17);
            this.radioMahang.TabIndex = 21;
            this.radioMahang.TabStop = true;
            this.radioMahang.Text = "Mã hàng";
            this.radioMahang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tìm kiếm theo:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(358, 232);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(110, 20);
            this.txtTim.TabIndex = 19;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 274);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioTenhang
            // 
            this.radioTenhang.AutoSize = true;
            this.radioTenhang.Location = new System.Drawing.Point(272, 231);
            this.radioTenhang.Margin = new System.Windows.Forms.Padding(2);
            this.radioTenhang.Name = "radioTenhang";
            this.radioTenhang.Size = new System.Drawing.Size(71, 17);
            this.radioTenhang.TabIndex = 23;
            this.radioTenhang.TabStop = true;
            this.radioTenhang.Text = "Tên hàng";
            this.radioTenhang.UseVisualStyleBackColor = true;
            // 
            // cmb_maloai_DDung
            // 
            this.cmb_maloai_DDung.FormattingEnabled = true;
            this.cmb_maloai_DDung.Location = new System.Drawing.Point(91, 51);
            this.cmb_maloai_DDung.Name = "cmb_maloai_DDung";
            this.cmb_maloai_DDung.Size = new System.Drawing.Size(146, 21);
            this.cmb_maloai_DDung.TabIndex = 10;
            // 
            // Frm_QuanLyHangHoa_DDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 417);
            this.Controls.Add(this.radioTenhang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioMaloai);
            this.Controls.Add(this.radioMahang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_QuanLyHangHoa_DDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr_QuanLyHangHoa_DDung";
            this.Load += new System.EventHandler(this.Fr_QuanLyHangHoa_DDung_Load);
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radioMaloai;
        private System.Windows.Forms.RadioButton radioMahang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioTenhang;
        private System.Windows.Forms.ComboBox cmb_maloai_DDung;
    }
}