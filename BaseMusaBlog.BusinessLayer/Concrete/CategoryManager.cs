using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> categoryRepository = new GenericRepository<Category>();
        Category category=new Category();
        public List<Category> GetAll()
        {
            return categoryRepository.List();
        }

        public int AdminCategoryAddBL(Category P)
        {
            if (P.CategoryName == "" || P.CategoryDescription == "")
            {
                return -1;
            }
            return categoryRepository.Insert(P);
        }
        public Category FindEditCategoryBL(int id)
        {
            return categoryRepository.FindAndDeleteUpdate(x => x.CategoryID == id);
        }
        public int FindEditCategoryBL(Category p)
        {
            category = categoryRepository.FindAndDeleteUpdate(x => x.CategoryID == p.CategoryID);
            category.CategoryName = p.CategoryName;
            category.CategoryDescription = p.CategoryDescription;
                  
            return categoryRepository.Update(category);
        }

        public int AdminPassiveCategoryBL(int id)
        {
            category = categoryRepository.FindAndDeleteUpdate(x => x.CategoryID == id);          
            category.CategoryStatus = false;
            return categoryRepository.Update(category);
        }
        public int AdminActiveCategoryBL(int id)
        {
            category = categoryRepository.FindAndDeleteUpdate(x => x.CategoryID == id);
            category.CategoryStatus = true;
            return categoryRepository.Update(category);
        }
    }
}
