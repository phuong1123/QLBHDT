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
    public partial class frmHoaDonBan : Form
    {
        public Action<string, string, DateTime,  string, int> getData;
        public void GetData(string soHDB, string maNhanVien, DateTime ngayBan, string maKhach, int tongTien)
        {
            txtSoHDB.Text = soHDB;
            cboMaNhanVien.SelectedValue = maNhanVien;
            dtpNgayBan.Value = ngayBan;
            cboMaKhach.SelectedValue = maKhach;
            txtTongTien.Text = tongTien.ToString();
        }



        public frmHoaDonBan()
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

        public void LoadMaKhach()
        {
            KhachHangBLL bll = new KhachHangBLL();
            List<KhachHang> list = new List<KhachHang>();
            list = bll.GetAll();
            cboMaKhach.DataSource = list;
            cboMaKhach.DisplayMember = "MaKhach";
            cboMaKhach.ValueMember = "MaKhach";
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

        HoaDonBanBLL bll = new HoaDonBanBLL();
        HoaDonBan obj = new HoaDonBan();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoHDB.Text != string.Empty && txtTongTien.Text != string.Empty)
                {
                    obj.SoHDB = txtSoHDB.Text;
                    obj.MaNhanVien = cboMaNhanVien.SelectedValue.ToString();
                    obj.NgayBan = dtpNgayBan.Value;
                    obj.MaKhach = cboMaKhach.SelectedValue.ToString();
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
                        txtSoHDB.Focus();
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
                        txtSoHDB.Focus();
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

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadMaNhanVien();
            LoadMaKhach();
        }
    }
}
