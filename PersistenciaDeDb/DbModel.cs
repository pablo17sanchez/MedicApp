namespace PersistenciaDeDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<AR> ARS { get; set; }
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Consultorio> Consultorios { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Historico> Historicoes { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<NCF> NCFs { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AR>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.RNC)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .Property(e => e.CodigoNCF)
                .IsUnicode(false);

            modelBuilder.Entity<AR>()
                .HasMany(e => e.Pacientes)
                .WithRequired(e => e.AR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Consultorio>()
                .Property(e => e.NombreConsultorio)
                .IsUnicode(false);

            modelBuilder.Entity<Consultorio>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.NoFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.ServicioId)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.Cantidad)
                .HasPrecision(16, 2);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.Precio)
                .HasPrecision(16, 2);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.VarDescuento)
                .HasPrecision(16, 2);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.VarITBIS)
                .HasPrecision(16, 2);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.Factor)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Documento>()
                .Property(e => e.CodigoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Tipo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Modulo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Secuencia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Titulo1)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Titulo2)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Titulo3)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Titulo4)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Titulo5)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Factor)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Documento>()
                .HasMany(e => e.Facturas)
                .WithRequired(e => e.Documento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NoFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Credito)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.RNC)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NoAfiliadoARS)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NoAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Historico>()
                .Property(e => e.Orden)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Historico>()
                .Property(e => e.Detalle1)
                .IsUnicode(false);

            modelBuilder.Entity<Historico>()
                .Property(e => e.Detalle2)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Medico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medico>()
                .HasMany(e => e.Consultorios)
                .WithRequired(e => e.Medico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.CodigoNCF)
                .IsUnicode(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Secuencia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NCF>()
                .Property(e => e.UltimoNCF)
                .HasPrecision(2, 0);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Aviso)
                .IsUnicode(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Modulo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NCF>()
                .Property(e => e.TipoNCF)
                .IsUnicode(false);

            modelBuilder.Entity<NCF>()
                .Property(e => e.Valor)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.TipoSangre)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Imagen)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Alergico)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Ocupacion)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Peso)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Estatura)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Log)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NoAfiliadoARS)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NombreContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Paciente>()
                .HasOptional(e => e.DetalleFactura)
                .WithRequired(e => e.Paciente);

            modelBuilder.Entity<Provincia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Pacientes)
                .WithRequired(e => e.Provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Pacientes)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.ServicioId)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.NombreServicio)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.ITBIS)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.NombreProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Precio)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Tipo)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Parametro)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Referencia)
                .IsUnicode(false);
        }
    }
}
