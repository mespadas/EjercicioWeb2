using EjercicioWeb.BO;
using EjercicioWeb.DAL;
using EjercicioWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb3.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            UserAdminViewModel model = new UserAdminViewModel();
            return View(model);
        }

        public ActionResult Buscar(UserAdminViewModel model)
        {
            List<UserBO> users = UserDAO.GetUsers(model.Busqueda);
            foreach(UserBO user in users)
            {
                model.Usuarios.Add(new UserViewModel() {
                    Id = user.Id,
                    Nombre = user.Nombre + " " + user.Apellido,
                    FechaCreacion = user.FechaCreacion.ToString(),
                    NombreRol = user.Rol.Nombre,
                    Email = user.Email
                });
            }
            return View("Index", model);
        }

        public ActionResult AgregarUsuario()
        {
            UserViewModel model = new UserViewModel();
            PopularCampos(model);
            return View("Form", model);
        }

        public ActionResult EditarUsuario(int Id)
        {
            UserViewModel model = new UserViewModel();
            PopularCampos(model);
            return View("Form", model);
        }

        public ActionResult GuardarUsuario(UserViewModel model)
        {
            if (model.Contrasena != model.ConfirmarContrasena)
            {
                ViewBag.Mensaje = "Las contraseñas no coinciden";
                PopularCampos(model);
                return View("Form", model);
            }

            UserBO userBO = new UserBO();
            if (model.Id > 0)
            {
                userBO = UserDAO.GetUser(model.Id);
            }
            userBO.Nombre = model.Nombre;
            userBO.Email = model.Email;
            userBO.Contrasena = model.Contrasena;
            userBO.Telefono = model.TelefonoMovil;
            userBO.Rol = new RoleBO() { Id = model.RolId };

            UserDAO.SaveUser(userBO);
            
            return Index();
        }

        private void PopularCampos(UserViewModel model)
        {
            List<RoleBO> roles = RolDAO.GetRoles();
            foreach(var rol in roles)
            {
                model.Roles.Add(new SelectListItem() { Text = rol.Nombre, Value = rol.Id.ToString() });
            }
        }

    }
}