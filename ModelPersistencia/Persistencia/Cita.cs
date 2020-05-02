namespace Persistencia
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

   
            public bool Status { get; set; }

            public DateTime? FCreacion { get; set; }

            public DateTime? FModiciacion { get; set; }
            [Required]
            public int UsuarioId { get; set; }
            public virtual Medico Medico { get; set; }
        
            public virtual Paciente Paciente { get; set; }
    }
}
