using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class KhachHangDAL
    {

        DBLib db = null;

        public List<KhachHang> GetAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectKhachHang", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    KhachHang obj = new KhachHang();
                    obj.MaKhach = dr[0].ToString();
                    obj.TenKhach = dr[1].ToString();
                    obj.DienThoai = dr[2].ToString();
                    obj.DiaChi = dr[3].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(KhachHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaKhach", obj.MaKhach  );
                db.AddParameter("@TenKhach", obj.TenKhach);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                 records = db.ExecuteNonQuery("sp_InsertKhachHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(KhachHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaKhach", obj.MaKhach);
                 records = db.ExecuteNonQuery("sp_DeleteKhachHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(KhachHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaKhach", obj.MaKhach);
                db.AddParameter("@TenKhach", obj.TenKhach);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                 records = db.ExecuteNonQuery("sp_UpdateKhachHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
