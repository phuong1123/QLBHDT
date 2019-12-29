using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class NhanVienDAL
    {
        DBLib db = null;

        public List<NhanVien> GetAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectNhanVien", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    NhanVien obj = new NhanVien();
                    obj.MaNhanVien = dr[0].ToString();
                    obj.TenNhanVien = dr[1].ToString();
                    obj.GioiTinh = dr[2].ToString();
                    obj.NgaySinh = (DateTime)dr[3]; 
                    obj.DienThoai = dr[4].ToString();
                    obj.DiaChi = dr[5].ToString();
                    obj.MaCa = dr[6].ToString();
                    obj.MaCongViec = dr[7].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(NhanVien obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@TenNhanVien", obj.TenNhanVien);
                db.AddParameter("@GioiTinh", obj.GioiTinh);
                db.AddParameter("@NgaySinh", obj.NgaySinh);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                db.AddParameter("@MaCa", obj.MaCa);
                db.AddParameter("@MaCongViec", obj.MaCongViec);
                records = db.ExecuteNonQuery("sp_InsertNhanVien", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(NhanVien obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                 records = db.ExecuteNonQuery("sp_DeleteNhanVien", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(NhanVien obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@TenNhanVien", obj.TenNhanVien);
                db.AddParameter("@GioiTinh", obj.GioiTinh);
                db.AddParameter("@NgaySinh", obj.NgaySinh);
                db.AddParameter("@DienThoai", obj.DienThoai);
                db.AddParameter("@DiaChi", obj.DiaChi);
                db.AddParameter("@MaCa", obj.MaCa);
                db.AddParameter("@MaCongViec", obj.MaCongViec);
                records = db.ExecuteNonQuery("sp_UpdateNhanVien", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
