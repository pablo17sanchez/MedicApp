namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Documentos")]
    public partial class Documento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documento()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
            Facturas = new HashSet<Factura>();
            Historicoes = new HashSet<Historico>();
        }

        public int DocumentoId { get; set; }

        [Required]
        [StringLength(6)]
        public string CodigoDocumento { get; set; }

        [StringLength(60)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Modulo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Secuencia { get; set; }

        public bool? Status { get; set; }

        [StringLength(80)]
        public string Titulo1 { get; set; }

        [StringLength(80)]
        public string Titulo2 { get; set; }

        [StringLength(80)]
        public string Titulo3 { get; set; }

        [StringLength(80)]
        public string Titulo4 { get; set; }

        [StringLength(80)]
        public string Titulo5 { get; set; }

        public int? ConsultorioId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Factor { get; set; }

        public DateTime? Fcreacion { get; set; }

        public DateTime? Fmodificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico> Historicoes { get; set; }
    }
}
