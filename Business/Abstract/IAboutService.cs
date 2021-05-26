using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void Add(About about);
        About GetById(int id);
        void Delete(About about);
        void Update(About about);
    }
}
