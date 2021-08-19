namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0993a829-0dcd-46b4-b1cd-4b6251ed4bbe', N'Admin@vidly.com', 0, N'AIim7P5hE3COpyxPSzEZEq6boPvENacd+r7ZnndjdfW6HBzxK4XZiu6Ak9ojz2+UZQ==', N'a21cd5ee-90e5-4c88-8f77-71e8b0976bfc', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db89bc6f-019a-4530-8df8-50456af5971d', N'guest@vidly.com', 0, N'AENRt6poPsPRO56OVAsn6BADRJVlhGPosrlNSEse+7KRoUZn1v4TWiUs9p9+XGwtdQ==', N'f6bc12a5-5d12-4f28-8548-077c19387ff6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'338a511a-feb4-46c4-b48a-c88ea52b87fb', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0993a829-0dcd-46b4-b1cd-4b6251ed4bbe', N'338a511a-feb4-46c4-b48a-c88ea52b87fb')

");
        }
        
        public override void Down()
        {
        }
    }
}
