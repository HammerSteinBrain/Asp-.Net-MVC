using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult teste()
        {
            return View("Pagina1");
            //return View("Index");
        }
    }
}