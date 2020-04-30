namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cita
    {
        [Key]
        public int CitasId { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int MedicoId { get; set; }

        public int IdPaciente { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModiciacion { get; set; }

        public virtual Medico Medico { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
