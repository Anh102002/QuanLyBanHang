namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    partial class Frm_thongkedoanhthu_HAnh
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
            this.dgv_thongke_HAnh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thongke_HAnh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat_HAnh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_nhanvien_HAnh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngay_Hanh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongtien_HAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke_HAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke_HAnh
            // 
            this.dgv_thongke_HAnh.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_thongke_HAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke_HAnh.Location = new System.Drawing.Point(12, 203);
            this.dgv_thongke_HAnh.Name = "dgv_thongke_HAnh";
            this.dgv_thongke_HAnh.Size = new System.Drawing.Size(813, 294);
            this.dgv_thongke_HAnh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // btn_thongke_HAnh
            // 
            this.btn_thongke_HAnh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke_HAnh.Location = new System.Drawing.Point(566, 75);
            this.btn_thongke_HAnh.Name = "btn_thongke_HAnh";
            this.btn_thongke_HAnh.Size = new System.Drawing.Size(89, 24);
            this.btn_thongke_HAnh.TabIndex = 8;
            this.btn_thongke_HAnh.Text = "Thống kê";
            this.btn_thongke_HAnh.UseVisualStyleBackColor = true;
            this.btn_thongke_HAnh.Click += new System.EventHandler(this.btn_thongke_HAnh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat_HAnh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_nhanvien_HAnh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_ngay_Hanh);
            this.groupBox1.Controls.Add(this.btn_thongke_HAnh);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // btn_thoat_HAnh
            // 
            this.btn_thoat_HAnh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat_HAnh.Location = new System.Drawing.Point(692, 76);
            this.btn_thoat_HAnh.Name = "btn_thoat_HAnh";
            this.btn_thoat_HAnh.Size = new System.Drawing.Size(89, 24);
            this.btn_thoat_HAnh.TabIndex = 15;
            this.btn_thoat_HAnh.Text = "Thoát";
            this.btn_thoat_HAnh.UseVisualStyleBackColor = true;
            this.btn_thoat_HAnh.Click += new System.EventHandler(this.btn_thoat_HAnh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn nhân viên :";
            // 
            // cmb_nhanvien_HAnh
            // 
            this.cmb_nhanvien_HAnh.FormattingEnabled = true;
            this.cmb_nhanvien_HAnh.Location = new System.Drawing.Point(293, 75);
            this.cmb_nhanvien_HAnh.Name = "cmb_nhanvien_HAnh";
            this.cmb_nhanvien_HAnh.Size = new System.Drawing.Size(204, 24);
            this.cmb_nhanvien_HAnh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn ngày :";
            // 
            // dtp_ngay_Hanh
            // 
            this.dtp_ngay_Hanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_Hanh.Location = new System.Drawing.Point(43, 76);
            this.dtp_ngay_Hanh.Name = "dtp_ngay_Hanh";
            this.dtp_ngay_Hanh.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngay_Hanh.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(451, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Doanh thu trong ngày :\r\n";
            // 
            // txt_tongtien_HAnh
            // 
            this.txt_tongtien_HAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tongtien_HAnh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien_HAnh.Location = new System.Drawing.Point(652, 506);
            this.txt_tongtien_HAnh.Name = "txt_tongtien_HAnh";
            this.txt_tongtien_HAnh.ReadOnly = true;
            this.txt_tongtien_HAnh.Size = new System.Drawing.Size(173, 27);
            this.txt_tongtien_HAnh.TabIndex = 15;
            // 
            // Frm_thongkedoanhthu_HAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(837, 542);
            this.Controls.Add(this.txt_tongtien_HAnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thongke_HAnh);
            this.Name = "Frm_thongkedoanhthu_HAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông kê doanh thu theo ngày_Trần Hoàng Anh";
            this.Load += new System.EventHandler(this.Frm_thongkedoanhthu_HAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke_HAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongke_HAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thongke_HAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngay_Hanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_nhanvien_HAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongtien_HAnh;
        private System.Windows.Forms.Button btn_thoat_HAnh;
    }
}