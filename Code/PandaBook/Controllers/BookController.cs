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
        public string Index()
        {
            return "book index";
        }


        public string Product(int id)
        {
            return "Product: Id = " + id.ToString();
        }
    }

   


}