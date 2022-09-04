using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Bootcamp.Controllers
{
    public class MainController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogDAL());
        public IActionResult Index()
        {
            var blogs = blogManager.ListBlogWithCategory();
            return View(blogs);
        }

        public IActionResult BlogDetail(int id)
        {
            ViewBag.GetID = id;
            var detallar =  blogManager.GetBlogListByID(id);
            return View(detallar);
        }
    }
}
