namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consultorio")]
    public partial class Consultorio
    {
        public int ConsultorioId { get; set; }

        [StringLength(50)]
        public string NombreConsultorio { get; set; }

        public int MedicoId { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModiciacion { get; set; }

        public bool? Status { get; set; }

        [StringLength(24)]
        public string Telefono { get; set; }

        public virtual Medico Medico { get; set; }
    }
}
