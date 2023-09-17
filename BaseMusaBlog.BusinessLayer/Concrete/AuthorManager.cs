using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class AuthorManager
    {
        GenericRepository<Author> authorRepository = new GenericRepository<Author>();
        Author author = new Author();
        public List<Author> GetAll()
        {
            return authorRepository.List();
        }
        public int AddAuthorBL(Author P)
        {
            if (P.AuthorName == "" || P.AuthorAbout == "" || P.AuthorAboutShort == ""
                || P.AuthorTitle== "" || P.EmailAddress == "")
            {
                return -1;
            }
            return authorRepository.Insert(P);
        }
        public Author FindeEditAuthorBL(int id)
        {
            return authorRepository.FindAndDeleteUpdate(x => x.AuthorID == id);
        }
        public int FindeEditAuthorBL(Author p)
        {
            author = authorRepository.FindAndDeleteUpdate(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorAboutShort = p.AuthorAboutShort;
            author.EmailAddress = p.EmailAddress;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;          
            return authorRepository.Update(author);
        }
    }
}
