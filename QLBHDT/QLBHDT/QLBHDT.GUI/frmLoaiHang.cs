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
    public partial class frmLoaiHang : Form
    {
        public Action<string, string, string> getData;
        public void GetData(string maLoai, string maNhom, string tenLoai)
        {
            txtMaLoai.Text = maLoai;
            cboMaNhom.SelectedValue = maNhom;
            txtTenLoai.Text = tenLoai;
        }

        public void LoadMaNhom()
        {
            NhomHangBLL bll = new NhomHangBLL();
            List<NhomHang> list = new List<NhomHang>();
            list = bll.GetAll();
            cboMaNhom.DataSource = list;
            cboMaNhom.DisplayMember = "TenNhom";
            cboMaNhom.ValueMember = "MaNhom";
        }




        public frmLoaiHang()
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

        LoaiHangBLL bll = new LoaiHangBLL();
        LoaiHang obj = new LoaiHang();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoai.Text != string.Empty && txtTenLoai.Text != string.Empty && cboMaNhom.Text != string.Empty)
                {
                    obj.MaLoai = txtMaLoai.Text;
                    obj.MaNhom = cboMaNhom.SelectedValue.ToString();
                    obj.TenLoai = txtTenLoai.Text;
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
                        txtMaLoai.Focus();
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
                        txtMaLoai.Focus();               
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

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            LoadMaNhom();
        }
    }
}
