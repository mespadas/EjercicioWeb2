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
            var DaoContext = DAOContextFactory.GetDAOContext();
            return DaoContext.Roles.ToList();
        }

        public static RoleBO GetRole(int id)
        {
            var DaoContext = DAOContextFactory.GetDAOContext();
            return DaoContext.Roles.Find(id);
        }
    }
}
