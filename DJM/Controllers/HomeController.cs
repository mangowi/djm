using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJMData;

namespace DJM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            TrainingProductManager manager = new TrainingProductManager();


            return View(manager.Get());
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
    }
}