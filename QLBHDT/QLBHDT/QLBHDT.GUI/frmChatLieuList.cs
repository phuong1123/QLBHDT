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
    public partial class frmChatLieuList : Form
    {
        public frmChatLieuList()
        {
            InitializeComponent();
        }

        ChatLieuBLL bll = new ChatLieuBLL();

        public void LoadData()
        {
            List<ChatLieu> list = new List<ChatLieu>();
            try
            {
                list = bll.GetAll();
                dgvChatLieuList.DataSource = list;
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
            frmChatLieu frm = new frmChatLieu();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maChatLieu = dgvChatLieuList.CurrentRow.Cells[0].Value.ToString();
            string tenChatLieu = dgvChatLieuList.CurrentRow.Cells[1].Value.ToString();
            frmChatLieu frm = new frmChatLieu();
            frm.Show();
            frm.GetData(maChatLieu, tenChatLieu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChatLieu obj = new ChatLieu();
            obj.MaChatLieu = dgvChatLieuList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }


        private void frmChatLieuList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
