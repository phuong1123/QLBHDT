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
    public partial class frmCaLamList : Form
    {
        public frmCaLamList()
        {
            InitializeComponent();
        }

        CaLamBLL bll = new CaLamBLL();

        public void LoadData()
        {
            List<CaLam> list = new List<CaLam>();
            try
            {
                list = bll.GetAll();
                dgvCaLamList.DataSource = list;
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
            frmCaLam frm = new frmCaLam();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maCa = dgvCaLamList.CurrentRow.Cells[0].Value.ToString();
            string tenCa = dgvCaLamList.CurrentRow.Cells[1].Value.ToString();
            frmCaLam frm = new frmCaLam();
            frm.Show();
            frm.GetData(maCa, tenCa);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CaLam obj = new CaLam();
            obj.MaCa = dgvCaLamList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }

        private void frmCaLamList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
