using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
   public  class LoaiHangDAL
    {
        DBLib db = null;

        public List<LoaiHang> GetAll()
        {
            List<LoaiHang> list = new List<LoaiHang>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectLoaiHang", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    LoaiHang obj = new LoaiHang();
                    obj.MaLoai = dr[0].ToString();
                    obj.MaNhom = dr[1].ToString();
                    obj.TenLoai = dr[2].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(LoaiHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaLoai", obj.MaLoai);
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@TenLoai", obj.TenLoai);
               records = db.ExecuteNonQuery("sp_InsertLoaiHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(LoaiHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaLoai", obj.MaLoai);
                records = db.ExecuteNonQuery("sp_DeleteLoaiHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(LoaiHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaLoai", obj.MaLoai);
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@TenLoai", obj.TenLoai);
                records = db.ExecuteNonQuery("sp_UpdateLoaiHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
