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

            TrainingProductViewModel viewModel = new TrainingProductViewModel();


            viewModel.HandleRequest();

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Index(TrainingProductViewModel viewModel)
        {
            viewModel.HandleRequest();
            ModelState.Clear();

            return View(viewModel);
        }
    }
}