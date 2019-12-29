﻿namespace QLBHDT.GUI
{
    partial class frmChiTietHoaDonNhapList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvChiTietHoaDonNhapList = new System.Windows.Forms.DataGridView();
            this.colSoHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonNhapList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemMoi,
            this.btnSua,
            this.btnXoa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(88, 24);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvChiTietHoaDonNhapList
            // 
            this.dgvChiTietHoaDonNhapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDonNhapList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoHDN,
            this.colMaHang,
            this.colSoLuong,
            this.colDonGiaNhap,
            this.colGiamGia,
            this.colThanhTien});
            this.dgvChiTietHoaDonNhapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoaDonNhapList.Location = new System.Drawing.Point(0, 28);
            this.dgvChiTietHoaDonNhapList.Name = "dgvChiTietHoaDonNhapList";
            this.dgvChiTietHoaDonNhapList.RowTemplate.Height = 24;
            this.dgvChiTietHoaDonNhapList.Size = new System.Drawing.Size(1100, 591);
            this.dgvChiTietHoaDonNhapList.TabIndex = 1;
            // 
            // colSoHDN
            // 
            this.colSoHDN.DataPropertyName = "SoHDN";
            this.colSoHDN.HeaderText = "Số hóa đơn nhập";
            this.colSoHDN.Name = "colSoHDN";
            this.colSoHDN.Width = 200;
            // 
            // colMaHang
            // 
            this.colMaHang.DataPropertyName = "MaHang";
            this.colMaHang.HeaderText = "Mã hàng";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 150;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá nhập";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.Width = 200;
            // 
            // colGiamGia
            // 
            this.colGiamGia.DataPropertyName = "GiamGia";
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Width = 200;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 200;
            // 
            // frmChiTietHoaDonNhapList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgvChiTietHoaDonNhapList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietHoaDonNhapList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonBanList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonNhapList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemMoi;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDonNhapList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}