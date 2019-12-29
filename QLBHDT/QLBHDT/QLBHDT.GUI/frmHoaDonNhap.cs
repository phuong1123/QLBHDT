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
    public partial class frmHoaDonNhap : Form
    {
        public Action<string, string, DateTime, string, int> getData;
        public void GetData(string soHDB, string maNhanVien, DateTime ngayBan, string maNCC, int tongTien)
        {
            txtSoHDN.Text = soHDB;
            cboMaNhanVien.SelectedValue = maNhanVien;
            dtpNgayNhap.Value = ngayBan;
            cboMaNCC.SelectedValue = maNCC;
            txtTongTien.Text = tongTien.ToString();
        }



        public frmHoaDonNhap()
        {
            InitializeComponent();
            getData = GetData;
        }



        public void LoadMaNhanVien()
        {
            NhanVienBLL bll = new NhanVienBLL();
            List<NhanVien> list = new List<NhanVien>();
            list = bll.GetAll();
            cboMaNhanVien.DataSource = list;
            cboMaNhanVien.DisplayMember = "MaNhanVien";
            cboMaNhanVien.ValueMember = "MaNhanVien";
        }

        public void LoadMaNCC()
        {
            NhaCungCapBLL bll = new NhaCungCapBLL();
            List<NhaCungCap> list = new List<NhaCungCap>();
            list = bll.GetAll();
            cboMaNCC.DataSource = list;
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";
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

        HoaDonNhapBLL bll = new HoaDonNhapBLL();
        HoaDonNhap obj = new HoaDonNhap();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoHDN.Text != string.Empty && txtTongTien.Text != string.Empty)
                {
                    obj.SoHDN = txtSoHDN.Text;
                    obj.MaNhanVien = cboMaNhanVien.SelectedValue.ToString();
                    obj.NgayNhap = dtpNgayNhap.Value;
                    obj.MaNCC = cboMaNCC.SelectedValue.ToString();
                    obj.TongTien = int.Parse(txtTongTien.Text);
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
                        txtSoHDN.Focus();
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
                        txtSoHDN.Focus();
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

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadMaNhanVien();
            LoadMaNCC();
        }
    }
}
