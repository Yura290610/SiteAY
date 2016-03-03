using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteAY.Models;

namespace SiteAY.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult FavouriteBooks()
        {
            var book = List_of_books.CreateBooks();

            return View(book);
        }
    }
}