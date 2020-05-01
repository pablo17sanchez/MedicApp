using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class Consultorio
    {    [Key]
        public int ConsultorioId { get; set; }
        public string NombreConsultorio { get; set; }
        public int MedicoId { get; set; }
        public DateTime? FCreacion { get; set; }
        public DateTime? FModiciacion { get; set; } = DateTime.Now;
        public bool? Status { get; set; }
        public string Telefono { get; set; }
    }
}
