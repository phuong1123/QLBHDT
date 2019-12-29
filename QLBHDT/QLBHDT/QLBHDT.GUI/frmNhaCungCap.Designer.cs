namespace QLBHDT.GUI
{
    partial class frmNhaCungCap
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
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChia = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(68, 58);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(148, 22);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(245, 55);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(356, 30);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(68, 112);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(152, 22);
            this.lblTenNCC.TabIndex = 2;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(245, 112);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(356, 30);
            this.txtTenNCC.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(68, 168);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(98, 22);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(245, 165);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(356, 30);
            this.txtDienThoai.TabIndex = 5;
            // 
            // lblDiaChia
            // 
            this.lblDiaChia.AutoSize = true;
            this.lblDiaChia.Location = new System.Drawing.Point(68, 225);
            this.lblDiaChia.Name = "lblDiaChia";
            this.lblDiaChia.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChia.TabIndex = 6;
            this.lblDiaChia.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(245, 222);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(356, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(254, 305);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(171, 55);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNhaCungCap
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 415);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChia);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblMaNCC);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDiaChia;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnLuu;
    }
}