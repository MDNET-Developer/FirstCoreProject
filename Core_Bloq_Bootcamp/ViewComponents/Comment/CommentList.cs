using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Bootcamp.ViewComponents.Comment
{
    public class CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());
        public IViewComponentResult Invoke(int id)
        {
            
            var deyerler = commentManager.GetListByID(id);
            return View(deyerler);
        }
    }
}
