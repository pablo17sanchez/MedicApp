namespace Persistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            Citas = new HashSet<Cita>();
            Facturas = new HashSet<Factura>();
            Historicoes = new HashSet<Historico>();
        }

        [Key]
        public int IdPaciente { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fnacimiento { get; set; }

        public bool Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fmodificacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fcreacion { get; set; }

        [StringLength(13)]
        public string Cedula { get; set; }

        [StringLength(24)]
        public string Telefono { get; set; }

        [StringLength(90)]
        public string Direccion { get; set; }

        public int ProvinciaId { get; set; }

        public int SectorId { get; set; }
    
        public int ARSId { get; set; }

        [StringLength(10)]
        public string TipoSangre { get; set; }

        [Required]
        [StringLength(20)]
        public string Genero { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Imagen { get; set; }

        [Required]
        [StringLength(100)]
        public string Alergico { get; set; }

        [StringLength(80)]
        public string Ocupacion { get; set; }

        [StringLength(20)]
        public string EstadoCivil { get; set; }

        [StringLength(15)]
        public string Peso { get; set; }

        [StringLength(20)]
        public string Estatura { get; set; }

        public bool? Fuma { get; set; }

        public bool? Bebe { get; set; }

        [StringLength(20)]
        public string Lat { get; set; }

        [StringLength(20)]
        public string Log { get; set; }

        [StringLength(20)]
        public string NoAfiliadoARS { get; set; }

        [StringLength(15)]
        public string NombreContacto { get; set; }

        [StringLength(15)]
        public string TelefonoContacto { get; set; }
        [Required]
        public int UsuarioId { get; set; }

        public virtual AR AR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }

        public virtual DetalleFactura DetalleFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico> Historicoes { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
