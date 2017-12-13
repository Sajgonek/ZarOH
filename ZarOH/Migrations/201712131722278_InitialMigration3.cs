namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeId, cascadeDelete: true)
                .Index(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomTypeId", "dbo.RoomTypes");
            DropIndex("dbo.Rooms", new[] { "RoomTypeId" });
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
        }
    }
}
