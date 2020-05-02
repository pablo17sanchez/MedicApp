namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ARS",
                c => new
                    {
                        ARSId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 26, unicode: false),
                        Contacto = c.String(maxLength: 26, unicode: false),
                        FCreacion = c.DateTime(),
                        FModificacion = c.DateTime(),
                        Direccion = c.String(maxLength: 80, unicode: false),
                        RNC = c.String(nullable: false, maxLength: 20, unicode: false),
                        Correo = c.String(maxLength: 80, unicode: false),
                        CodigoNCF = c.String(maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.ARSId);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        DocumentoId = c.Int(nullable: false),
                        NoFactura = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        Fecha = c.DateTime(),
                        Credito = c.Decimal(precision: 3, scale: 0, storeType: "numeric"),
                        Nombre = c.String(maxLength: 80, unicode: false),
                        IdPaciente = c.Int(),
                        ARSId = c.Int(),
                        NCFId = c.Int(),
                        RNC = c.String(maxLength: 19, unicode: false),
                        Bruto = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Descuento = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Impuesto = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Neto = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        UsuarioId = c.Int(),
                        Efectivo = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Tarjeta = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Cheque = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        VarARS = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        OtroPago = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        NoAfiliadoARS = c.String(maxLength: 20, unicode: false),
                        NoAutorizacion = c.String(maxLength: 20, unicode: false),
                        Telefono = c.String(maxLength: 24, unicode: false),
                        FvencimientoNCF = c.DateTime(),
                        Fcreacion = c.DateTime(),
                        Fmodificacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.ARS", t => t.ARSId)
                .ForeignKey("dbo.Paciente", t => t.IdPaciente)
                .ForeignKey("dbo.Documentos", t => t.DocumentoId)
                .ForeignKey("dbo.NCF", t => t.NCFId)
                .Index(t => t.DocumentoId)
                .Index(t => t.IdPaciente)
                .Index(t => t.ARSId)
                .Index(t => t.NCFId);
            
            CreateTable(
                "dbo.Documentos",
                c => new
                    {
                        DocumentoId = c.Int(nullable: false, identity: true),
                        CodigoDocumento = c.String(nullable: false, maxLength: 6, unicode: false),
                        Nombre = c.String(maxLength: 60, unicode: false),
                        Tipo = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        Modulo = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        Secuencia = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        Status = c.Boolean(),
                        Titulo1 = c.String(maxLength: 80, unicode: false),
                        Titulo2 = c.String(maxLength: 80, unicode: false),
                        Titulo3 = c.String(maxLength: 80, unicode: false),
                        Titulo4 = c.String(maxLength: 80, unicode: false),
                        Titulo5 = c.String(maxLength: 80, unicode: false),
                        ConsultorioId = c.Int(),
                        Factor = c.Decimal(precision: 2, scale: 0, storeType: "numeric"),
                        Fcreacion = c.DateTime(),
                        Fmodificacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.DocumentoId);
            
            CreateTable(
                "dbo.DetalleFactura",
                c => new
                    {
                        DetalleFacturaId = c.Int(nullable: false),
                        DocumentoId = c.Int(),
                        NoFactura = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        Fecha = c.DateTime(),
                        ServicioId = c.String(maxLength: 20, unicode: false),
                        IdPaciente = c.Int(),
                        Cantidad = c.Decimal(precision: 16, scale: 2),
                        Precio = c.Decimal(precision: 16, scale: 2),
                        Descuento = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        VarDescuento = c.Decimal(precision: 16, scale: 2),
                        ITBIS = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        VarITBIS = c.Decimal(precision: 16, scale: 2),
                        Factor = c.Decimal(precision: 2, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.DetalleFacturaId)
                .ForeignKey("dbo.Documentos", t => t.DocumentoId)
                .ForeignKey("dbo.Paciente", t => t.DetalleFacturaId)
                .ForeignKey("dbo.Servicios", t => t.ServicioId)
                .Index(t => t.DetalleFacturaId)
                .Index(t => t.DocumentoId)
                .Index(t => t.ServicioId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        IdPaciente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 40, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 40, unicode: false),
                        Fnacimiento = c.DateTime(storeType: "date"),
                        Status = c.Boolean(nullable: false),
                        Fmodificacion = c.DateTime(nullable: false, storeType: "date"),
                        Fcreacion = c.DateTime(nullable: false, storeType: "date"),
                        Cedula = c.String(maxLength: 13, unicode: false),
                        Telefono = c.String(maxLength: 24, unicode: false),
                        Direccion = c.String(maxLength: 90, unicode: false),
                        ProvinciaId = c.Int(nullable: false),
                        SectorId = c.Int(nullable: false),
                        ARSId = c.Int(nullable: false),
                        TipoSangre = c.String(maxLength: 10, unicode: false),
                        Genero = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Imagen = c.String(unicode: false),
                        Alergico = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ocupacion = c.String(maxLength: 80, unicode: false),
                        EstadoCivil = c.String(maxLength: 20, unicode: false),
                        Peso = c.String(maxLength: 15, unicode: false),
                        Estatura = c.String(maxLength: 20, unicode: false),
                        Fuma = c.Boolean(),
                        Bebe = c.Boolean(),
                        Lat = c.String(maxLength: 20, unicode: false),
                        Log = c.String(maxLength: 20, unicode: false),
                        NoAfiliadoARS = c.String(maxLength: 20, unicode: false),
                        NombreContacto = c.String(maxLength: 15, unicode: false),
                        TelefonoContacto = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.IdPaciente)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId)
                .ForeignKey("dbo.Sector", t => t.SectorId)
                .ForeignKey("dbo.ARS", t => t.ARSId)
                .Index(t => t.ProvinciaId)
                .Index(t => t.SectorId)
                .Index(t => t.ARSId);
            
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitasId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        MedicoId = c.Int(nullable: false),
                        IdPaciente = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.Time(nullable: false, precision: 7),
                        Status = c.String(maxLength: 1, unicode: false),
                        FCreacion = c.DateTime(),
                        FModiciacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.CitasId)
                .ForeignKey("dbo.Medico", t => t.MedicoId)
                .ForeignKey("dbo.Paciente", t => t.IdPaciente)
                .Index(t => t.MedicoId)
                .Index(t => t.IdPaciente);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Cedula = c.String(maxLength: 13, unicode: false),
                        FCreacion = c.DateTime(),
                        FModificacion = c.DateTime(),
                        Status = c.Boolean(),
                        Telefono = c.String(maxLength: 24, unicode: false),
                        Correo = c.String(maxLength: 24, unicode: false),
                        ProvinciaId = c.Int(),
                        SectorId = c.Int(),
                        Especialidad = c.String(maxLength: 30, unicode: false),
                        Edad = c.Int(),
                        EstadoCivil = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MedicoId);
            
            CreateTable(
                "dbo.Consultorio",
                c => new
                    {
                        ConsultorioId = c.Int(nullable: false, identity: true),
                        NombreConsultorio = c.String(maxLength: 50, unicode: false),
                        MedicoId = c.Int(nullable: false),
                        FCreacion = c.DateTime(),
                        FModiciacion = c.DateTime(),
                        Status = c.Boolean(),
                        Telefono = c.String(maxLength: 24, unicode: false),
                    })
                .PrimaryKey(t => t.ConsultorioId)
                .ForeignKey("dbo.Medico", t => t.MedicoId)
                .Index(t => t.MedicoId);
            
            CreateTable(
                "dbo.Historico",
                c => new
                    {
                        HistoricoId = c.Int(nullable: false, identity: true),
                        DocumentoId = c.Int(),
                        IdPaciente = c.Int(),
                        Fecha = c.DateTime(),
                        Orden = c.Decimal(precision: 1, scale: 0, storeType: "numeric"),
                        Detalle1 = c.String(maxLength: 250, unicode: false),
                        Detalle2 = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.HistoricoId)
                .ForeignKey("dbo.Documentos", t => t.DocumentoId)
                .ForeignKey("dbo.Paciente", t => t.IdPaciente)
                .Index(t => t.DocumentoId)
                .Index(t => t.IdPaciente);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        SectorId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        CodigoPostal = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.SectorId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.String(nullable: false, maxLength: 20, unicode: false),
                        NombreServicio = c.String(nullable: false, maxLength: 60, unicode: false),
                        ITBIS = c.Decimal(precision: 6, scale: 2, storeType: "numeric"),
                        NombreProducto = c.String(nullable: false, maxLength: 80, unicode: false),
                        Precio = c.Decimal(nullable: false, precision: 16, scale: 2, storeType: "numeric"),
                        Tipo = c.Decimal(nullable: false, precision: 1, scale: 0, storeType: "numeric"),
                        Parametro = c.String(maxLength: 60, unicode: false),
                        Referencia = c.String(maxLength: 60, unicode: false),
                        Fcreacion = c.DateTime(),
                        Fmodificacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.ServicioId);
            
            CreateTable(
                "dbo.NCF",
                c => new
                    {
                        NCFId = c.Int(nullable: false, identity: true),
                        CodigoNCF = c.String(nullable: false, maxLength: 6, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 80, unicode: false),
                        Prefijo = c.String(nullable: false, maxLength: 6, unicode: false),
                        Secuencia = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        UltimoNCF = c.Decimal(precision: 2, scale: 0, storeType: "numeric"),
                        Aviso = c.String(maxLength: 80, unicode: false),
                        Modulo = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        TipoNCF = c.String(maxLength: 1, unicode: false),
                        RNC = c.Boolean(),
                        Valor = c.Decimal(precision: 16, scale: 2, storeType: "numeric"),
                        Fvencimiento = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.NCFId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Correo = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "ARSId", "dbo.ARS");
            DropForeignKey("dbo.Factura", "NCFId", "dbo.NCF");
            DropForeignKey("dbo.Factura", "DocumentoId", "dbo.Documentos");
            DropForeignKey("dbo.DetalleFactura", "ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Paciente", "SectorId", "dbo.Sector");
            DropForeignKey("dbo.Paciente", "ProvinciaId", "dbo.Provincia");
            DropForeignKey("dbo.Historico", "IdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Historico", "DocumentoId", "dbo.Documentos");
            DropForeignKey("dbo.Factura", "IdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.DetalleFactura", "DetalleFacturaId", "dbo.Paciente");
            DropForeignKey("dbo.Citas", "IdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Consultorio", "MedicoId", "dbo.Medico");
            DropForeignKey("dbo.Citas", "MedicoId", "dbo.Medico");
            DropForeignKey("dbo.DetalleFactura", "DocumentoId", "dbo.Documentos");
            DropForeignKey("dbo.Factura", "ARSId", "dbo.ARS");
            DropIndex("dbo.Historico", new[] { "IdPaciente" });
            DropIndex("dbo.Historico", new[] { "DocumentoId" });
            DropIndex("dbo.Consultorio", new[] { "MedicoId" });
            DropIndex("dbo.Citas", new[] { "IdPaciente" });
            DropIndex("dbo.Citas", new[] { "MedicoId" });
            DropIndex("dbo.Paciente", new[] { "ARSId" });
            DropIndex("dbo.Paciente", new[] { "SectorId" });
            DropIndex("dbo.Paciente", new[] { "ProvinciaId" });
            DropIndex("dbo.DetalleFactura", new[] { "ServicioId" });
            DropIndex("dbo.DetalleFactura", new[] { "DocumentoId" });
            DropIndex("dbo.DetalleFactura", new[] { "DetalleFacturaId" });
            DropIndex("dbo.Factura", new[] { "NCFId" });
            DropIndex("dbo.Factura", new[] { "ARSId" });
            DropIndex("dbo.Factura", new[] { "IdPaciente" });
            DropIndex("dbo.Factura", new[] { "DocumentoId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.NCF");
            DropTable("dbo.Servicios");
            DropTable("dbo.Sector");
            DropTable("dbo.Provincia");
            DropTable("dbo.Historico");
            DropTable("dbo.Consultorio");
            DropTable("dbo.Medico");
            DropTable("dbo.Citas");
            DropTable("dbo.Paciente");
            DropTable("dbo.DetalleFactura");
            DropTable("dbo.Documentos");
            DropTable("dbo.Factura");
            DropTable("dbo.ARS");
        }
    }
}
