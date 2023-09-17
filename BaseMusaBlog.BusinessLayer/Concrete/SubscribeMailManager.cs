using BaseMusaBlog.DataAccessLayer.Concrete;
using BaseMusaBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        GenericRepository<SubscribeMail> subscribeMailRepository = new GenericRepository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            if(p.Mail.Length <= 5|| p.Mail.Length >= 50)
            {
                return -1;
            }
            return subscribeMailRepository.Insert(p);
        }
    }
}
