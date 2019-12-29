using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class LoaiHangBLL
    {
        LoaiHangDAL dal = new LoaiHangDAL();
        public List<LoaiHang> GetAll()
        {          

            try
            {
                return dal.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Insert(LoaiHang obj)
        {
            
            try
            {
                return dal.Insert(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Update(LoaiHang obj)
        {
            
            try
            {
                return dal.Update(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Delete(LoaiHang obj)
        {           
            try
            {
                return dal.Delete(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
