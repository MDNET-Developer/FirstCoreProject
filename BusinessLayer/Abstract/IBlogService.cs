using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService:IGenericService<Blog>
    {
         List<Blog> ListBlogWithCategory();
        List<Blog> GetBlogListByID(int id);
    }
}
