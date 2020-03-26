using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PandaBook.Controllers;

namespace PandaBook.Controllers
{
    public class BookController : Controller
    {
        // GET: Bookhome
        public ViewResult Index()
        {
            
            ViewBag.Title = "Book Recomending website";
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            return View();

        }


        public string Book(int id)
        {
            BookModel bookmodel = new BookModel();
            bookmodel.BookName = "Harry Potter";
            bookmodel.DatePublished = DateTime.Now;
            bookmodel.GenereId = 2;
            bookmodel.Author = "asd";
            bookmodel.ISBN = "5ewd324d";
            bookmodel.ShortDescription = "Harry Harry Harry";

            return "Book: Id = " + id.ToString();
        }

        public RedirectResult Redirectbook()
        {
            return RedirectPermanent("~/Book/index");
        }



        public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime DatePublished { get; set; }

        public int GenereId { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string ShortDescription { get; set; }

       
        }

    }


}