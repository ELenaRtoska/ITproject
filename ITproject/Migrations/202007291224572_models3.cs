namespace ITproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Address", c => c.String());
            AddColumn("dbo.Performances", "Description", c => c.String());
            AlterColumn("dbo.Buildings", "BuildingName", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "ClientName", c => c.String(nullable: false));
            AlterColumn("dbo.Performances", "PerformanceName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Performances", "PerformanceName", c => c.String());
            AlterColumn("dbo.Clients", "ClientName", c => c.String());
            AlterColumn("dbo.Buildings", "BuildingName", c => c.String());
            DropColumn("dbo.Performances", "Description");
            DropColumn("dbo.Clients", "Address");
        }
    }
}
