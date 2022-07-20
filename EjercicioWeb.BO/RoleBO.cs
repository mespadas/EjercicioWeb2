using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.BO
{
    [Table("roles")]
    public class RoleBO
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
    }
}
