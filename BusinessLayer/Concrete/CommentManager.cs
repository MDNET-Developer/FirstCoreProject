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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public List<Comment> GetListByID(int id)
        {
            return _commentDAL.GetAll(x => x.BlogID == id);
        }

        public List<Comment> TGetAll()
        {
            return _commentDAL.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _commentDAL.GetbyID(id);
        }

        public void TInsert(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public void TRemove(Comment t)
        {
            _commentDAL.Remove(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDAL.Update(t);
        }
    }
}
