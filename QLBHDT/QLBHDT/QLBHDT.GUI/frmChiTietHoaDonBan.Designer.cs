namespace QLBHDT.GUI
{
    partial class frmChiTietHoaDonBan
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
            this.cboSoHDB = new System.Windows.Forms.ComboBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoHDB
            // 
            this.lblSoHDB.AutoSize = true;
            this.lblSoHDB.Location = new System.Drawing.Point(66, 61);
            this.lblSoHDB.Name = "lblSoHDB";
            this.lblSoHDB.Size = new System.Drawing.Size(138, 22);
            this.lblSoHDB.TabIndex = 0;
            this.lblSoHDB.Text = "Số hóa đơn bán:";
            // 
            // cboSoHDB
            // 
            this.cboSoHDB.FormattingEnabled = true;
            this.cboSoHDB.Location = new System.Drawing.Point(225, 58);
            this.cboSoHDB.Name = "cboSoHDB";
            this.cboSoHDB.Size = new System.Drawing.Size(329, 30);
            this.cboSoHDB.TabIndex = 1;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(66, 112);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(83, 22);
            this.lblMaHang.TabIndex = 2;
            this.lblMaHang.Text = "Mã hàng:";
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(225, 109);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(329, 30);
            this.cboMaHang.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(66, 165);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(88, 22);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(225, 162);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(329, 30);
            this.txtSoLuong.TabIndex = 5;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(66, 213);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(88, 22);
            this.lblGiamGia.TabIndex = 6;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(225, 213);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(329, 30);
            this.txtGiamGia.TabIndex = 7;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(66, 272);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(98, 22);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(225, 269);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(329, 30);
            this.txtThanhTien.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(236, 335);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(149, 53);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmChiTietHoaDonBan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cboMaHang);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.cboSoHDB);
            this.Controls.Add(this.lblSoHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTietHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHDB;
        private System.Windows.Forms.ComboBox cboSoHDB;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnLuu;
    }
}