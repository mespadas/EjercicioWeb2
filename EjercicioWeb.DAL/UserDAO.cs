using EjercicioWeb.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.DAL
{
    public class UserDAO
    {
        public static List<UserBO> GetUsers(string termino)
        {
            var DaoContext = new DAOContext();
            var users = DaoContext.Users;
            return users.ToList();
        }
        public static UserBO GetUser(int id)
        {
            var DaoContext = new DAOContext();
            return DaoContext.Users.Find(id);
        }

        public static UserBO SaveUser(UserBO userBO)
        {
            var DaoContext = new DAOContext();
            DaoContext.Users.Add(userBO);
            DaoContext.SaveChanges();
            return userBO;
        }
    }
}
