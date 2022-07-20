using EjercicioWeb.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.DAL
{
    public class RolDAO
    {
        public static List<RoleBO> GetRoles()
        {
            //TODO: acceder a la bd
            List<RoleBO> roles = new List<RoleBO>
            {
                new RoleBO() { Nombre = "Administrador", Id = 1 },
                new RoleBO() { Nombre = "Operador", Id = 2 },
                new RoleBO() { Nombre = "Solo Lectura", Id = 3 }
            };
            return roles;
        }
    }
}
