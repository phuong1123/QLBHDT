namespace QLBHDT.GUI
{
    partial class frmNuocSanXuat
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
            this.lblMaNuocSanXuat = new System.Windows.Forms.Label();
            this.txtMaNuocSanXuat = new System.Windows.Forms.TextBox();
            this.lblTenNuocSanXuat = new System.Windows.Forms.Label();
            this.txtTenNuocSanXuat = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNuocSanXuat
            // 
            this.lblMaNuocSanXuat.AutoSize = true;
            this.lblMaNuocSanXuat.Location = new System.Drawing.Point(70, 69);
            this.lblMaNuocSanXuat.Name = "lblMaNuocSanXuat";
            this.lblMaNuocSanXuat.Size = new System.Drawing.Size(87, 22);
            this.lblMaNuocSanXuat.TabIndex = 0;
            this.lblMaNuocSanXuat.Text = "Mã nước:";
            // 
            // txtMaNuocSanXuat
            // 
            this.txtMaNuocSanXuat.Location = new System.Drawing.Point(194, 66);
            this.txtMaNuocSanXuat.Name = "txtMaNuocSanXuat";
            this.txtMaNuocSanXuat.Size = new System.Drawing.Size(339, 30);
            this.txtMaNuocSanXuat.TabIndex = 1;
            // 
            // lblTenNuocSanXuat
            // 
            this.lblTenNuocSanXuat.AutoSize = true;
            this.lblTenNuocSanXuat.Location = new System.Drawing.Point(70, 135);
            this.lblTenNuocSanXuat.Name = "lblTenNuocSanXuat";
            this.lblTenNuocSanXuat.Size = new System.Drawing.Size(91, 22);
            this.lblTenNuocSanXuat.TabIndex = 2;
            this.lblTenNuocSanXuat.Text = "Tên nước:";
            // 
            // txtTenNuocSanXuat
            // 
            this.txtTenNuocSanXuat.Location = new System.Drawing.Point(194, 132);
            this.txtTenNuocSanXuat.Name = "txtTenNuocSanXuat";
            this.txtTenNuocSanXuat.Size = new System.Drawing.Size(339, 30);
            this.txtTenNuocSanXuat.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(237, 206);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNuocSanXuat
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 304);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenNuocSanXuat);
            this.Controls.Add(this.lblTenNuocSanXuat);
            this.Controls.Add(this.txtMaNuocSanXuat);
            this.Controls.Add(this.lblMaNuocSanXuat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuocSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nước sản xuất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNuocSanXuat;
        private System.Windows.Forms.TextBox txtMaNuocSanXuat;
        private System.Windows.Forms.Label lblTenNuocSanXuat;
        private System.Windows.Forms.TextBox txtTenNuocSanXuat;
        private System.Windows.Forms.Button btnLuu;
    }
}