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
    public partial class frmDonViTinhList : Form
    {      

        public frmDonViTinhList()
        {
            InitializeComponent();
        }

        DonViTinhBLL bll = new DonViTinhBLL();

        public void LoadData()
        {
            List<DonViTinh> list = new List<DonViTinh>();
            try
            {
                list = bll.GetAll();
                dgvDonViTinhList.DataSource = list;
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
            frmDonViTinh frm = new frmDonViTinh();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maDonVi = dgvDonViTinhList.CurrentRow.Cells[0].Value.ToString();
            string tenDonVi = dgvDonViTinhList.CurrentRow.Cells[1].Value.ToString();
            frmDonViTinh frm = new frmDonViTinh();
            frm.Show();
            frm.GetData(maDonVi, tenDonVi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DonViTinh obj = new DonViTinh();
            obj.MaDonVi = dgvDonViTinhList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmDonViTinhList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
