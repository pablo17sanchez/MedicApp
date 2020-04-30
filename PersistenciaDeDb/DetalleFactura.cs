namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleFactura")]
    public partial class DetalleFactura
    {
        public int DetalleFacturaId { get; set; }

        public int? DocumentoId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NoFactura { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(20)]
        public string ServicioId { get; set; }

        public int? IdPaciente { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Descuento { get; set; }

        public decimal? VarDescuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ITBIS { get; set; }

        public decimal? VarITBIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Factor { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Servicio Servicio { get; set; }
    }
}
