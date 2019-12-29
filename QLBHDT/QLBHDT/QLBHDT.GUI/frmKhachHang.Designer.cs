namespace QLBHDT.GUI
{
    partial class frmKhachHang
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
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChia = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Location = new System.Drawing.Point(71, 65);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(92, 22);
            this.lblMaKhach.TabIndex = 0;
            this.lblMaKhach.Text = "Mã khách:";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(194, 62);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(353, 30);
            this.txtMaKhach.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(71, 129);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(96, 22);
            this.lblTenKhach.TabIndex = 2;
            this.lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(194, 126);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(353, 30);
            this.txtTenKhach.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(71, 194);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(98, 22);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(194, 191);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(353, 30);
            this.txtDienThoai.TabIndex = 5;
            // 
            // lblDiaChia
            // 
            this.lblDiaChia.AutoSize = true;
            this.lblDiaChia.Location = new System.Drawing.Point(71, 259);
            this.lblDiaChia.Name = "lblDiaChia";
            this.lblDiaChia.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChia.TabIndex = 6;
            this.lblDiaChia.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(194, 256);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(353, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(233, 332);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 60);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmKhachHang
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 442);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChia);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.lblMaKhach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDiaChia;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnLuu;
    }
}