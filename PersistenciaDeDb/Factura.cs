namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        public int FacturaId { get; set; }

        public int DocumentoId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NoFactura { get; set; }

        public DateTime? Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Credito { get; set; }

        [StringLength(80)]
        public string Nombre { get; set; }

        public int? IdPaciente { get; set; }

        public int? ARSId { get; set; }

        public int? NCFId { get; set; }

        [StringLength(19)]
        public string RNC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bruto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Impuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Neto { get; set; }

        public int? UsuarioId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Efectivo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tarjeta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cheque { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VarARS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtroPago { get; set; }

        [StringLength(20)]
        public string NoAfiliadoARS { get; set; }

        [StringLength(20)]
        public string NoAutorizacion { get; set; }

        [StringLength(24)]
        public string Telefono { get; set; }

        public DateTime? FvencimientoNCF { get; set; }

        public DateTime? Fcreacion { get; set; }

        public DateTime? Fmodificacion { get; set; }

        public virtual AR AR { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual NCF NCF { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
