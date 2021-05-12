using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje.Controllers;
using Entity.Concrete;

namespace MvcProje.Controllers
{
    public class StatisticsController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryDal() );
        WriterManager wm = new WriterManager(new EfWriterDal() );
        HeadingManager hm = new HeadingManager(new EfHeadingDal() );
 

        // GET: Statistics
        public ActionResult Index()
        {
            var value1 = cm.GetList().Distinct().Count().ToString();
            ViewBag.value2 = value1;

            var value2 = hm.GetList().Count(x => x.CategoryId == 12).ToString();
            ViewBag.value3 = value2;

            var value3 = wm.GetList().Where(x=> x.WriterName.Contains("a")).Count().ToString();
            ViewBag.value4 = value3;

            var value4 = hm.GetList().GroupBy(x => x.Category.CategoryName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.value5 = value4;

            var value5 = cm.GetList().Count(x => x.CategoryStatus == true).ToString();
            ViewBag.value6 = value5;

            var value6 = cm.GetList().Count(x => x.CategoryStatus == false).ToString();
            ViewBag.value7 = value6;

            return View();
        }
    }
}