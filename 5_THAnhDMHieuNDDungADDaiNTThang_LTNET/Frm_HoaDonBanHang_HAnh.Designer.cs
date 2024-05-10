namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    partial class Frm_HoaDonBanHang_HAnh
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyTapHoaDataSet = new _5_THAnhDMHieuNDDungADDaiNTThang_LTNET.QuanLyTapHoaDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat_HAnh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpv_hoadon_HAnh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spHoadonTableAdapter = new _5_THAnhDMHieuNDDungADDaiNTThang_LTNET.QuanLyTapHoaDataSetTableAdapters.spHoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spHoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTapHoaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spHoadonBindingSource
            // 
            this.spHoadonBindingSource.DataMember = "spHoadon";
            this.spHoadonBindingSource.DataSource = this.QuanLyTapHoaDataSet;
            // 
            // QuanLyTapHoaDataSet
            // 
            this.QuanLyTapHoaDataSet.DataSetName = "QuanLyTapHoaDataSet";
            this.QuanLyTapHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_thoat_HAnh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat_HAnh
            // 
            this.btn_thoat_HAnh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_thoat_HAnh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_thoat_HAnh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_thoat_HAnh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat_HAnh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_thoat_HAnh.Location = new System.Drawing.Point(839, 0);
            this.btn_thoat_HAnh.Name = "btn_thoat_HAnh";
            this.btn_thoat_HAnh.Size = new System.Drawing.Size(75, 32);
            this.btn_thoat_HAnh.TabIndex = 0;
            this.btn_thoat_HAnh.Text = "Thoát";
            this.btn_thoat_HAnh.UseVisualStyleBackColor = false;
            this.btn_thoat_HAnh.Click += new System.EventHandler(this.btn_thoat_HAnh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 29);
            this.panel2.TabIndex = 1;
            // 
            // rpv_hoadon_HAnh
            // 
            this.rpv_hoadon_HAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spHoadonBindingSource;
            this.rpv_hoadon_HAnh.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_hoadon_HAnh.LocalReport.ReportEmbeddedResource = "_5_THAnhDMHieuNDDungADDaiNTThang_LTNET.Report_HD.rdlc";
            this.rpv_hoadon_HAnh.Location = new System.Drawing.Point(0, 32);
            this.rpv_hoadon_HAnh.Name = "rpv_hoadon_HAnh";
            this.rpv_hoadon_HAnh.ServerReport.BearerToken = null;
            this.rpv_hoadon_HAnh.Size = new System.Drawing.Size(914, 482);
            this.rpv_hoadon_HAnh.TabIndex = 2;
            this.rpv_hoadon_HAnh.Load += new System.EventHandler(this.rpv_hoadon_HAnh_Load);
            // 
            // spHoadonTableAdapter
            // 
            this.spHoadonTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_HoaDonBanHang_HAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.rpv_hoadon_HAnh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_HoaDonBanHang_HAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Bán Hàng_Trần Hoàng Anh";
            this.Load += new System.EventHandler(this.Frm_HoaDonBanHang_HAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spHoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTapHoaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_hoadon_HAnh;
        private System.Windows.Forms.Button btn_thoat_HAnh;
        private System.Windows.Forms.BindingSource spHoadonBindingSource;
        private QuanLyTapHoaDataSet QuanLyTapHoaDataSet;
        private QuanLyTapHoaDataSetTableAdapters.spHoadonTableAdapter spHoadonTableAdapter;
    }
}