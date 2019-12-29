namespace QLBHDT.GUI
{
    partial class frmNhanVien
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
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblMaCa = new System.Windows.Forms.Label();
            this.cboMaCa = new System.Windows.Forms.ComboBox();
            this.lblMaCongViec = new System.Windows.Forms.Label();
            this.cboMaCongViec = new System.Windows.Forms.ComboBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(65, 53);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(206, 50);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(473, 30);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(65, 107);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(126, 22);
            this.lblTenNhanVien.TabIndex = 2;
            this.lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(206, 104);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(473, 30);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(419, 169);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(87, 22);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(528, 167);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(68, 26);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(613, 167);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(56, 26);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(65, 167);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 22);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(206, 161);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(170, 30);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.Value = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Location = new System.Drawing.Point(65, 222);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(65, 22);
            this.lblMaCa.TabIndex = 9;
            this.lblMaCa.Text = "Mã ca:";
            // 
            // cboMaCa
            // 
            this.cboMaCa.FormattingEnabled = true;
            this.cboMaCa.Location = new System.Drawing.Point(206, 219);
            this.cboMaCa.Name = "cboMaCa";
            this.cboMaCa.Size = new System.Drawing.Size(463, 30);
            this.cboMaCa.TabIndex = 10;
            // 
            // lblMaCongViec
            // 
            this.lblMaCongViec.AutoSize = true;
            this.lblMaCongViec.Location = new System.Drawing.Point(65, 280);
            this.lblMaCongViec.Name = "lblMaCongViec";
            this.lblMaCongViec.Size = new System.Drawing.Size(123, 22);
            this.lblMaCongViec.TabIndex = 11;
            this.lblMaCongViec.Text = "Mã công việc:";
            // 
            // cboMaCongViec
            // 
            this.cboMaCongViec.FormattingEnabled = true;
            this.cboMaCongViec.Location = new System.Drawing.Point(206, 272);
            this.cboMaCongViec.Name = "cboMaCongViec";
            this.cboMaCongViec.Size = new System.Drawing.Size(463, 30);
            this.cboMaCongViec.TabIndex = 12;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(65, 334);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(98, 22);
            this.lblDienThoai.TabIndex = 13;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(206, 331);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(463, 30);
            this.txtDienThoai.TabIndex = 14;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(65, 393);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChi.TabIndex = 15;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(206, 390);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(463, 30);
            this.txtDiaChi.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(282, 464);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 49);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNhanVien
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 544);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.cboMaCongViec);
            this.Controls.Add(this.lblMaCongViec);
            this.Controls.Add(this.cboMaCa);
            this.Controls.Add(this.lblMaCa);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.ComboBox cboMaCa;
        private System.Windows.Forms.Label lblMaCongViec;
        private System.Windows.Forms.ComboBox cboMaCongViec;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnLuu;
    }
}