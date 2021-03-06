using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void Add(Category category);
        Category GetById(int id);
        void Delete(Category category);
        void Update(Category category);
    }
}
