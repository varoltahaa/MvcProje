using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetList();
        void Add(Message message);
        Message GetById(int id);
        void Delete(Message message);
        void Update(Message message);
    }
}
