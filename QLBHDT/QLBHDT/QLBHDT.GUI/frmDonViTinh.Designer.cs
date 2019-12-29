namespace QLBHDT.GUI
{
    partial class frmDonViTinh
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
            this.lblMaDonVi = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.lblTenDonVi = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaDonVi
            // 
            this.lblMaDonVi.AutoSize = true;
            this.lblMaDonVi.Location = new System.Drawing.Point(75, 68);
            this.lblMaDonVi.Name = "lblMaDonVi";
            this.lblMaDonVi.Size = new System.Drawing.Size(103, 22);
            this.lblMaDonVi.TabIndex = 0;
            this.lblMaDonVi.Text = "Mã đơn vị: ";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.Location = new System.Drawing.Point(205, 65);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Size = new System.Drawing.Size(341, 30);
            this.txtMaDonVi.TabIndex = 1;
            // 
            // lblTenDonVi
            // 
            this.lblTenDonVi.AutoSize = true;
            this.lblTenDonVi.Location = new System.Drawing.Point(75, 125);
            this.lblTenDonVi.Name = "lblTenDonVi";
            this.lblTenDonVi.Size = new System.Drawing.Size(102, 22);
            this.lblTenDonVi.TabIndex = 2;
            this.lblTenDonVi.Text = "Tên đơn vị:";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(205, 122);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(341, 30);
            this.txtTenDonVi.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(236, 190);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 46);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmDonViTinh
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 290);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenDonVi);
            this.Controls.Add(this.lblTenDonVi);
            this.Controls.Add(this.txtMaDonVi);
            this.Controls.Add(this.lblMaDonVi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDonViTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị tính";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDonVi;
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.Label lblTenDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Button btnLuu;
    }
}