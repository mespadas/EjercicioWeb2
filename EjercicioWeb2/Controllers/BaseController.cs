using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb2.Controllers
{
    public class BaseController : Controller
    {
        //metodos reutilizables
        public string GetUserInSession()
        {
            return "test";
        }
    }
}