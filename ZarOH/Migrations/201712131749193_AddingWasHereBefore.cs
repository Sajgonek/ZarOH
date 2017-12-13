namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWasHereBefore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "WasACustomerBefore", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "WasACustomerBefore");
        }
    }
}
