using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class ChiTietHoaDonNhapBLL
    {
        ChiTietHoaDonNhapDAL dal = new ChiTietHoaDonNhapDAL();
        public List<ChiTietHoaDonNhap> GetAll()
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

        public bool Insert(ChiTietHoaDonNhap obj)
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

        public bool Update(ChiTietHoaDonNhap obj)
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

        public bool Delete(ChiTietHoaDonNhap obj)
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

        //public bool UpdateSoLuong(ChiTietHoaDonNhap obj)
        //{

        //    try
        //    {
        //        return dal.UpdateSoLuong(obj);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}


        //public bool UpdateGiaNhapBan(ChiTietHoaDonNhap obj)
        //{

        //    try
        //    {
        //        return dal.UpdateGiaNhapBan(obj);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
