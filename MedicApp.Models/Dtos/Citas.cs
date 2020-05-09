using Dapper.Contrib.Extensions;
using System;

namespace MedicApp.Models.Dtos
{
    public class Citas
    {

        [Key]
        public int CitasId { get; set; }


        public string Descripcion { get; set; }

        public int MedicoId { get; set; }

        public int IdPaciente { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; } 


        public bool Status { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime FModiciacion { get; set; } = DateTime.Now;

        public int UsuarioId { get; set; }

    }
}
