using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaDeDb
{
 public   class Usuario
    {

        [Key]
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}
