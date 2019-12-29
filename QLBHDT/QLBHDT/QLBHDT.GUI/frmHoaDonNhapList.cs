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
    public partial class frmHoaDonNhapList : Form
    {
        public frmHoaDonNhapList()
        {
            InitializeComponent();
        }


        HoaDonNhapBLL bll = new HoaDonNhapBLL();

        public void LoadData()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            try
            {
                list = bll.GetAll();
                dgvHoaDonNhapList.DataSource = list;
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
            frmHoaDonNhap frm = new frmHoaDonNhap();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string soHDB = dgvHoaDonNhapList.CurrentRow.Cells[0].Value.ToString();
            string maNhanVien = dgvHoaDonNhapList.CurrentRow.Cells[1].Value.ToString();
            DateTime ngayNhap = (DateTime)dgvHoaDonNhapList.CurrentRow.Cells[2].Value;
            string maNCC = dgvHoaDonNhapList.CurrentRow.Cells[3].Value.ToString();
            int tongTien = (int)dgvHoaDonNhapList.CurrentRow.Cells[4].Value;
            frmHoaDonNhap frm = new frmHoaDonNhap();
            frm.Show();
            frm.GetData(soHDB, maNhanVien, ngayNhap, maNCC, tongTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonNhap obj = new HoaDonNhap();
            obj.SoHDN = dgvHoaDonNhapList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmHoaDonNhapList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
