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
    public partial class frmLoaiHangList : Form
    {
        LoaiHangBLL bll = new LoaiHangBLL();

        public frmLoaiHangList()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            List<LoaiHang> list = new List<LoaiHang>();
            try
            {
                list = bll.GetAll();
                dgvLoaiHangList.DataSource = list;
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
            frmLoaiHang frm = new frmLoaiHang();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maLoai = dgvLoaiHangList.CurrentRow.Cells[0].Value.ToString();
            string maNhom = dgvLoaiHangList.CurrentRow.Cells[1].Value.ToString();
            string tenLoai = dgvLoaiHangList.CurrentRow.Cells[2].Value.ToString();
            frmLoaiHang frm = new frmLoaiHang();
            frm.Show();
            frm.GetData(maLoai, maNhom, tenLoai);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiHang obj = new LoaiHang();
            obj.MaLoai = dgvLoaiHangList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmLoaiHangList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
