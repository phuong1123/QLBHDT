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
    public partial class frmChiTietHoaDonBanList : Form
    {
        public frmChiTietHoaDonBanList()
        {
            InitializeComponent();
        }

        ChiTietHoaDonBanBLL bll = new ChiTietHoaDonBanBLL();

        public void LoadData()
        {
            List<ChiTietHoaDonBan> list = new List<ChiTietHoaDonBan>();
            try
            {
                list = bll.GetAll();
                dgvChiTietHoaDonBanList.DataSource = list;
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
            frmChiTietHoaDonBan frm = new frmChiTietHoaDonBan();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string soHDB = dgvChiTietHoaDonBanList.CurrentRow.Cells[0].Value.ToString();
            string maHang = dgvChiTietHoaDonBanList.CurrentRow.Cells[1].Value.ToString();
            int soLuong = (int) dgvChiTietHoaDonBanList.CurrentRow.Cells[2].Value;
            int giamGia = (int)dgvChiTietHoaDonBanList.CurrentRow.Cells[3].Value;
            int thanhTien = (int)dgvChiTietHoaDonBanList.CurrentRow.Cells[4].Value;
            frmChiTietHoaDonBan frm = new frmChiTietHoaDonBan();
            frm.Show();
            frm.GetData(soHDB, maHang, soLuong, giamGia,thanhTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan obj = new ChiTietHoaDonBan();
            obj.SoHDB = dgvChiTietHoaDonBanList.CurrentRow.Cells[0].Value.ToString();
            obj.MaHang = dgvChiTietHoaDonBanList.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmChiTietHoaDonNhapList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
