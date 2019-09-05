using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCoreop.Models;

namespace MvcCoreop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Data()
        {
            DataViewModel model = new DataViewModel();
            List<Record> records = new List<Record>();
            model.Datas = records;
            Random random = new Random();
            for (int i = 1; i <= 50; i++)
            {
               records.Add(new Record
               {
                  Seq = i,
                  Date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                  Category = "支出",
                  Price = random.Next(1, 2000)
               }); 
            }
            return PartialView(model);
        }

    }
}