using QLBHDT.BLL;
using QLBHDT.DTO;
using QLBHDT.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHDT.GUI
{
    public partial class frmChatLieu : Form
    {
        ChatLieuBLL bll = new ChatLieuBLL();
        ChatLieu obj = new ChatLieu();

        public Action<string, string> getData;
        public void GetData(string maChatLieu, string tenChatLieu)
        {
            txtMaChatLieu.Text = maChatLieu;
            txtTenChatLieu.Text = tenChatLieu;
        }


        public frmChatLieu()
        {
            InitializeComponent();
            getData = GetData;
        }


        public event EventHandler Button_Clicked;

        private void Clear()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChatLieu.Text != string.Empty && txtTenChatLieu.Text != string.Empty)
                {
                    obj.MaChatLieu = txtMaChatLieu.Text;
                    obj.TenChatLieu = txtTenChatLieu.Text;
                    if (Common.state == 0)
                    {
                        if (bll.Insert(obj))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                        }
                        Clear();
                        txtMaChatLieu.Focus();
                    }
                    else
                    {
                        if (bll.Update(obj))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                        }

                        else
                            MessageBox.Show("Lỗi cập nhật!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        Clear();
                        txtMaChatLieu.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            if (Button_Clicked != null)
            {

                Button_Clicked(sender, e);
            }
        }
    }
}
