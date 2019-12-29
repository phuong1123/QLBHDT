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
    public partial class frmNhomHang : Form
    {

        public Action<string, string, string> getData;
        public void GetData(string maNhom, string tenNhom, string congDung)
        {
            txtMaNhom.Text = maNhom;
            txtTenNhom.Text = tenNhom;
            txtCongDung.Text = congDung;
        }



        public frmNhomHang()
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

        NhomHangBLL bll = new NhomHangBLL();
        NhomHang obj = new NhomHang();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhom.Text != string.Empty && txtTenNhom.Text != string.Empty)
                {
                    obj.MaNhom = txtMaNhom.Text;
                    obj.TenNhom = txtTenNhom.Text;
                    obj.CongDung = txtCongDung.Text;
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
                        txtMaNhom.Focus();
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
                        txtMaNhom.Focus();
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
