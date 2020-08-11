using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryPasantias2020.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Acceder()
        {
            return View("Login");
        }
        public ActionResult Registrarse()
        {
            return View("Register");
        }
        public ActionResult RegistrarseAdmin()
        {
            return View("RegisterAdmin");
        }
    }
}
