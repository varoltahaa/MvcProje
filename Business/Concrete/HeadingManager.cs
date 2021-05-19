﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HeadingManager:IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void Add(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void Delete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public Heading GetByCategoryId(int id)
        {
            return _headingDal.Get(x => x.CategoryId == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public Heading GeyById(int id)
        {
            return _headingDal.Get(x=> x.HeadingId == id);
        }

        public void Update(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
