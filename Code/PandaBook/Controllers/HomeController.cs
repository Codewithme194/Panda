using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandaBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return redirectBook();
        }
        public RedirectResult redirectBook()
        {
            return RedirectPermanent("~/Book/index");
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