using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class CaLamDAL
    {
        DBLib db = null;

        public List<CaLam> GetAll()
        {
            List<CaLam> list = new List<CaLam>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectCaLam", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    CaLam obj = new CaLam();
                    obj.MaCa = dr[0].ToString();
                    obj.TenCa = dr[1].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }



        public bool Insert(CaLam obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCa", obj.MaCa);
                db.AddParameter("@TenCa", obj.TenCa  );
                 records = db.ExecuteNonQuery("sp_InsertCaLam", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(CaLam obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCa", obj.MaCa);
                records = db.ExecuteNonQuery("sp_DeleteCaLam", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(CaLam obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaCa", obj.MaCa);
                db.AddParameter("@TenCa", obj.TenCa);
                records = db.ExecuteNonQuery("sp_UpdateCaLam", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
