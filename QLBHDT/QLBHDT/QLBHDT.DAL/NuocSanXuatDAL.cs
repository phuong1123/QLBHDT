using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class NuocSanXuatDAL
    {
        DBLib db = null;

        public List<NuocSanXuat> GetAll()
        {
            List<NuocSanXuat> list = new List<NuocSanXuat>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectNuocSanXuat", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    NuocSanXuat obj = new NuocSanXuat();
                    obj.MaNuocSanXuat = dr[0].ToString();
                    obj.TenNuocSanXuat = dr[1].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(NuocSanXuat obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNuocSanXuat", obj.MaNuocSanXuat);
                db.AddParameter("@TenNuocSanXuat", obj.TenNuocSanXuat);
                 records = db.ExecuteNonQuery("sp_InsertNuocSanXuat", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(NuocSanXuat obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNuocSanXuat", obj.MaNuocSanXuat);
                 records = db.ExecuteNonQuery("sp_DeleteNuocSanXuat", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(NuocSanXuat obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNuocSanXuat", obj.MaNuocSanXuat);
                db.AddParameter("@TenNuocSanXuat", obj.TenNuocSanXuat);
                 records = db.ExecuteNonQuery("sp_UpdateNuocSanXuat", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
