using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class ChiTietHoaDonBanDAL
    {
        DBLib db = null;

        public List<ChiTietHoaDonBan> GetAll()
        {
            List<ChiTietHoaDonBan> list = new List<ChiTietHoaDonBan>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectChiTietHoaDonBan", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    ChiTietHoaDonBan obj = new ChiTietHoaDonBan();
                    obj.SoHDB = dr[0].ToString();
                    obj.MaHang = dr[1].ToString();
                    obj.SoLuong = (int)dr[2];
                    obj.GiamGia = (int)dr[3];
                    obj.ThanhTien = (int)dr[4];
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(ChiTietHoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@GiamGia", obj.GiamGia);
                db.AddParameter("@ThanhTien", obj.ThanhTien);
                 records = db.ExecuteNonQuery("sp_InsertChiTietHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(ChiTietHoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                db.AddParameter("@MaHang", obj.MaHang);
                 records = db.ExecuteNonQuery("sp_DeleteChiTietHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        //public bool UpdateSoLuong(ChiTietHoaDonBan obj)
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



        //public bool UpdateGiaNhapBan(ChiTietHoaDonBan obj)
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



        public bool Update(ChiTietHoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                db.AddParameter("@MaHang", obj.MaHang);
                db.AddParameter("@SoLuong", obj.SoLuong);
                db.AddParameter("@GiamGia", obj.GiamGia);
                db.AddParameter("@ThanhTien", obj.ThanhTien);
                 records = db.ExecuteNonQuery("sp_UpdateChiTietHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
