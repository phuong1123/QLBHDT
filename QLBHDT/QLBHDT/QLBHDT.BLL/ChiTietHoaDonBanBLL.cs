using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class ChiTietHoaDonBanBLL
    {
        ChiTietHoaDonBanDAL dal = new ChiTietHoaDonBanDAL();
        public List<ChiTietHoaDonBan> GetAll()
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

        public bool Insert(ChiTietHoaDonBan obj)
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

        public bool Update(ChiTietHoaDonBan obj)
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

        public bool Delete(ChiTietHoaDonBan obj)
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


        //public bool UpdateSoLuong(ChiTietHoaDonBan obj)
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


        //public bool UpdateGiaNhapBan(ChiTietHoaDonBan obj)
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
