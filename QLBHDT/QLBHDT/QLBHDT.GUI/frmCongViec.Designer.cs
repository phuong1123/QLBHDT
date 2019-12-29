namespace QLBHDT.GUI
{
    partial class frmCongViec
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
            this.lblMaCongViec = new System.Windows.Forms.Label();
            this.txtMaCongViec = new System.Windows.Forms.TextBox();
            this.lblTenCongViec = new System.Windows.Forms.Label();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaCongViec
            // 
            this.lblMaCongViec.AutoSize = true;
            this.lblMaCongViec.Location = new System.Drawing.Point(80, 76);
            this.lblMaCongViec.Name = "lblMaCongViec";
            this.lblMaCongViec.Size = new System.Drawing.Size(123, 22);
            this.lblMaCongViec.TabIndex = 0;
            this.lblMaCongViec.Text = "Mã công việc:";
            // 
            // txtMaCongViec
            // 
            this.txtMaCongViec.Location = new System.Drawing.Point(231, 73);
            this.txtMaCongViec.Name = "txtMaCongViec";
            this.txtMaCongViec.Size = new System.Drawing.Size(354, 30);
            this.txtMaCongViec.TabIndex = 1;
            // 
            // lblTenCongViec
            // 
            this.lblTenCongViec.AutoSize = true;
            this.lblTenCongViec.Location = new System.Drawing.Point(80, 136);
            this.lblTenCongViec.Name = "lblTenCongViec";
            this.lblTenCongViec.Size = new System.Drawing.Size(127, 22);
            this.lblTenCongViec.TabIndex = 2;
            this.lblTenCongViec.Text = "Tên công việc:";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(231, 133);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(354, 30);
            this.txtTenCongViec.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(241, 210);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 49);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmCongViec
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 327);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenCongViec);
            this.Controls.Add(this.lblTenCongViec);
            this.Controls.Add(this.txtMaCongViec);
            this.Controls.Add(this.lblMaCongViec);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công việc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCongViec;
        private System.Windows.Forms.TextBox txtMaCongViec;
        private System.Windows.Forms.Label lblTenCongViec;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Button btnLuu;
    }
}