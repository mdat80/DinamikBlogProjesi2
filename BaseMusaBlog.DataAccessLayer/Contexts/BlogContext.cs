using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.DataAccessLayer.Contexts
{
    public class BlogContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SubscribeMail> SubscribeMails { get; set; }
    }
}
