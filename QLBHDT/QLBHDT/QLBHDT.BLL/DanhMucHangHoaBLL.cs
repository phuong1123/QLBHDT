using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class DanhMucHangHoaBLL
    {
        DanhMucHangHoaDAL dal = new DanhMucHangHoaDAL();
        public List<DanhMucHangHoa> GetAll()
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

        public bool Insert(DanhMucHangHoa obj)
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

        public bool Update(DanhMucHangHoa obj)
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

        public bool Delete(DanhMucHangHoa obj)
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


        //public bool UpdateSoLuong(DanhMucHangHoa obj)
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


        //public bool UpdateGiaNhapBan(DanhMucHangHoa obj)
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
