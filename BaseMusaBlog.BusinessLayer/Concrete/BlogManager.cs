using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class BlogManager
    {
        GenericRepository<Blog> blogRepository = new GenericRepository<Blog>();
        Blog blog = new Blog();
        public List<Blog> GetAll()
        {
            return blogRepository.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return blogRepository.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return blogRepository.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return blogRepository.List(x => x.CategoryID == id);
        }
        public int AddBlogBL(Blog P)
        {
            if(P.BlogTitle =="" || P.BlogImage == "" || P.BlogContent == "")
            {
                return -1;
            }
            return blogRepository.Insert(P);
        }
        public int DeleteBlogBL(int id)
        {
            blog = blogRepository.FindAndDeleteUpdate(x => x.BlogID == id);
            return blogRepository.Delete(blog);
        }
        public Blog FindUpdateBlogBL(int id)
        {
            return  blogRepository.FindAndDeleteUpdate(x => x.BlogID == id);            
        }
        public int UpdateBlogBL(Blog p)
        {
            blog = blogRepository.FindAndDeleteUpdate(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;           
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.AuthorID = p.AuthorID;
            blog.CategoryID = p.CategoryID;
            return blogRepository.Update(blog);
        }
    }
}
