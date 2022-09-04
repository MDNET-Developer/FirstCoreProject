using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public List<Contact> TGetAll()
        {
            return _contactDAL.GetAll();        
        }

        public Contact TGetById(int id)
        {
            return _contactDAL.GetbyID(id);
        }

        public void TInsert(Contact t)
        {
            _contactDAL.Insert(t);
        }

        public void TRemove(Contact t)
        {
            _contactDAL.Remove(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDAL.Update(t);
        }
    }
}
