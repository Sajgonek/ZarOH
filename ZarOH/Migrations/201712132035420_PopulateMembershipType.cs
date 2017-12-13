namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1,'Pay As You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 100, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly', 250, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annually', 1000, 12, 20)");
            Sql("INSERT INTO RoomTypes(Id,Name) Values (1, '1-bed')");
            Sql("INSERT INTO RoomTypes(Id,Name) Values (2, '2-bed')");
            Sql("INSERT INTO RoomTypes(Id,Name) Values (3, '3-bed')");
            Sql("INSERT INTO RoomTypes(Id,Name) Values (4, '4-bed')");
            Sql("INSERT INTO RoomTypes(Id,Name) Values (5, 'Apartment')");
        }
        
        public override void Down()
        {
        }
    }
}
