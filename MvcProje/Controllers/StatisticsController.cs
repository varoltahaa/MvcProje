using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class StatisticsController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: Statistics
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult NumberOfCategories()
        {
            var values = cm.GetList().Count();
            return PartialView(values);
        }
    }
}