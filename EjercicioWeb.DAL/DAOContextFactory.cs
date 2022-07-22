using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.DAL
{
    public class DAOContextFactory
    {
        private static DAOContext instance;
        protected DAOContextFactory() { }

        public static DAOContext GetDAOContext()
        {
            if (instance==null) instance = new DAOContext();
            return instance;
        }
    }
}
