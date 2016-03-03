using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteAY.Models;

namespace SiteAY.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ViewResult Massage()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Massage(Massager massager)
        {
            
            return View("Thanks", massager);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}