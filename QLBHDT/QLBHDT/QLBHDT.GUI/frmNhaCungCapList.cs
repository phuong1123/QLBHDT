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
    public partial class frmNhaCungCapList : Form
    {
        public frmNhaCungCapList()
        {
            InitializeComponent();
        }


        NhaCungCapBLL bll = new NhaCungCapBLL();

        public void LoadData()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            try
            {
                list = bll.GetAll();
                dgvNhaCungCapList.DataSource = list;
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
            frmNhaCungCap frm = new frmNhaCungCap();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maNCC = dgvNhaCungCapList.CurrentRow.Cells[0].Value.ToString();
            string tenNCC = dgvNhaCungCapList.CurrentRow.Cells[1].Value.ToString();
            string dienThoai = dgvNhaCungCapList.CurrentRow.Cells[2].Value.ToString();
            string diaChi = dgvNhaCungCapList.CurrentRow.Cells[3].Value.ToString();
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.Show();
            frm.GetData(maNCC, tenNCC, dienThoai, diaChi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCap obj = new NhaCungCap();
            obj.MaNCC = dgvNhaCungCapList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmNhaCungCapList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
