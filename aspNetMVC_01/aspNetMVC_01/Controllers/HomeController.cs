using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspNetMVC_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Sobre() {
            return View("Sobre");
        }

        public ActionResult Menu() {
            return PartialView("Menu");
        }
    }
}