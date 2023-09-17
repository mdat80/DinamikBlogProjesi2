using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class CommentManager
    {
        GenericRepository<Comment> commentRepository = new GenericRepository<Comment>();
        Comment comment = new Comment();
        public List<Comment> CommentList()
        {
            return commentRepository.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return commentRepository.List(x => x.BlogID == id);
        }
        //Durumu true olan mesajları getir
        public List<Comment> CommentByStatusTrue()
        {
            return commentRepository.List(x => x.CommentStatus == true);
        }
        //Durumu false olan mesajları getir
        public List<Comment> CommentByStatusFalse()
        {
            return commentRepository.List(x => x.CommentStatus == false);
        }
        public int CommentAdd(Comment p)
        {
            if (p.UserName == "" || p.Mail == "" || p.CommentText == "")
            {
                return -1;
            }        
            return commentRepository.Insert(p);
        }
        //Durumu true olan mesajları kaldır false yap
        public int CommentStatusChangeToFalse(int id)
        {
            comment = commentRepository.FindAndDeleteUpdate(x => x.CommentID == id);
            comment.CommentStatus = false;
            return commentRepository.Update(comment);
        }
        //Durumu false olan mesajları kaldır true yap
        public int CommentStatusChangeToTrue(int id)
        {
            comment = commentRepository.FindAndDeleteUpdate(x => x.CommentID == id);
            comment.CommentStatus = true;
            return commentRepository.Update(comment);
        }
    }
}
