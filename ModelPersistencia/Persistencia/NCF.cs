namespace Persistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCF")]
    public partial class NCF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NCF()
        {
            Facturas = new HashSet<Factura>();
        }

        public int NCFId { get; set; }

        [Required]
        [StringLength(6)]
        public string CodigoNCF { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(6)]
        public string Prefijo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Secuencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UltimoNCF { get; set; }

        [StringLength(80)]
        public string Aviso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Modulo { get; set; }

        [StringLength(1)]
        public string TipoNCF { get; set; }

        public bool? RNC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor { get; set; }

        public DateTime? Fvencimiento { get; set; }

        public bool Status { get; set; }
        [Required]
        public int UsuarioId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
