using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class AboutManager
    {
        GenericRepository<About> aboutRepository = new GenericRepository<About>();
        About about = new About();
        public List<About> GetAll()
        {
            return aboutRepository.List();
        }
        public int UpdateAboutBL(About P)
        {
            about = aboutRepository.FindAndDeleteUpdate(x => x.AboutID == P.AboutID);
            about.AboutContent1 = P.AboutContent1;
            about.AboutContent2 = P.AboutContent2;
            about.AboutImage1 = P.AboutImage1;
            about.AboutImage2 = P.AboutImage2;
            return aboutRepository.Update(about);
        }
    }
}
