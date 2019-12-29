using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class DonViTinhDAL
    {
        DBLib db = null;

        public List<DonViTinh> GetAll()
        {
            List<DonViTinh> list = new List<DonViTinh>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectDonViTinh", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    DonViTinh obj = new DonViTinh();
                    obj.MaDonVi = dr[0].ToString();
                    obj.TenDonVi = dr[1].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(DonViTinh obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaDonVi", obj.MaDonVi);
                db.AddParameter("@TenDonVi", obj.TenDonVi);
                records = db.ExecuteNonQuery("sp_InsertDonViTinh", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(DonViTinh obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaDonVi", obj.MaDonVi);
                records = db.ExecuteNonQuery("sp_DeleteDonViTinh", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
           return records;
        }

        public bool Update(DonViTinh obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaDonVi", obj.MaDonVi);
                db.AddParameter("@TenDonVi", obj.TenDonVi);
               records = db.ExecuteNonQuery("sp_UpdateDonViTinh", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
