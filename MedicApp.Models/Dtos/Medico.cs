using System;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime? FCreacion { get; set; }
        public DateTime? FModificacion { get; set; } = DateTime.Now;
        public bool? Status { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int? ProvinciaId { get; set; }
        public int? SectorId { get; set; }
        public string Especialidad { get; set; }
        public int? Edad { get; set; }
        public string EstadoCivil { get; set; }
    }
}
