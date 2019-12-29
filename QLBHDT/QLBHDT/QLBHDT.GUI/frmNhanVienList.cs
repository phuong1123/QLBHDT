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
    public partial class frmNhanVienList : Form
    {
        public frmNhanVienList()
        {
            InitializeComponent();
        }

        NhanVienBLL bll = new NhanVienBLL();

        public void LoadData()
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                list = bll.GetAll();
                dgvNhanVienList.DataSource = list;
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
            frmNhanVien frm = new frmNhanVien();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maNhanVien = dgvNhanVienList.CurrentRow.Cells[0].Value.ToString();
            string tenNhanVien = dgvNhanVienList.CurrentRow.Cells[1].Value.ToString();
            bool gioiTinh = (dgvNhanVienList.CurrentRow.Cells[2].Value.ToString() == "Nam" ? true :false);
            DateTime ngaySinh = (DateTime)dgvNhanVienList.CurrentRow.Cells[3].Value;
            string dienThoai = dgvNhanVienList.CurrentRow.Cells[4].Value.ToString();
            string diaChi = dgvNhanVienList.CurrentRow.Cells[5].Value.ToString();
            string maCa = dgvNhanVienList.CurrentRow.Cells[6].Value.ToString();
            string maCongViec = dgvNhanVienList.CurrentRow.Cells[7].Value.ToString();
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
            frm.GetData(maNhanVien, tenNhanVien, gioiTinh, ngaySinh, dienThoai, diaChi, maCa, maCongViec);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien obj = new NhanVien();
            obj.MaNhanVien = dgvNhanVienList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmNhanVienList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
