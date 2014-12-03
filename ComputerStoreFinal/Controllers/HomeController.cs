using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStoreFinal.Controllers
{
    //test comment for Git testing
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn what Bananas Computer Store is all about";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please feel free to contact us via any of the following methods";

            return View();
        }
    }
}