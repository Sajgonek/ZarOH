namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTelNRToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "TelNr", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "TelNr");
        }
    }
}
