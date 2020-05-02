namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SandForPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "SandForPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "SandForPassword");
        }
    }
}
