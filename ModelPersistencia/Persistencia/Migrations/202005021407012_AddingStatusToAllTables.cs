namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStatusToAllTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ARS", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factura", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Historico", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Provincia", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sector", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Servicios", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Documentos", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Citas", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Medico", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Consultorio", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NCF", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NCF", "Status", c => c.Boolean());
            AlterColumn("dbo.Consultorio", "Status", c => c.Boolean());
            AlterColumn("dbo.Medico", "Status", c => c.Boolean());
            AlterColumn("dbo.Citas", "Status", c => c.String(maxLength: 1, unicode: false));
            AlterColumn("dbo.Documentos", "Status", c => c.Boolean());
            DropColumn("dbo.Usuarios", "Status");
            DropColumn("dbo.Servicios", "Status");
            DropColumn("dbo.Sector", "Status");
            DropColumn("dbo.Provincia", "Status");
            DropColumn("dbo.Historico", "Status");
            DropColumn("dbo.Factura", "Status");
            DropColumn("dbo.ARS", "Status");
        }
    }
}
