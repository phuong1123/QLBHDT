using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
   public  class DanhMucHangHoaDAL
    {
        DBLib db = null;

        public List<DanhMucHangHoa> GetAll()
        {
            List<DanhMucHangHoa> list = new List<DanhMucHangHoa>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectDanhMucHangHoa", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    DanhMucHangHoa obj = new DanhMucHangHoa();
                    obj.MaHang = dr[0].ToString();
                    obj.TenHang = dr[1].ToString();
                    obj.MaNhom = dr[2].ToString();
                    obj.MaLoai = dr[3].ToString();
                    obj.MaDonVi = dr[4].ToString();
                    obj.MaChatLieu = dr[5].ToString();
                    obj.MaNuocSanXuat = dr[6].ToString();
                    //obj.SoLuong = (int)dr[7];
                    //obj.DonGiaNhap = (int)dr[8];
                    //obj.DonGiaBan = (int)dr[9];
                    obj.SoLuong = dr[7].ToString();
                    obj.DonGiaNhap = dr[8].ToString();
                    obj.DonGiaBan = dr[9].ToString();
                    obj.ThoiGianBaoHanh = dr[10].ToString();
                    obj.Anh = dr[11].ToString();
                    obj.GhiChu = dr[12].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }



        public bool Insert(DanhMucHangHoa obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@TenHang", obj.TenHang);
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@MaLoai", obj.MaLoai);
                db.AddParameter("@MaDonVi", obj.MaDonVi);
                db.AddParameter("@MaChatLieu", obj.MaChatLieu);
                db.AddParameter("@MaNuocSanXuat", obj.MaNuocSanXuat);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@DonGiaNhap", obj.DonGiaNhap);
                db.AddParameter("@DonGiaBan", obj.DonGiaBan);
                db.AddParameter("@ThoiGianBaoHanh", obj.ThoiGianBaoHanh);
                db.AddParameter("@Anh", obj.Anh);
                db.AddParameter("@GhiChu", obj.GhiChu);
                 records = db.ExecuteNonQuery("sp_InsertDanhMucHangHoa", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(DanhMucHangHoa obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaHang", obj.MaHang);
                 records = db.ExecuteNonQuery("sp_DeleteDanhMucHangHoa", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }



        //public bool UpdateSoLuong(DanhMucHangHoa obj)
        //{
        //    bool records;
        //    try
        //    {
        //        db = new DBLib();
        //        db.AddParameter("@MaHang", obj.MaHang);
        //        records = db.ExecuteNonQuery("sp_CapNhatSoLuong", CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Error: " + ex.Message);
        //    }
        //    return records;
        //}



        //public bool UpdateGiaNhapBan(DanhMucHangHoa obj)
        //{
        //    bool records;
        //    try
        //    {
        //        db = new DBLib();
        //        db.AddParameter("@MaHang", obj.MaHang);
        //        records = db.ExecuteNonQuery("sp_CapNhatGiaNhapGiaBan", CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Error: " + ex.Message);
        //    }
        //    return records;
        //}




        public bool Update(DanhMucHangHoa obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@TenHang", obj.TenHang);
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@MaLoai", obj.MaLoai);
                db.AddParameter("@MaDonVi", obj.MaDonVi);
                db.AddParameter("@MaChatLieu", obj.MaChatLieu);
                db.AddParameter("@MaNuocSanXuat", obj.MaNuocSanXuat);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@DonGiaNhap", obj.DonGiaNhap);
                db.AddParameter("@DonGiaBan", obj.DonGiaBan);
                db.AddParameter("@ThoiGianBaoHanh", obj.ThoiGianBaoHanh);
                db.AddParameter("@Anh", obj.Anh);
                db.AddParameter("@GhiChu", obj.GhiChu);
                 records = db.ExecuteNonQuery("sp_UpdateDanhMucHangHoa", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
