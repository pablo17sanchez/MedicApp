namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingContrainsToUserTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Password", c => c.String());
            AlterColumn("dbo.Usuarios", "UserName", c => c.String());
        }
    }
}
