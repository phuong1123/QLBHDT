namespace QLBHDT.GUI
{
    partial class frmKhachHangList
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
            this.dgvKhachHangList = new System.Windows.Forms.DataGridView();
            this.colMaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangList)).BeginInit();
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
            // dgvKhachHangList
            // 
            this.dgvKhachHangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHangList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhach,
            this.colTenKhach,
            this.colDienThoai,
            this.colDiaChi});
            this.dgvKhachHangList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHangList.Location = new System.Drawing.Point(0, 28);
            this.dgvKhachHangList.Name = "dgvKhachHangList";
            this.dgvKhachHangList.RowTemplate.Height = 24;
            this.dgvKhachHangList.Size = new System.Drawing.Size(1100, 591);
            this.dgvKhachHangList.TabIndex = 1;
            // 
            // colMaKhach
            // 
            this.colMaKhach.DataPropertyName = "MaKhach";
            this.colMaKhach.HeaderText = "Mã khách";
            this.colMaKhach.Name = "colMaKhach";
            this.colMaKhach.Width = 170;
            // 
            // colTenKhach
            // 
            this.colTenKhach.DataPropertyName = "TenKhach";
            this.colTenKhach.HeaderText = "Tên khách";
            this.colTenKhach.Name = "colTenKhach";
            this.colTenKhach.Width = 300;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Width = 200;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // frmKhachHangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgvKhachHangList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhachHangList";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHangList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemMoi;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvKhachHangList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}