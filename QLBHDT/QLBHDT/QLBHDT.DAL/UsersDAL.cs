using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
    public class UsersDAL
    {
        DBLib db = null;

        public List<Users> GetAll()
        {
            List<Users> list = new List<Users>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectUsers", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    Users obj = new Users();
                    obj.MaNhanVien = dr[0].ToString();
                    obj.Password = dr[1].ToString();
                    obj.Active = (int)dr[2];
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }



        public bool Insert(Users obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@Password", obj.Password);
                db.AddParameter("@Active", obj.Active);
                records = db.ExecuteNonQuery("sp_InsertUsers", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(Users obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                records = db.ExecuteNonQuery("sp_DeleteUsers", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(Users obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaNhanVien", obj.MaNhanVien);
                db.AddParameter("@Password", obj.Password);
                db.AddParameter("@Active", obj.Active);
                records = db.ExecuteNonQuery("sp_UpdateUsers", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }


        //public bool DangNhap(string maNhanVien, string password)
        //{
        //    bool records = false;
        //    try
        //    {
        //        db = new DBLib();
        //        DataTable table = new DataTable();
        //        string[] arrPara = new string[2] { "@MaNhanVien", "@Password" };
        //        object[] arrValue = new object[2] { maNhanVien, password };
        //        SqlDbType[] arrDbType = new SqlDbType[2] { SqlDbType.VarChar, SqlDbType.VarChar};
        //        table = db.FillDataTable("sp_DangNhap", CommandType.StoredProcedure,
        //            arrPara, arrValue, arrDbType);
        //        if (table.Rows.Count > 0)
        //            records = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return records;
        //}
    }
}
