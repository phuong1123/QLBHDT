namespace QLBHDT.GUI
{
    partial class frmDanhMucHangHoaList
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
            this.dgvDanhMucHangHoaList = new System.Windows.Forms.DataGridView();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNuocSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHangHoaList)).BeginInit();
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
            // dgvDanhMucHangHoaList
            // 
            this.dgvDanhMucHangHoaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucHangHoaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHang,
            this.colTenHang,
            this.colMaNhom,
            this.colMaLoai,
            this.colMaDonVi,
            this.colMaChatLieu,
            this.colMaNuocSanXuat,
            this.colSoLuong,
            this.colDonGiaNhap,
            this.colDonGiaBan,
            this.colThoiGianBaoHanh,
            this.colAnh,
            this.colGhiChu});
            this.dgvDanhMucHangHoaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMucHangHoaList.Location = new System.Drawing.Point(0, 28);
            this.dgvDanhMucHangHoaList.Name = "dgvDanhMucHangHoaList";
            this.dgvDanhMucHangHoaList.RowTemplate.Height = 24;
            this.dgvDanhMucHangHoaList.Size = new System.Drawing.Size(1100, 591);
            this.dgvDanhMucHangHoaList.TabIndex = 1;
            // 
            // colMaHang
            // 
            this.colMaHang.DataPropertyName = "MaHang";
            this.colMaHang.HeaderText = "Mã hàng";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Width = 200;
            // 
            // colTenHang
            // 
            this.colTenHang.DataPropertyName = "TenHang";
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Width = 250;
            // 
            // colMaNhom
            // 
            this.colMaNhom.DataPropertyName = "MaNhom";
            this.colMaNhom.HeaderText = "Mã nhóm";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Width = 170;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Width = 170;
            // 
            // colMaDonVi
            // 
            this.colMaDonVi.DataPropertyName = "MaDonVi";
            this.colMaDonVi.HeaderText = "Mã đơn vị";
            this.colMaDonVi.Name = "colMaDonVi";
            this.colMaDonVi.Width = 170;
            // 
            // colMaChatLieu
            // 
            this.colMaChatLieu.DataPropertyName = "MaChatLieu";
            this.colMaChatLieu.HeaderText = "Mã chất liệu";
            this.colMaChatLieu.Name = "colMaChatLieu";
            this.colMaChatLieu.Width = 170;
            // 
            // colMaNuocSanXuat
            // 
            this.colMaNuocSanXuat.DataPropertyName = "MaNuocSanXuat";
            this.colMaNuocSanXuat.HeaderText = "Mã nước sx";
            this.colMaNuocSanXuat.Name = "colMaNuocSanXuat";
            this.colMaNuocSanXuat.Width = 170;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 170;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá nhập";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.Width = 170;
            // 
            // colDonGiaBan
            // 
            this.colDonGiaBan.DataPropertyName = "DonGiaBan";
            this.colDonGiaBan.HeaderText = "Đơn giá bán";
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.Width = 170;
            // 
            // colThoiGianBaoHanh
            // 
            this.colThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            this.colThoiGianBaoHanh.HeaderText = "Thời gian bảo hành";
            this.colThoiGianBaoHanh.Name = "colThoiGianBaoHanh";
            this.colThoiGianBaoHanh.Width = 150;
            // 
            // colAnh
            // 
            this.colAnh.DataPropertyName = "Anh";
            this.colAnh.HeaderText = "Ảnh";
            this.colAnh.Name = "colAnh";
            this.colAnh.Width = 200;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 250;
            // 
            // frmDanhMucHangHoaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgvDanhMucHangHoaList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDanhMucHangHoaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frmDanhMucHangHoaList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHangHoaList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemMoi;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvDanhMucHangHoaList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNuocSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}