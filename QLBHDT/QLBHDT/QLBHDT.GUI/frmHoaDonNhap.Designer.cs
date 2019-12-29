namespace QLBHDT.GUI
{
    partial class frmHoaDonNhap
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
            this.lblSoHDN = new System.Windows.Forms.Label();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSoHDN
            // 
            this.lblSoHDN.AutoSize = true;
            this.lblSoHDN.Location = new System.Drawing.Point(60, 51);
            this.lblSoHDN.Name = "lblSoHDN";
            this.lblSoHDN.Size = new System.Drawing.Size(147, 22);
            this.lblSoHDN.TabIndex = 0;
            this.lblSoHDN.Text = "Số hóa đơn nhập:";
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(229, 48);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(325, 30);
            this.txtSoHDN.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(60, 105);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 2;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(229, 102);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(325, 30);
            this.cboMaNhanVien.TabIndex = 3;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(60, 161);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(99, 22);
            this.lblNgayNhap.TabIndex = 4;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(229, 155);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(207, 30);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(60, 218);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(148, 22);
            this.lblMaNCC.TabIndex = 6;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(60, 274);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 22);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(229, 271);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(325, 30);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(229, 337);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 51);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(229, 215);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(325, 30);
            this.cboMaNCC.TabIndex = 7;
            // 
            // frmHoaDonNhap
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 424);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.cboMaNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.txtSoHDN);
            this.Controls.Add(this.lblSoHDN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHDN;
        private System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboMaNCC;
    }
}