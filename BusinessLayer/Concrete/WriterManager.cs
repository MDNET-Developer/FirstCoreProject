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
    public class WriterManager : IWriterService
    {
        IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public List<Writer> TGetAll()
        {
            return _writerDAL.GetAll();
        }

        public Writer TGetById(int id)
        {
            return _writerDAL.GetbyID(id);
        }

        public void TInsert(Writer t)
        {
            _writerDAL.Insert(t);
        }

        public void TRemove(Writer t)
        {
            _writerDAL.Remove(t);
        }

        public void TUpdate(Writer t)
        {
            _writerDAL.Update(t);
        }
    }
}
