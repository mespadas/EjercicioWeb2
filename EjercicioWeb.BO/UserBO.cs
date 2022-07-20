using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWeb.BO
{
    [Table("usuarios")]
    public class UserBO
    {
        [Column("id", TypeName = "int")]
        public int Id { set; get;  }
        [Column("nombre")]
        public string Nombre { set; get; }
        [Column("apellido")]
        public string Apellido { set; get; }
        [Column("email")]
        public string Email { set; get; }
        [Column("telefono")]
        public string Telefono { set; get; }
        [Column("contrasena")]
        public string Contrasena { set; get; }
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { set; get; }
        public RoleBO Rol { set; get; }
    }
}
