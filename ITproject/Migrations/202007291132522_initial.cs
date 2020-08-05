namespace ITproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        BuildingId = c.Int(nullable: false, identity: true),
                        BuildingName = c.String(),
                        BuildingStutus = c.Int(nullable: false),
                        NumberOfSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuildingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buildings");
        }
    }
}
