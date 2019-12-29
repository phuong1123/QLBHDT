using QLBHDT.DAL;
using QLBHDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.BLL
{
    public class DonViTinhBLL
    {
        DonViTinhDAL dal = new DonViTinhDAL();
        public List<DonViTinh> GetAll()
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

        public bool Insert(DonViTinh obj)
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

        public bool Update(DonViTinh obj)
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

        public bool Delete(DonViTinh obj)
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
