namespace ZarOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00d6fd58-b9f1-4558-a53b-b3b7e46475ec', N'admin@zaroh.com', 0, N'AOdVQggOT2qLUFxG8avNG2DocByKeUE5qHj/mNdzA/PR2m7d3ZMYnROXV8a+t+fQng==', N'112995d7-b784-4058-a79e-96c990251603', NULL, 0, 0, NULL, 1, 0, N'admin@zaroh.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'874fe441-5a5a-45ae-b954-94370e6f7e75', N'guest@zaroh.com', 0, N'AGh88MwU0D2D2H/orhhANd1hcB1qwtBk7NoSMmkAx4wphnC5wYuCNAmw557FvEHY7A==', N'87c88a89-8a86-4366-97b3-20c0007bab2e', NULL, 0, 0, NULL, 1, 0, N'guest@zaroh.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2c6ae221-2014-4757-927a-4ebacc6e97c0', N'CanManageRooms')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'00d6fd58-b9f1-4558-a53b-b3b7e46475ec', N'2c6ae221-2014-4757-927a-4ebacc6e97c0')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
