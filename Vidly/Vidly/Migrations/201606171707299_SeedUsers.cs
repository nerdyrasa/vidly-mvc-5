namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4c4fd0da-2ee0-4998-89f1-02cb9aba873a', N'guest@vidly.com', 0, N'AJYzPLl5y9tpfWzJJQrqBtTQ+s8RBQZKdLX4cvQ9riDQUgnE5RdXVIzbtZ9KT+8y5g==', N'0031821e-47d0-48f6-8dda-976b05e8eb66', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'85ce87d5-51f9-419d-970b-0707503a20dd', N'admin@vidly.com', 0, N'AERI2r1rr+vhvSk4x9QVofvO3gWq2ghIp2dK1BYMinfebPT3XXNNNfGSYv+u4L6Cbw==', N'8567e902-5b30-45a7-aab1-fab7a7b80896', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1f569983-53be-4d13-b0bd-81f2ea7ddd48', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'85ce87d5-51f9-419d-970b-0707503a20dd', N'1f569983-53be-4d13-b0bd-81f2ea7ddd48')


");

        }
        
        public override void Down()
        {
        }
    }
}
