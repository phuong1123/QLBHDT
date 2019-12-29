using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class HoaDonBanDAL
    {
        DBLib db = null;

        public List<HoaDonBan> GetAll()
        {
            List<HoaDonBan> list = new List<HoaDonBan>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectHoaDonBan", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    HoaDonBan obj = new HoaDonBan();
                    obj.SoHDB = dr[0].ToString();
                    obj.MaNhanVien = dr[1].ToString();
                    obj.NgayBan = (DateTime) dr[2];
                    obj.MaKhach = dr[3].ToString();
                    obj.TongTien = (int) dr[4];
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(HoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@NgayBan", obj.NgayBan);
                db.AddParameter("@MaKhach", obj.MaKhach);
                db.AddParameter("@TongTien", obj.TongTien);
                 records = db.ExecuteNonQuery("sp_InsertHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(HoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                 records = db.ExecuteNonQuery("sp_DeleteHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(HoaDonBan obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@SoHDB", obj.SoHDB);
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@NgayBan", obj.NgayBan);
                db.AddParameter("@MaKhach", obj.MaKhach);
                db.AddParameter("@TongTien", obj.TongTien);
                 records = db.ExecuteNonQuery("sp_UpdateHoaDonBan", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
