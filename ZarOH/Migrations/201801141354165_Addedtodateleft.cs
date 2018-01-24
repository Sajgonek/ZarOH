namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtodateleft : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateLeft", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateLeft", c => c.DateTime(nullable: false));
        }
    }
}
