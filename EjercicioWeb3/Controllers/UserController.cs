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
            model.Busqueda = "";
            return Buscar(model);
        }

        public ActionResult Buscar(UserAdminViewModel model)
        {
            List<UserBO> users = UserDAO.GetUsers(model.Busqueda);
            foreach(UserBO user in users)
            {
                model.Usuarios.Add(new UserViewModel() {
                    Id = user.Id,
                    Nombre = user.Nombre + " " + user.Apellido,
                    FechaCreacion = user.FechaCreacion.ToString("dd/MM/yyyy hh:mm"),
                    NombreRol = user.Rol?.Nombre,
                    TelefonoMovil = user.Telefono,
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
            UserBO user = UserDAO.GetUser(Id);
            UserViewModel model = new UserViewModel
            {
                Id = user.Id,
                Nombre = user.Nombre,
                Apellidos = user.Apellido,
                Email = user.Email,
                TelefonoMovil = user.Telefono,
                Contrasena = user.Contrasena,
                ConfirmarContrasena = user.Contrasena,
                RolId = user.RolId
            };
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

            // Realizamos la logica de negocio
            UserBO userBO = new UserBO();
            //RoleBO roleBO = RolDAO.GetRole(model.RolId);
            if (model.Id > 0)
            {
                userBO = UserDAO.GetUser(model.Id);
            }
            else
            {
                userBO.FechaCreacion = DateTime.Now;
                userBO.Contrasena = model.Contrasena;
            }

            userBO.Nombre = model.Nombre;
            userBO.Apellido = model.Apellidos;
            userBO.Email = model.Email;
            userBO.Telefono = model.TelefonoMovil;
            userBO.RolId = model.RolId;
            //userBO.Rol = roleBO;

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