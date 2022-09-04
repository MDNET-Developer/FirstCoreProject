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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> TGetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetbyID(id);
        }

        public void TInsert(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TRemove(Category t)
        {
            _categoryDAL.Remove(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
