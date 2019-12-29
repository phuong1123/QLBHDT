using QLBHDT.BLL;
using QLBHDT.DTO;
using QLBHDT.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHDT.GUI
{
    public partial class frmDanhMucHangHoaList : Form
    {
        public frmDanhMucHangHoaList()
        {
            InitializeComponent();
        }


        DanhMucHangHoaBLL bll = new DanhMucHangHoaBLL();

        public void LoadData()
        {
            List<DanhMucHangHoa> list = new List<DanhMucHangHoa>();
            try
            {
                list = bll.GetAll();
                dgvDanhMucHangHoaList.DataSource = list;
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
            frmDanhMucHangHoa frm = new frmDanhMucHangHoa();

            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maHang = dgvDanhMucHangHoaList.CurrentRow.Cells[0].Value.ToString();
            string tenHang = dgvDanhMucHangHoaList.CurrentRow.Cells[1].Value.ToString();
            string maNhom = dgvDanhMucHangHoaList.CurrentRow.Cells[2].Value.ToString();
            string maLoai = dgvDanhMucHangHoaList.CurrentRow.Cells[3].Value.ToString();
            string maDonVi = dgvDanhMucHangHoaList.CurrentRow.Cells[4].Value.ToString();
            string maChatLieu = dgvDanhMucHangHoaList.CurrentRow.Cells[5].Value.ToString();
            string maNuocSanXuat = dgvDanhMucHangHoaList.CurrentRow.Cells[6].Value.ToString();
            //int soLuong = (int)dgvDanhMucHangHoaList.CurrentRow.Cells[7].Value;
            //int donGiaNhap = (int)dgvDanhMucHangHoaList.CurrentRow.Cells[8].Value;
            //int donGiaBan = (int)dgvDanhMucHangHoaList.CurrentRow.Cells[9].Value;
            string soLuong = dgvDanhMucHangHoaList.CurrentRow.Cells[7].Value.ToString();
            string donGiaNhap = dgvDanhMucHangHoaList.CurrentRow.Cells[8].Value.ToString();
            string donGiaBan = dgvDanhMucHangHoaList.CurrentRow.Cells[9].Value.ToString();
            string thoiGianBaoHanh = dgvDanhMucHangHoaList.CurrentRow.Cells[10].Value.ToString();
            string anh = dgvDanhMucHangHoaList.CurrentRow.Cells[11].Value.ToString();
            string ghiChu = dgvDanhMucHangHoaList.CurrentRow.Cells[12].Value.ToString();
            frmDanhMucHangHoa frm = new frmDanhMucHangHoa();
            frm.Show();
            frm.GetData(maHang, tenHang, maNhom, maLoai, maDonVi, maChatLieu,
                        maNuocSanXuat, soLuong, donGiaNhap, donGiaBan, thoiGianBaoHanh, anh, ghiChu);        
        }

     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhMucHangHoa obj = new DanhMucHangHoa();
            obj.MaHang = dgvDanhMucHangHoaList.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Delete(obj);
            }
            LoadData();
        }
           
     
        private void frmDanhMucHangHoaList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
