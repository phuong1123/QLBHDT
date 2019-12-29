namespace QLBHDT.GUI
{
    partial class frmHoaDonBan
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
            this.lblSoHDB = new System.Windows.Forms.Label();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSoHDB
            // 
            this.lblSoHDB.AutoSize = true;
            this.lblSoHDB.Location = new System.Drawing.Point(65, 46);
            this.lblSoHDB.Name = "lblSoHDB";
            this.lblSoHDB.Size = new System.Drawing.Size(138, 22);
            this.lblSoHDB.TabIndex = 0;
            this.lblSoHDB.Text = "Số hóa đơn bán:";
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Location = new System.Drawing.Point(216, 43);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(332, 30);
            this.txtSoHDB.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(65, 100);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 2;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(65, 157);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(90, 22);
            this.lblNgayBan.TabIndex = 4;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(216, 151);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(185, 30);
            this.dtpNgayBan.TabIndex = 5;
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Location = new System.Drawing.Point(65, 208);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(92, 22);
            this.lblMaKhach.TabIndex = 6;
            this.lblMaKhach.Text = "Mã khách:";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(216, 205);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(332, 30);
            this.cboMaKhach.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(65, 265);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 22);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(216, 262);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(332, 30);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(231, 334);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 52);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(216, 97);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(332, 30);
            this.cboMaNhanVien.TabIndex = 3;
            // 
            // frmHoaDonBan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.cboMaNhanVien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.cboMaKhach);
            this.Controls.Add(this.lblMaKhach);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.lblNgayBan);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.txtSoHDB);
            this.Controls.Add(this.lblSoHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHDB;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
    }
}