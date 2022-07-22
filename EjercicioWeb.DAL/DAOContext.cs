using EjercicioWeb.BO;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DAOContext : DbContext
    {
        public DAOContext() : base("MyContext") { }
        public DbSet<RoleBO> Roles { set; get; }
        public DbSet<UserBO> Users { set; get; }
    }
}
