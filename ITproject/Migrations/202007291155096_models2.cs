namespace ITproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Performances",
                c => new
                    {
                        PerformanceId = c.Int(nullable: false, identity: true),
                        PerformanceName = c.String(),
                    })
                .PrimaryKey(t => t.PerformanceId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatNumber = c.Int(nullable: false, identity: true),
                        SeatStatus = c.Boolean(nullable: false),
                        buildingId_BuildingId = c.Int(),
                    })
                .PrimaryKey(t => t.SeatNumber)
                .ForeignKey("dbo.Buildings", t => t.buildingId_BuildingId)
                .Index(t => t.buildingId_BuildingId);
            
            CreateTable(
                "dbo.TimeSlots",
                c => new
                    {
                        Slot = c.DateTime(nullable: false),
                        TimeSlotStatus = c.Boolean(nullable: false),
                        buildingId_BuildingId = c.Int(),
                        performanceId_PerformanceId = c.Int(),
                    })
                .PrimaryKey(t => t.Slot)
                .ForeignKey("dbo.Buildings", t => t.buildingId_BuildingId)
                .ForeignKey("dbo.Performances", t => t.performanceId_PerformanceId)
                .Index(t => t.buildingId_BuildingId)
                .Index(t => t.performanceId_PerformanceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimeSlots", "performanceId_PerformanceId", "dbo.Performances");
            DropForeignKey("dbo.TimeSlots", "buildingId_BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.Seats", "buildingId_BuildingId", "dbo.Buildings");
            DropIndex("dbo.TimeSlots", new[] { "performanceId_PerformanceId" });
            DropIndex("dbo.TimeSlots", new[] { "buildingId_BuildingId" });
            DropIndex("dbo.Seats", new[] { "buildingId_BuildingId" });
            DropTable("dbo.TimeSlots");
            DropTable("dbo.Seats");
            DropTable("dbo.Performances");
            DropTable("dbo.Clients");
        }
    }
}
