namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Historico")]
    public partial class Historico
    {
        public int HistoricoId { get; set; }

        public int? DocumentoId { get; set; }

        public int? IdPaciente { get; set; }

        public DateTime? Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Orden { get; set; }

        [StringLength(250)]
        public string Detalle1 { get; set; }

        [StringLength(250)]
        public string Detalle2 { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
