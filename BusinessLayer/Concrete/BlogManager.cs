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
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public List<Blog> GetBlogListByID(int id)
        {
            return _blogDAL.GetAll(x => x.BloqID == id);
            
        }

        public List<Blog> ListBlogWithCategory()
        {
            return _blogDAL.ListBlogWithCategory();
        }

        public List<Blog> TGetAll()
        {
            return _blogDAL.GetAll();
        }

        public Blog TGetById(int id)
        {
            return _blogDAL.GetbyID(id);
        }

        public void TInsert(Blog t)
        {
            _blogDAL.Insert(t);
        }

        public void TRemove(Blog t)
        {
            _blogDAL.Remove(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDAL.Update(t);
        }
    }
}
