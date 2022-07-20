using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb2.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index(string nombre)
        {
            ViewBag.nombre = nombre;
            GetUserInSession();
            return View("Index");
        }       
    }
}