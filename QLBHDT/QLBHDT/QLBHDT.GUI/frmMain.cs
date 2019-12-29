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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHDB_Click(object sender, EventArgs e)
        {
            frmHoaDonBanList frm = new frmHoaDonBanList();
            frm.Show();
        }

        private void mnuHDN_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapList frm = new frmHoaDonNhapList();
            frm.Show();
        }

        private void mnuCTHDB_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonBanList frm = new frmChiTietHoaDonBanList();
            frm.Show();
        }

        private void mnuCTHDN_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonNhapList frm = new frmChiTietHoaDonNhapList();
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVienList frm = new frmNhanVienList();
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHangList frm = new frmKhachHangList();
            frm.Show();
        }

        private void mnuDMHangHoa_Click(object sender, EventArgs e)
        {
            frmDanhMucHangHoaList frm = new frmDanhMucHangHoaList();
            frm.Show();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCapList frm = new frmNhaCungCapList();
            frm.Show();
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            frmCongViecList frm = new frmCongViecList();
            frm.Show();
        }

        private void mnuCaLam_Click(object sender, EventArgs e)
        {
            frmCaLamList frm = new frmCaLamList();
            frm.Show();
        }

        private void mnuNuocSX_Click(object sender, EventArgs e)
        {
            frmNuocSanXuatList frm = new frmNuocSanXuatList();
            frm.Show();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmChatLieuList frm = new frmChatLieuList();
            frm.Show();
        }

        private void mnuDonViTinh_Click(object sender, EventArgs e)
        {
            frmDonViTinhList frm = new frmDonViTinhList();
            frm.Show();
        }

        private void mnuLoaiHang_Click(object sender, EventArgs e)
        {
            frmLoaiHangList frm = new frmLoaiHangList();
            frm.Show();
        }

        private void mnuNhomHang_Click(object sender, EventArgs e)
        {
            frmNhomHangList frm = new frmNhomHangList();
            frm.Show();
        }
    }
}
