using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb3.Models
{
    public class UserAdminViewModel
    {
        public UserAdminViewModel()
        {
            Usuarios = new List<UserViewModel>();
        }
        public string Busqueda { set; get; }
        public IList<UserViewModel> Usuarios { set; get; }
    }

    public class UserViewModel
    {
        public UserViewModel()
        {
            Roles = new List<SelectListItem>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public string Apellidos { get; set; }
        
        public string Email { get; set; }

        public string TelefonoMovil { get; set; }

        public string Contrasena { get; set; }
       
        public string ConfirmarContrasena { get; set; }
        public string FechaCreacion { get; set; }

        public int RolId { get; set; }

        public string NombreRol { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}