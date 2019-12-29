using QLBHDT.BLL;
using QLBHDT.DTO;
using QLBHDT.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHDT.GUI
{
    public partial class frmDanhMucHangHoa : Form
    {
        public Action<string, string, string, string, string, string, string, string, string, string, string, string, string> getData;
        public void GetData(string maHang, string tenHang, string maNhom, string maLoai, 
                            string maDonVi, string maChatLieu, string maNuocSanXuat, string soLuong, 
                            string donGiaNhap, string donGiaBan, string thoiGianBaoHanh, string anh, string ghiChu)
        {
            txtMaHang.Text = maHang;
            txtTenHang.Text = tenHang;
            cboMaNhom.SelectedValue = maNhom;
            cboMaLoai.SelectedValue = maLoai;
            cboMaDonVi.SelectedValue = maDonVi;
            cboMaChatLieu.SelectedValue = maChatLieu;
            cboMaNuocSanXuat.SelectedValue = maNuocSanXuat;
            //txtSoLuong.Text = soLuong.ToString();
            //txtDonGiaNhap.Text = donGiaNhap.ToString();
            //txtDonGiaBan.Text = donGiaBan.ToString();
            txtSoLuong.Text = soLuong;
            txtDonGiaNhap.Text = donGiaNhap;
            txtDonGiaBan.Text = donGiaBan;
            txtThoiGianBaoHanh.Text = thoiGianBaoHanh;
            txtChonHinhAnh.Text = anh;
            txtGhiChu.Text = ghiChu;
        }



        public frmDanhMucHangHoa()
        {
            InitializeComponent();
            getData = GetData;
        }



        public void LoadMaNhom()
        {
            NhomHangBLL bll = new NhomHangBLL();
            List<NhomHang> list = new List<NhomHang>();
            list = bll.GetAll();
            cboMaNhom.DataSource = list;
            cboMaNhom.DisplayMember = "MaNhom";
            cboMaNhom.ValueMember = "MaNhom";
        }

        public void LoadMaLoai()
        {
            LoaiHangBLL bll = new LoaiHangBLL();
            List<LoaiHang> list = new List<LoaiHang>();
            list = bll.GetAll();
            cboMaLoai.DataSource = list;
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.ValueMember = "MaLoai";
        }

        public void LoadMaDonVi()
        {
            DonViTinhBLL bll = new DonViTinhBLL();
            List<DonViTinh> list = new List<DonViTinh>();
            list = bll.GetAll();
            cboMaDonVi.DataSource = list;
            cboMaDonVi.DisplayMember = "MaDonVi";
            cboMaDonVi.ValueMember = "MaDonVi";
        }

        public void LoadMaChatLieu()
        {
            ChatLieuBLL bll = new ChatLieuBLL();
            List<ChatLieu> list = new List<ChatLieu>();
            list = bll.GetAll();
            cboMaChatLieu.DataSource = list;
            cboMaChatLieu.DisplayMember = "MaChatLieu";
            cboMaChatLieu.ValueMember = "MaChatLieu";
        }

        public void LoadMaNuocSanXuat()
        {
            NuocSanXuatBLL bll = new NuocSanXuatBLL();
            List<NuocSanXuat> list = new List<NuocSanXuat>();
            list = bll.GetAll();
            cboMaNuocSanXuat.DataSource = list;
            cboMaNuocSanXuat.DisplayMember = "MaNuocSanXuat";
            cboMaNuocSanXuat.ValueMember = "MaNuocSanXuat";
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

        DanhMucHangHoaBLL bll = new DanhMucHangHoaBLL();
        DanhMucHangHoa obj = new DanhMucHangHoa();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHang.Text != string.Empty && txtTenHang.Text != string.Empty)
                {
                    obj.MaHang = txtMaHang.Text;
                    obj.TenHang = txtTenHang.Text;
                    obj.MaNhom = cboMaNhom.SelectedValue.ToString();
                    obj.MaLoai = cboMaLoai.SelectedValue.ToString();
                    obj.MaDonVi = cboMaDonVi.SelectedValue.ToString();
                    obj.MaChatLieu = cboMaChatLieu.SelectedValue.ToString();
                    obj.MaNuocSanXuat = cboMaNuocSanXuat.SelectedValue.ToString();
                    //obj.SoLuong = int.Parse(txtSoLuong.Text);
                    //obj.DonGiaNhap = int.Parse(txtDonGiaNhap.Text);
                    //obj.DonGiaBan = int.Parse(txtDonGiaBan.Text);
                    obj.SoLuong = txtSoLuong.Text;
                    obj.DonGiaNhap = txtDonGiaNhap.Text;
                    obj.DonGiaBan = txtDonGiaBan.Text;
                    obj.ThoiGianBaoHanh = txtThoiGianBaoHanh.Text;
                    obj.Anh = txtChonHinhAnh.Text;
                    obj.GhiChu = txtGhiChu.Text;
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
                        txtMaHang.Focus();
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
                        txtMaHang.Focus();
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

        private void frmDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            LoadMaLoai();
            LoadMaNhom();
            LoadMaDonVi();
            LoadMaChatLieu();
            LoadMaNuocSanXuat();
        }



        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtChonHinhAnh.Text = openFile.FileName;
                                              
            }
        }


    }
}
