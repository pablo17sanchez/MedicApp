using System;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class ARS
    {
        [Key]
        public int ARSId { get; set; }

        
        public string Nombre { get; set; }

  
        public string Telefono { get; set; }

    
        public string Contacto { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModificacion { get; set; }

   
        public string Direccion { get; set; }

        public string RNC { get; set; }

        
        public string Correo { get; set; }


        public string CodigoNCF { get; set; }
        
        public int UsuarioId { get; set; }
        public bool Status { get; set; }
    }
}
