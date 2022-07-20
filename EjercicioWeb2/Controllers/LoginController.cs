using EjercicioWeb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb2.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginViewModel model = new LoginViewModel();
            model.Usuario = "Anónimo";
            return View(model);
        }

        public ActionResult DoLogin(LoginViewModel model)
        {
            string username = model.Usuario;
            string password = model.Contrasena;

            if (username == "admin" && password == "1234")
            {
                return RedirectToAction("Index", "Home", new { nombre = username });
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}