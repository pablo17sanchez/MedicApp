namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectingDatabaseSemanticErros : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetalleFactura", "ServicioId", "dbo.Servicios");
            DropIndex("dbo.DetalleFactura", new[] { "ServicioId" });
            DropPrimaryKey("dbo.Servicios");
            AddColumn("dbo.ARS", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Documentos", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.DetalleFactura", "Servicio_ServicioId", c => c.Int());
            AddColumn("dbo.Paciente", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Citas", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Medico", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Consultorio", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Historico", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Provincia", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Sector", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Servicios", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.NCF", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioCreador", c => c.Int(nullable: false));
            AlterColumn("dbo.Factura", "UsuarioId", c => c.Int(nullable: false));
            AlterColumn("dbo.Servicios", "ServicioId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Servicios", "ServicioId");
            CreateIndex("dbo.DetalleFactura", "Servicio_ServicioId");
            AddForeignKey("dbo.DetalleFactura", "Servicio_ServicioId", "dbo.Servicios", "ServicioId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleFactura", "Servicio_ServicioId", "dbo.Servicios");
            DropIndex("dbo.DetalleFactura", new[] { "Servicio_ServicioId" });
            DropPrimaryKey("dbo.Servicios");
            AlterColumn("dbo.Servicios", "ServicioId", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Factura", "UsuarioId", c => c.Int());
            DropColumn("dbo.Usuarios", "UsuarioCreador");
            DropColumn("dbo.NCF", "UsuarioId");
            DropColumn("dbo.Servicios", "UsuarioId");
            DropColumn("dbo.Sector", "UsuarioId");
            DropColumn("dbo.Provincia", "UsuarioId");
            DropColumn("dbo.Historico", "UsuarioId");
            DropColumn("dbo.Consultorio", "UsuarioId");
            DropColumn("dbo.Medico", "UsuarioId");
            DropColumn("dbo.Citas", "UsuarioId");
            DropColumn("dbo.Paciente", "UsuarioId");
            DropColumn("dbo.DetalleFactura", "Servicio_ServicioId");
            DropColumn("dbo.Documentos", "UsuarioId");
            DropColumn("dbo.ARS", "UsuarioId");
            AddPrimaryKey("dbo.Servicios", "ServicioId");
            CreateIndex("dbo.DetalleFactura", "ServicioId");
            AddForeignKey("dbo.DetalleFactura", "ServicioId", "dbo.Servicios", "ServicioId");
        }
    }
}
