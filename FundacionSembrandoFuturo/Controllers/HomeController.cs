using FundacionSembrandoFuturo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FundacionSembrandoFuturo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Form(Email email)
        {
           // FundacionSembrandoFuturo.Models.Email.SendingEmail(email.Subject, email.Content, email.Address, email.Name);
            return View("Index");
        }
    
    }
}
