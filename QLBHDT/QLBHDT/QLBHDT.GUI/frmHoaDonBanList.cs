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
    public partial class frmHoaDonBanList : Form
    {
        public frmHoaDonBanList()
        {
            InitializeComponent();
        }

        HoaDonBanBLL bll = new HoaDonBanBLL();

        public void LoadData()
        {
            List<HoaDonBan> list = new List<HoaDonBan>();
            try
            {
                list = bll.GetAll();
                dgvHoaDonBanList.DataSource = list;
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
            frmHoaDonBan frm = new frmHoaDonBan();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string soHDB = dgvHoaDonBanList.CurrentRow.Cells[0].Value.ToString();
            string maNhanVien = dgvHoaDonBanList.CurrentRow.Cells[1].Value.ToString();
            DateTime ngayBan = (DateTime) dgvHoaDonBanList.CurrentRow.Cells[2].Value;
            string maKhach = dgvHoaDonBanList.CurrentRow.Cells[3].Value.ToString();
            int tongTien = (int) dgvHoaDonBanList.CurrentRow.Cells[4].Value;
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
            frm.GetData(soHDB, maNhanVien, ngayBan, maKhach, tongTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonBan obj = new HoaDonBan();
            obj.SoHDB = dgvHoaDonBanList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmHoaDonBanList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
