using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        GenericRepository<Author> userRepository = new GenericRepository<Author>();
        GenericRepository<Blog> blogRepository = new GenericRepository<Blog>();
        Author author = new Author();
        public List<Author> GetAuthorByMail(string p)
        {
            return userRepository.List(x => x.EmailAddress == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return blogRepository.List(x => x.AuthorID == id);
        }

        public int FindeEditAuthorBL(Author p)
        {
            author = userRepository.FindAndDeleteUpdate(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorAboutShort = p.AuthorAboutShort;
            author.EmailAddress = p.EmailAddress;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            return userRepository.Update(author);
        }
    }
}
