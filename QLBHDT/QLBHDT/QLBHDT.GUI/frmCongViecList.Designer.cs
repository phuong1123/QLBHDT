namespace QLBHDT.GUI
{
    partial class frmCongViecList
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
            this.dgvCongViecList = new System.Windows.Forms.DataGridView();
            this.colMaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViecList)).BeginInit();
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
            // dgvCongViecList
            // 
            this.dgvCongViecList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViecList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCongViec,
            this.colTenCongViec});
            this.dgvCongViecList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongViecList.Location = new System.Drawing.Point(0, 28);
            this.dgvCongViecList.Name = "dgvCongViecList";
            this.dgvCongViecList.RowTemplate.Height = 24;
            this.dgvCongViecList.Size = new System.Drawing.Size(1100, 591);
            this.dgvCongViecList.TabIndex = 1;
            // 
            // colMaCongViec
            // 
            this.colMaCongViec.DataPropertyName = "MaCongViec";
            this.colMaCongViec.HeaderText = "Mã công việc";
            this.colMaCongViec.Name = "colMaCongViec";
            this.colMaCongViec.Width = 200;
            // 
            // colTenCongViec
            // 
            this.colTenCongViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenCongViec.DataPropertyName = "TenCongViec";
            this.colTenCongViec.HeaderText = "Tên công việc";
            this.colTenCongViec.Name = "colTenCongViec";
            // 
            // frmCongViecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgvCongViecList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCongViecList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách công việc";
            this.Load += new System.EventHandler(this.frmCongViecList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViecList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemMoi;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvCongViecList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCongViec;
    }
}