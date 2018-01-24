namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRentals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateLeft = c.DateTime(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Room_Id);
            
            AddColumn("dbo.Rooms", "IsOccupied", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Room_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropColumn("dbo.Rooms", "IsOccupied");
            DropTable("dbo.Rentals");
        }
    }
}
