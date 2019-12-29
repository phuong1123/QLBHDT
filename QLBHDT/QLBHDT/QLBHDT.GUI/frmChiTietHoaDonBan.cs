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
    public partial class frmChiTietHoaDonBan : Form
    {
        public Action<string, string,int, int,int> getData;
        public void GetData(string soHDB, string maHang, int soLuong, int giamGia, int thanhTien)
        {
            cboSoHDB.SelectedValue = soHDB;
            cboMaHang.SelectedValue = maHang;
            txtSoLuong.Text = soLuong.ToString();
            txtGiamGia.Text = giamGia.ToString();
            txtThanhTien.Text = thanhTien.ToString();
        }



        public frmChiTietHoaDonBan()
        {
            InitializeComponent();
            getData = GetData;
        }



        public void LoadSoHDB()
        {
            HoaDonBanBLL bll = new HoaDonBanBLL();
            List<HoaDonBan> list = new List<HoaDonBan>();
            list = bll.GetAll();
            cboSoHDB.DataSource = list;
            cboSoHDB.DisplayMember = "SoHDB";
            cboSoHDB.ValueMember = "SoHDB";
        }

        public void LoadMaHang()
        {
            DanhMucHangHoaBLL bll = new DanhMucHangHoaBLL();
            List<DanhMucHangHoa> list = new List<DanhMucHangHoa>();
            list = bll.GetAll();
            cboMaHang.DataSource = list;
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
        }


        public event EventHandler Button_Clicked;

        private void Clear()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        ChiTietHoaDonBanBLL bll = new ChiTietHoaDonBanBLL();
        ChiTietHoaDonBan obj = new ChiTietHoaDonBan();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text != string.Empty && txtThanhTien.Text != string.Empty)
                {
                    obj.SoHDB = cboSoHDB.SelectedValue.ToString();
                    obj.MaHang = cboMaHang.SelectedValue.ToString();
                    obj.SoLuong = int.Parse(txtSoLuong.Text);
                    obj.GiamGia = txtGiamGia.Text == string.Empty ? 0 : int.Parse(txtGiamGia.Text);
                    obj.ThanhTien = int.Parse(txtThanhTien.Text);
                    if (Common.state == 0)
                    {
                        if (bll.Insert(obj))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            //if (bll.UpdateSoLuong(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                        }
                        else
                        {
                            MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                        }
                        Clear();
                        cboSoHDB.Focus();
                        cboMaHang.Focus();
                    }
                    else
                    {
                        if (bll.Update(obj))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                            //if (bll.UpdateSoLuong(obj))
                            //{
                            //    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                            //        MessageBoxIcon.Information);

                            //}
                            //else
                            //{
                            //    MessageBox.Show("Lỗi lưu!", "Thông báo", MessageBoxButtons.OK,
                            //      MessageBoxIcon.Error);
                            //}

                        }

                        else
                            MessageBox.Show("Lỗi cập nhật!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        Clear();
                        cboSoHDB.Focus();
                        cboMaHang.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            if (Button_Clicked != null)
            {

                Button_Clicked(sender, e);
            }

            
        }

        private void frmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadSoHDB();
            LoadMaHang();
        }
    }
}
