using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.Models.Dtos
{
  public  class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int UsuarioCreador { get; set; }
        public bool Status { get; set; }
        public string Correo { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        public string SandForPassword { get; set; }
    }
}
