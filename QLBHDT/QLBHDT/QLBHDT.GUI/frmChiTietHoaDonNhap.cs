﻿using QLBHDT.BLL;
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
    public partial class frmChiTietHoaDonNhap : Form
    {
        public Action<string, string, int, int,int, int> getData;
        public void GetData(string soHDN, string maHang, int soLuong, int donGiaNhap, int giamGia, int thanhTien)
        {
            cboSoHDN.SelectedValue = soHDN;
            cboMaHang.SelectedValue = maHang;
            txtSoLuong.Text = soLuong.ToString();
            txtDonGiaNhap.Text = donGiaNhap.ToString();
            txtGiamGia.Text = giamGia.ToString();
            txtThanhTien.Text = thanhTien.ToString();
        }



        public frmChiTietHoaDonNhap()
        {
            InitializeComponent();
            getData = GetData;
        }



        public void LoadSoHDN()
        {
            HoaDonNhapBLL bll = new HoaDonNhapBLL();
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            list = bll.GetAll();
            cboSoHDN.DataSource = list;
            cboSoHDN.DisplayMember = "SoHDN";
            cboSoHDN.ValueMember = "SoHDN";
        }

        public void LoadMaHang()
        {
            DanhMucHangHoaBLL bll = new DanhMucHangHoaBLL();
            List<DanhMucHangHoa> list = new List<DanhMucHangHoa>();
            list = bll.GetAll();
            cboMaHang.DataSource = list;
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
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

        ChiTietHoaDonNhapBLL bll = new ChiTietHoaDonNhapBLL();
        ChiTietHoaDonNhap obj = new ChiTietHoaDonNhap();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMaHang.Text != string.Empty && cboSoHDN.Text != string.Empty)
                {
                    obj.SoHDN = cboSoHDN.SelectedValue.ToString();
                    obj.MaHang = cboMaHang.SelectedValue.ToString();
                    obj.SoLuong = int.Parse(txtSoLuong.Text);
                    obj.DonGiaNhap = int.Parse(txtDonGiaNhap.Text);
                    obj.GiamGia = txtGiamGia.Text == string.Empty ? 0 : int.Parse(txtGiamGia.Text);
                    obj.ThanhTien = obj.SoLuong*obj.DonGiaNhap-obj.GiamGia;
                    if (Common.state == 0)
                    {
                        if (bll.Insert(obj))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            //if (bll.UpdateSoLuong(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                            //if (bll.UpdateGiaNhapBan(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                        }
                        else
                        {
                            MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                        }
                        Clear();
                        cboSoHDN.Focus();
                        cboMaHang.Focus();
                    }
                    else
                    {
                        if (bll.Update(obj))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                            //if (bll.UpdateSoLuong(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                            //if (bll.UpdateGiaNhapBan(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                        }

                        else
                            MessageBox.Show("Lỗi cập nhật!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        Clear();
                        cboSoHDN.Focus();
                        cboMaHang.Focus();
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

        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadSoHDN();
            LoadMaHang();
        }
    }
}
