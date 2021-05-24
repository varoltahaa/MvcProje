using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListById(int id);
        void Add(Content content);
        Content GetById(int id);
        void Delete(Content content);
        void Update(Content content);
    }
}
