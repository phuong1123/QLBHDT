using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class HoaDonNhapBLL
    {
        HoaDonNhapDAL dal;
        public List<HoaDonNhap> GetAll()
        {
            dal = new HoaDonNhapDAL();

            try
            {
                return dal.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Insert(HoaDonNhap
            obj)
        {
            dal = new HoaDonNhapDAL();
            try
            {
                return dal.Insert(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Update(HoaDonNhap obj)
        {
            dal = new HoaDonNhapDAL();
            try
            {
                return dal.Update(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Delete(HoaDonNhap obj)
        {
            dal = new HoaDonNhapDAL();
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
