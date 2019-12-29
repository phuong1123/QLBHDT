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
    public partial class frmNhomHangList : Form
    {
        NhomHangBLL bll = new NhomHangBLL();

        public frmNhomHangList()
        {
            InitializeComponent();
        }

        
        public void LoadData()
        {
            List<NhomHang> list = new List<NhomHang>();
            try
            {
                list = bll.GetAll();
                dgvNhomHangList.DataSource = list;
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
            frmNhomHang frm = new frmNhomHang();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void frmNhomHangList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maNhom = dgvNhomHangList.CurrentRow.Cells[0].Value.ToString();
            string tenNhom = dgvNhomHangList.CurrentRow.Cells[1].Value.ToString();
            string congDung = dgvNhomHangList.CurrentRow.Cells[2].Value.ToString();
            frmNhomHang frm = new frmNhomHang();
            frm.Show();
            frm.GetData(maNhom, tenNhom, congDung);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhomHang obj = new NhomHang();
            obj.MaNhom = dgvNhomHangList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }
    }
}
