namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARS")]
    public partial class AR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AR()
        {
            Facturas = new HashSet<Factura>();
            Pacientes = new HashSet<Paciente>();
        }

        [Key]
        public int ARSId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(26)]
        public string Telefono { get; set; }

        [StringLength(26)]
        public string Contacto { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModificacion { get; set; }

        [StringLength(80)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string RNC { get; set; }

        [StringLength(80)]
        public string Correo { get; set; }

        [StringLength(3)]
        public string CodigoNCF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
