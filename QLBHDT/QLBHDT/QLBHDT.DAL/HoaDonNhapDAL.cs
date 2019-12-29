using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class HoaDonNhapDAL
    {
        DBLib db = null;

        public List<HoaDonNhap> GetAll()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectHoaDonNhap", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    HoaDonNhap obj = new HoaDonNhap();
                    obj.SoHDN = dr[0].ToString();
                    obj.MaNhanVien = dr[1].ToString();
                    obj.NgayNhap = (DateTime) dr[2];
                    obj.MaNCC = dr[3].ToString();
                    obj.TongTien = (int)dr[4];
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(HoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@NgayNhap", obj.NgayNhap);
                db.AddParameter("@MaNCC", obj.MaNCC);
                db.AddParameter("@TongTien", obj.TongTien);
                return records = db.ExecuteNonQuery("sp_InsertHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool Delete(HoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                return records = db.ExecuteNonQuery("sp_DeleteHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool Update(HoaDonNhap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDN", obj.SoHDN);
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@NgayNhap", obj.NgayNhap);
                db.AddParameter("@MaNCC", obj.MaNCC);
                db.AddParameter("@TongTien", obj.TongTien);
                return records = db.ExecuteNonQuery("sp_UpdateHoaDonNhap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
