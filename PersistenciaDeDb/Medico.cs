namespace PersistenciaDeDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medico")]
    public partial class Medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medico()
        {
            Citas = new HashSet<Cita>();
            Consultorios = new HashSet<Consultorio>();
        }

        public int MedicoId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(13)]
        public string Cedula { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModificacion { get; set; }

        public bool? Status { get; set; }

        [StringLength(24)]
        public string Telefono { get; set; }

        [StringLength(24)]
        public string Correo { get; set; }

        public int? ProvinciaId { get; set; }

        public int? SectorId { get; set; }

        [StringLength(30)]
        public string Especialidad { get; set; }

        public int? Edad { get; set; }

        [StringLength(20)]
        public string EstadoCivil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultorio> Consultorios { get; set; }
    }
}
