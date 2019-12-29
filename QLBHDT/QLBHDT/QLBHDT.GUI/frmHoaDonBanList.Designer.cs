namespace QLBHDT.GUI
{
    partial class frmHoaDonBanList
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
            this.dgvHoaDonBanList = new System.Windows.Forms.DataGridView();
            this.colSoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanList)).BeginInit();
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
            // dgvHoaDonBanList
            // 
            this.dgvHoaDonBanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoHDB,
            this.colMaNhanVien,
            this.colNgayBan,
            this.colMaKhach,
            this.colTongTien});
            this.dgvHoaDonBanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonBanList.Location = new System.Drawing.Point(0, 28);
            this.dgvHoaDonBanList.Name = "dgvHoaDonBanList";
            this.dgvHoaDonBanList.RowTemplate.Height = 24;
            this.dgvHoaDonBanList.Size = new System.Drawing.Size(1100, 591);
            this.dgvHoaDonBanList.TabIndex = 1;
            // 
            // colSoHDB
            // 
            this.colSoHDB.DataPropertyName = "SoHDB";
            this.colSoHDB.HeaderText = "Số hóa đơn bán";
            this.colSoHDB.Name = "colSoHDB";
            this.colSoHDB.Width = 200;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Mã nhân viên";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Width = 170;
            // 
            // colNgayBan
            // 
            this.colNgayBan.DataPropertyName = "NgayBan";
            this.colNgayBan.HeaderText = "Ngày bán";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.Width = 200;
            // 
            // colMaKhach
            // 
            this.colMaKhach.DataPropertyName = "MaKhach";
            this.colMaKhach.HeaderText = "Mã khách";
            this.colMaKhach.Name = "colMaKhach";
            this.colMaKhach.Width = 170;
            // 
            // colTongTien
            // 
            this.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            // 
            // frmHoaDonBanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgvHoaDonBanList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonBanList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHoaDonBanList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemMoi;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvHoaDonBanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
    }
}