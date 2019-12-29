namespace QLBHDT.GUI
{
    partial class frmLoaiHang
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
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.cboMaNhom = new System.Windows.Forms.ComboBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(54, 61);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(78, 22);
            this.lblMaLoai.TabIndex = 0;
            this.lblMaLoai.Text = "Mã loại:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(171, 58);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(330, 30);
            this.txtMaLoai.TabIndex = 1;
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(54, 116);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(89, 22);
            this.lblMaNhom.TabIndex = 2;
            this.lblMaNhom.Text = "Mã nhóm:";
            // 
            // cboMaNhom
            // 
            this.cboMaNhom.FormattingEnabled = true;
            this.cboMaNhom.Location = new System.Drawing.Point(171, 113);
            this.cboMaNhom.Name = "cboMaNhom";
            this.cboMaNhom.Size = new System.Drawing.Size(330, 30);
            this.cboMaNhom.TabIndex = 3;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(54, 170);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(82, 22);
            this.lblTenLoai.TabIndex = 4;
            this.lblTenLoai.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(171, 167);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(330, 30);
            this.txtTenLoai.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(227, 243);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 48);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmLoaiHang
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 325);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.lblTenLoai);
            this.Controls.Add(this.cboMaNhom);
            this.Controls.Add(this.lblMaNhom);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.lblMaLoai);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại hàng";
            this.Load += new System.EventHandler(this.frmLoaiHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.ComboBox cboMaNhom;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnLuu;
    }
}