using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class Servicios
    {

        [Key]
        public string ServicioId { get; set; }


        public string NombreServicio { get; set; }


        public decimal? ITBIS { get; set; }


        public string NombreProducto { get; set; }


        public decimal Precio { get; set; }


        public decimal Tipo { get; set; }


        public string Parametro { get; set; }


        public string Referencia { get; set; }

        public DateTime? Fcreacion { get; set; }

        public DateTime? Fmodificacion { get; set; } = DateTime.Now;
    }
}
