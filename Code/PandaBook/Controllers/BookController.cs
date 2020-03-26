using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandaBook.Controllers
{
    public class BookController : Controller
    {
        // GET: Bookhome
        public ViewResult Index()
        {
            
            ViewBag.Title = "The shop";
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            return View();

        }


        public string Product(int id)
        {
            return "Product: Id = " + id.ToString();
        }
    }

   


}