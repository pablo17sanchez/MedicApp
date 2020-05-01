using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
   public  class Documentos
    {
        [Key]
        public int DocumentoId { get; set; }

        public string CodigoDocumento { get; set; }

  
        public string Nombre { get; set; }

 
        public decimal? Tipo { get; set; }

 
        public decimal? Modulo { get; set; }


        public decimal? Secuencia { get; set; }

        public bool? Status { get; set; }

       
        public string Titulo1 { get; set; }

     
        public string Titulo2 { get; set; }

  
        public string Titulo3 { get; set; }


        public string Titulo4 { get; set; }


        public string Titulo5 { get; set; }

        public int? ConsultorioId { get; set; }

        public decimal? Factor { get; set; }

        public DateTime? Fcreacion { get; set; }

        public DateTime? Fmodificacion { get; set; }
    }
}
