namespace Persistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        [Key]

        public int ServicioId { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreServicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ITBIS { get; set; }

        [Required]
        [StringLength(80)]
        public string NombreProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Precio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tipo { get; set; }

        [StringLength(60)]
        public string Parametro { get; set; }

        [StringLength(60)]
        public string Referencia { get; set; }
        public bool Status { get; set; }

        public DateTime? Fcreacion { get; set; }

        public DateTime? Fmodificacion { get; set; }
        [Required]
        public int UsuarioId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
