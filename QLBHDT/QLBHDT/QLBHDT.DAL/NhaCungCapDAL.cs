using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class NhaCungCapDAL
    {
        DBLib db = null;

        public List<NhaCungCap> GetAll()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectNhaCungCap", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    NhaCungCap obj = new NhaCungCap();
                    obj.MaNCC = dr[0].ToString();
                    obj.TenNCC = dr[1].ToString();
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

        public bool Insert(NhaCungCap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNCC", obj.MaNCC);
                db.AddParameter("@TenNCC", obj.TenNCC);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                 records = db.ExecuteNonQuery("sp_InsertNhaCungCap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(NhaCungCap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNCC", obj.MaNCC);
                 records = db.ExecuteNonQuery("sp_DeleteNhaCungCap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }


        public bool Update(NhaCungCap obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNCC", obj.MaNCC);
                db.AddParameter("@TenNCC", obj.TenNCC);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                 records = db.ExecuteNonQuery("sp_UpdateNhaCungCap", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
