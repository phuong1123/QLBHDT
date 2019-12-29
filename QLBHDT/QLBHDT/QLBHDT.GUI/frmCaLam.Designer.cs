namespace QLBHDT.GUI
{
    partial class frmCaLam
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
            this.lblMaCa = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.lblTenCa = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Location = new System.Drawing.Point(61, 61);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(65, 22);
            this.lblMaCa.TabIndex = 0;
            this.lblMaCa.Text = "Mã ca:";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(157, 58);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(353, 30);
            this.txtMaCa.TabIndex = 1;
            // 
            // lblTenCa
            // 
            this.lblTenCa.AutoSize = true;
            this.lblTenCa.Location = new System.Drawing.Point(61, 117);
            this.lblTenCa.Name = "lblTenCa";
            this.lblTenCa.Size = new System.Drawing.Size(69, 22);
            this.lblTenCa.TabIndex = 2;
            this.lblTenCa.Text = "Tên ca:";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(157, 117);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(353, 30);
            this.txtTenCa.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(199, 187);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(163, 54);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmCaLam
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 307);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.lblTenCa);
            this.Controls.Add(this.txtMaCa);
            this.Controls.Add(this.lblMaCa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaLam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label lblTenCa;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.Button btnLuu;
    }
}