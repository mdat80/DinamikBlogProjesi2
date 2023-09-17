using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class ContactManager
    {
        GenericRepository<Contact> contactRepository = new GenericRepository<Contact>();
        public int  BLContactAdd(Contact p)
        {
            if (p.Mail == "")
            {
                return -1;
            }
            return contactRepository.Insert(p);
        }
        public List<Contact> GetAll()
        {
            return contactRepository.List();
        }
        public Contact GetContactDetails(int id)
        {
            return contactRepository.FindAndDeleteUpdate(x => x.ContactID == id);
        }
    }
}
