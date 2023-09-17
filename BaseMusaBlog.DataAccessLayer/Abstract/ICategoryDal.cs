using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericRepository<Category>
    {
    }
}
