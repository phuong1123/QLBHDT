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
    public partial class frmKhachHangList : Form
    {
        public frmKhachHangList()
        {
            InitializeComponent();
        }

        KhachHangBLL bll = new KhachHangBLL();

        public void LoadData()
        {
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                list = bll.GetAll();
                dgvKhachHangList.DataSource = list;
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
            frmKhachHang frm = new frmKhachHang();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maKhach = dgvKhachHangList.CurrentRow.Cells[0].Value.ToString();
            string tenKhach = dgvKhachHangList.CurrentRow.Cells[1].Value.ToString();
            string dienThoai = dgvKhachHangList.CurrentRow.Cells[2].Value.ToString();
            string diaChi = dgvKhachHangList.CurrentRow.Cells[3].Value.ToString();
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
            frm.GetData(maKhach, tenKhach, dienThoai, diaChi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang obj = new KhachHang();
            obj.MaKhach = dgvKhachHangList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmKhachHangList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
