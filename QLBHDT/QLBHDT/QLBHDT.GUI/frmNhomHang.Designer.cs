namespace QLBHDT.GUI
{
    partial class frmNhomHang
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
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.lblCongDung = new System.Windows.Forms.Label();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(61, 59);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(89, 22);
            this.lblMaNhom.TabIndex = 0;
            this.lblMaNhom.Text = "Mã nhóm:";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(182, 59);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(361, 30);
            this.txtMaNhom.TabIndex = 1;
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(61, 117);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(93, 22);
            this.lblTenNhom.TabIndex = 2;
            this.lblTenNhom.Text = "Tên nhóm:";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(182, 114);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(361, 30);
            this.txtTenNhom.TabIndex = 3;
            // 
            // lblCongDung
            // 
            this.lblCongDung.AutoSize = true;
            this.lblCongDung.Location = new System.Drawing.Point(61, 172);
            this.lblCongDung.Name = "lblCongDung";
            this.lblCongDung.Size = new System.Drawing.Size(99, 22);
            this.lblCongDung.TabIndex = 4;
            this.lblCongDung.Text = "Công dụng:";
            // 
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(182, 169);
            this.txtCongDung.Multiline = true;
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(361, 82);
            this.txtCongDung.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(234, 296);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 50);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNhomHang
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtCongDung);
            this.Controls.Add(this.lblCongDung);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.lblMaNhom);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label lblCongDung;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.Button btnLuu;
    }
}