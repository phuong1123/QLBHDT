using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class ChiTietHoaDonNhapDAL
    {
        DBLib db = null;

        public List<ChiTietHoaDonNhap> GetAll()
        {
            List<ChiTietHoaDonNhap> list = new List<ChiTietHoaDonNhap>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectChiTietHoaDonNhap", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    ChiTietHoaDonNhap obj = new ChiTietHoaDonNhap();
                    obj.SoHDN = dr[0].ToString();
                    obj.MaHang = dr[1].ToString();
                    obj.SoLuong = (int)dr[2];
                    obj.DonGiaNhap = (int)dr[3];
                    obj.GiamGia = (int)dr[4];
                    obj.ThanhTien = (int)dr[5];
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(ChiTietHoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@DonGiaNhap", obj.DonGiaNhap);
                db.AddParameter("@GiamGia", obj.GiamGia);
                db.AddParameter("@ThanhTien", obj.ThanhTien);
                 records = db.ExecuteNonQuery("sp_InsertChiTietHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        //public bool UpdateSoLuong(ChiTietHoaDonNhap obj)
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



        //public bool UpdateGiaNhapBan(ChiTietHoaDonNhap obj)
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



        public bool Delete(ChiTietHoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                db.AddParameter("@MaHang", obj.MaHang);
                 records = db.ExecuteNonQuery("sp_DeleteChiTietHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(ChiTietHoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@DonGiaNhap", obj.DonGiaNhap);
                db.AddParameter("@GiamGia", obj.GiamGia);
                db.AddParameter("@ThanhTien", obj.ThanhTien);
                 records = db.ExecuteNonQuery("sp_UpdateChiTietHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
             
        }
    }
}
