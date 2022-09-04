using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;



namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {

        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public List<About> TGetAll()
        {
          
                return _aboutDAL.GetAll();
        }

        public About TGetById(int id)
        {
            return _aboutDAL.GetbyID(id);
        }

        public void TInsert(About t)
        {
            _aboutDAL.Insert(t);
        }

        public void TRemove(About t)
        {
            _aboutDAL.Remove(t);
        }

        public void TUpdate(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}
