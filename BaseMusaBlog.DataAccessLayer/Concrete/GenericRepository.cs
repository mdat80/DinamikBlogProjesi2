using BaseMusaBlog.DataAccessLayer.Abstract;
using BaseMusaBlog.DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        BlogContext blogContext = new BlogContext();
        DbSet<T> _object;
        public GenericRepository()
        {    
            _object = blogContext.Set<T>();
        }

        public int Delete(T P)
        {
            _object.Remove(P);
            return blogContext.SaveChanges();
        }

        public T FindAndDeleteUpdate(Expression<Func<T, bool>> filter)
        {
            return _object.FirstOrDefault(filter);
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T P)
        {
            _object.Add(P);
            return blogContext.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public int Update(T P)
        {  
            return blogContext.SaveChanges();
        }
    }
}
