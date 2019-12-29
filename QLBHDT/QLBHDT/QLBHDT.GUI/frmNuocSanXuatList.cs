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
    public partial class frmNuocSanXuatList : Form
    {
        public frmNuocSanXuatList()
        {
            InitializeComponent();
        }

        NuocSanXuatBLL bll = new NuocSanXuatBLL();

        public void LoadData()
        {
            List<NuocSanXuat> list = new List<NuocSanXuat>();
            try
            {
                list = bll.GetAll();
                dgvNuocSanXuatList.DataSource = list;
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
            frmNuocSanXuat frm = new frmNuocSanXuat();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maNuocSX = dgvNuocSanXuatList.CurrentRow.Cells[0].Value.ToString();
            string tenNuocSX = dgvNuocSanXuatList.CurrentRow.Cells[1].Value.ToString();
            frmNuocSanXuat frm = new frmNuocSanXuat();
            frm.Show();
            frm.GetData(maNuocSX, tenNuocSX);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NuocSanXuat obj = new NuocSanXuat();
            obj.MaNuocSanXuat = dgvNuocSanXuatList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmNuocSanXuatList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
