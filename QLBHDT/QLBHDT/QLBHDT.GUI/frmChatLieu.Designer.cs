namespace QLBHDT.GUI
{
    partial class frmChatLieu
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
            this.lblMaChatLieu = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.lblTenChatLieu = new System.Windows.Forms.Label();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaChatLieu
            // 
            this.lblMaChatLieu.AutoSize = true;
            this.lblMaChatLieu.Location = new System.Drawing.Point(56, 67);
            this.lblMaChatLieu.Name = "lblMaChatLieu";
            this.lblMaChatLieu.Size = new System.Drawing.Size(114, 22);
            this.lblMaChatLieu.TabIndex = 0;
            this.lblMaChatLieu.Text = "Mã chất liệu:";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(191, 64);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(333, 30);
            this.txtMaChatLieu.TabIndex = 1;
            // 
            // lblTenChatLieu
            // 
            this.lblTenChatLieu.AutoSize = true;
            this.lblTenChatLieu.Location = new System.Drawing.Point(56, 129);
            this.lblTenChatLieu.Name = "lblTenChatLieu";
            this.lblTenChatLieu.Size = new System.Drawing.Size(118, 22);
            this.lblTenChatLieu.TabIndex = 2;
            this.lblTenChatLieu.Text = "Tên chất liệu:";
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(191, 126);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(333, 30);
            this.txtTenChatLieu.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(208, 203);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmChatLieu
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 307);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.lblTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Controls.Add(this.lblMaChatLieu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chất liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Label lblTenChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.Button btnLuu;
    }
}