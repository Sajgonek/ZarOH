namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoomTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT RoomTypes ON");
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
