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
    public partial class frmChiTietHoaDonNhapList : Form
    {
        public frmChiTietHoaDonNhapList()
        {
            InitializeComponent();
        }

        ChiTietHoaDonNhapBLL bll = new ChiTietHoaDonNhapBLL();

        public void LoadData()
        {
            List<ChiTietHoaDonNhap> list = new List<ChiTietHoaDonNhap>();
            try
            {
                list = bll.GetAll();
                dgvChiTietHoaDonNhapList.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Common.state = 0;
            frmChiTietHoaDonNhap frm = new frmChiTietHoaDonNhap();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string soHDN = dgvChiTietHoaDonNhapList.CurrentRow.Cells[0].Value.ToString();
            string maHang = dgvChiTietHoaDonNhapList.CurrentRow.Cells[1].Value.ToString();
            int soLuong = int.Parse(dgvChiTietHoaDonNhapList.CurrentRow.Cells[2].Value.ToString());
            int donGiaNhap = int.Parse(dgvChiTietHoaDonNhapList.CurrentRow.Cells[3].Value.ToString());
            int giamGia = int.Parse(dgvChiTietHoaDonNhapList.CurrentRow.Cells[4].Value.ToString());
            int thanhTien = int.Parse(dgvChiTietHoaDonNhapList.CurrentRow.Cells[5].Value.ToString());
            frmChiTietHoaDonNhap frm = new frmChiTietHoaDonNhap();
            frm.Show();
            frm.GetData(soHDN, maHang, soLuong, donGiaNhap, giamGia, thanhTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonNhap obj = new ChiTietHoaDonNhap();
            obj.SoHDN = dgvChiTietHoaDonNhapList.CurrentRow.Cells[0].Value.ToString();
            obj.MaHang = dgvChiTietHoaDonNhapList.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmChiTietHoaDonBanList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
