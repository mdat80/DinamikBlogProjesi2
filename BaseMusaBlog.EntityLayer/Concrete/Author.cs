using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [StringLength(50)]
        public string AuthorName { get; set; }
        [StringLength(100)]
        public string AuthorImage { get; set; }
        public string AuthorAbout { get; set; }

        [StringLength(100)]
        public string AuthorTitle { get; set; }

        [StringLength(100)]
        public string AuthorAboutShort { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(24)]
        public string PhoneNumber { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
