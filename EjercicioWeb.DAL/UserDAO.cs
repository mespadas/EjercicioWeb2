using EjercicioWeb.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.DAL
{
    public class UserDAO
    {
        public static List<UserBO> GetUsers(string termino)
        {
            var DaoContext = DAOContextFactory.GetDAOContext();
            if (!String.IsNullOrWhiteSpace(termino))
            {
                var users = from u in DaoContext.Users
                            where (u.Nombre.ToUpper().Contains(termino) 
                                || u.Apellido.ToUpper().Contains(termino) 
                                || u.Email.ToUpper().Contains(termino))
                            select u;
                return users.ToList();
            }
            else
            {
                return DaoContext.Users.ToList();
            }
        }
        public static UserBO GetUser(int id)
        {
            var DaoContext = DAOContextFactory.GetDAOContext();
            return DaoContext.Users.Find(id);
        }

        public static UserBO SaveUser(UserBO userBO)
        {
            var DaoContext = DAOContextFactory.GetDAOContext();
            if (userBO.Id == 0)
            {
                DaoContext.Users.Add(userBO);
            }
            else
            {
                DaoContext.Entry(userBO).State = EntityState.Modified;
            }
            DaoContext.SaveChanges();
            return userBO;
        }
    }
}
