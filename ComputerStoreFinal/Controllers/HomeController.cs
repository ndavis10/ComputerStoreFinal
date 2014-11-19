using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStoreFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn about our company and what we are about";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us a number of different ways";

            return View();
        }
    }
}