using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DAL
{
   public  class ChatLieuDAL
    {
        DBLib db = null;

        public List<ChatLieu> GetAll()
        {
            List<ChatLieu> list = new List<ChatLieu>();
            DataTable table = new DataTable();
            db = new DBLib();
            try
            {
                table = db.FillDataTable("sp_SelectChatLieu", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    ChatLieu obj = new ChatLieu();
                    obj.MaChatLieu = dr[0].ToString();
                    obj.TenChatLieu = dr[1].ToString();
                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return list;
        }

        public bool Insert(ChatLieu obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaChatLieu", obj.MaChatLieu);
                db.AddParameter("@TenChatLieu", obj.TenChatLieu);
                records = db.ExecuteNonQuery("sp_InsertChatLieu", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Delete(ChatLieu obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaChatLieu", obj.MaChatLieu);
                records = db.ExecuteNonQuery("sp_DeleteChatLieu", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }

        public bool Update(ChatLieu obj)
        {
            bool records;
            try
            {
                db = new DBLib();
                db.AddParameter("@MaChatLieu", obj.MaChatLieu);
                db.AddParameter("@TenChatLieu", obj.TenChatLieu);
                records = db.ExecuteNonQuery("sp_UpdateChatLieu", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }
            return records;
        }
    }
}
