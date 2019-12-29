using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class NhomHangDAL
    {
        DBLib db = null;

        public List<NhomHang> GetAll()
        {
            List<NhomHang> list = new List<NhomHang>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectNhomHang", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    NhomHang obj = new NhomHang();
                    obj.MaNhom = dr[0].ToString();
                    obj.TenNhom = dr[1].ToString();
                    obj.CongDung = dr[2].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(NhomHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@TenNhom", obj.TenNhom);
                db.AddParameter("@CongDung", obj.CongDung);
                 records = db.ExecuteNonQuery("sp_InsertNhomHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
       
        public bool Delete(NhomHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhom", obj.MaNhom);
                records = db.ExecuteNonQuery("sp_DeleteNhomHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
        
        public bool Update(NhomHang obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhom", obj.MaNhom);
                db.AddParameter("@TenNhom", obj.TenNhom);
                db.AddParameter("@CongDung", obj.CongDung);
                records = db.ExecuteNonQuery("sp_UpdateNhomHang", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
