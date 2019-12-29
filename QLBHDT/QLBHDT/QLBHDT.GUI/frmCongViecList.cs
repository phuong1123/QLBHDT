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
    public partial class frmCongViecList : Form
    {
        public frmCongViecList()
        {
            InitializeComponent();
        }

        CongViecBLL bll = new CongViecBLL();

        public void LoadData()
        {
            List<CongViec> list = new List<CongViec>();
            try
            {
                list = bll.GetAll();
                dgvCongViecList.DataSource = list;
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
            frmCongViec frm = new frmCongViec();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maCongViec = dgvCongViecList.CurrentRow.Cells[0].Value.ToString();
            string tenCongViec = dgvCongViecList.CurrentRow.Cells[1].Value.ToString();
            frmCongViec frm = new frmCongViec();
            frm.Show();
            frm.GetData(maCongViec, tenCongViec);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CongViec obj = new CongViec();
            obj.MaCongViec = dgvCongViecList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmCongViecList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
