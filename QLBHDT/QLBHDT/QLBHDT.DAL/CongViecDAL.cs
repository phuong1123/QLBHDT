using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class CongViecDAL
    {
        DBLib db = null;

        public List<CongViec> GetAll()
        {
            List<CongViec> list = new List<CongViec>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectCongViec", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    CongViec obj = new CongViec();
                    obj.MaCongViec = dr[0].ToString();
                    obj.TenCongViec = dr[1].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(CongViec obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCongViec", obj.MaCongViec);
                db.AddParameter("@TenCongViec", obj.TenCongViec);
                 records = db.ExecuteNonQuery("sp_InsertCongViec", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(CongViec obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCongViec", obj.MaCongViec);
                 records = db.ExecuteNonQuery("sp_DeleteCongViec", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(CongViec obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCongViec", obj.MaCongViec);
                db.AddParameter("@TenCongViec", obj.TenCongViec);
                 records = db.ExecuteNonQuery("sp_UpdateCongViec", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
