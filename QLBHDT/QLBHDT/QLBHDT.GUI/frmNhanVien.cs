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
    public partial class frmNhanVien : Form
    {
        public Action<string, string,bool, DateTime, string, string, string, string> getData;
        public void GetData(string maNhanVien, string tenNhanVien, bool gioiTinh, DateTime ngaySinh, string dienThoai, string diaChi, string maCa, string maCongViec)
        {
            txtMaNhanVien.Text = maNhanVien;
            txtTenNhanVien.Text = tenNhanVien;            
            rdbNam.Checked = gioiTinh;
            dtpNgaySinh.Value = ngaySinh;
            txtDienThoai.Text = dienThoai;
            txtDiaChi.Text = diaChi;
            cboMaCa.SelectedValue = maCa;
            cboMaCongViec.SelectedValue = maCongViec;
        }

        public void LoadMaCa()
        {
            CaLamBLL bll = new CaLamBLL();
            List<CaLam> list = new List<CaLam>();
            list = bll.GetAll();
            cboMaCa.DataSource = list;
            cboMaCa.DisplayMember = "TenCa";
            cboMaCa.ValueMember = "MaCa";
        }

        public void LoadMaCongViec()
        {
            CongViecBLL bll = new CongViecBLL();
            List<CongViec> list = new List<CongViec>();
            list = bll.GetAll();
            cboMaCongViec.DataSource = list;
            cboMaCongViec.DisplayMember = "TenCongViec";
            cboMaCongViec.ValueMember = "MaCongViec";
        }


        public frmNhanVien()
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

        NhanVienBLL bll = new NhanVienBLL();
        NhanVien obj = new NhanVien();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhanVien.Text != string.Empty && txtTenNhanVien.Text != string.Empty)
                {
                    obj.MaNhanVien = txtMaNhanVien.Text;
                    obj.TenNhanVien = txtTenNhanVien.Text;
                    obj.GioiTinh = ((rdbNam.Checked ? true : false) == true ? "Nam" : "Nữ");
                    obj.NgaySinh = (DateTime) dtpNgaySinh.Value ;
                    obj.DienThoai = txtDienThoai.Text;
                    obj.DiaChi = txtDiaChi.Text;
                    obj.MaCa = cboMaCa.SelectedValue.ToString();
                    obj.MaCongViec = cboMaCongViec.SelectedValue.ToString();
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
                        txtMaNhanVien.Focus();
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
                        txtMaNhanVien.Focus();
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadMaCa();
            LoadMaCongViec();
        }
    }
}
