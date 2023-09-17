using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> 
    {
        List<T> List();
        T GetByID(int id);
        List<T> List(Expression<Func<T,bool>> filter);
        T FindAndDeleteUpdate(Expression<Func<T,bool>> filter);
        int Insert(T P);
        int Update(T P);
        int Delete(T P);
    }
}
