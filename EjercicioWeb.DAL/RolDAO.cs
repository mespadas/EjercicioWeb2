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
            var DaoContext = new DAOContext();
            var roles = DaoContext.Roles;
            return roles.ToList();
        }

        public static RoleBO GetRole(int id)
        {
            var DaoContext = new DAOContext();
            return DaoContext.Roles.Find(id);
        }
    }
}
