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
    public partial class frmKhachHang : Form
    {
        public Action<string, string, string, string> getData;
        public void GetData(string maKhach, string tenKhach,  string dienThoai, string diaChi)
        {
            txtMaKhach.Text = maKhach;
            txtTenKhach.Text = tenKhach;
            txtDienThoai.Text = dienThoai;
            txtDiaChi.Text = diaChi;
        }

       

        public frmKhachHang()
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

        KhachHangBLL bll = new KhachHangBLL();
        KhachHang obj = new KhachHang();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhach.Text != string.Empty && txtTenKhach.Text != string.Empty)
                {
                    obj.MaKhach = txtMaKhach.Text;
                    obj.TenKhach = txtTenKhach.Text;
                    obj.DienThoai = txtDienThoai.Text;
                    obj.DiaChi = txtDiaChi.Text;
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
                        txtMaKhach.Focus();
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
                        txtMaKhach.Focus();
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
