namespace HealthPrediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Address], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Phone]) VALUES (N'5d9985a7-2450-474e-a6f9-c8b37985abff', N'Dhaka', N'royelsoft@gmail.com', 0, N'APVwEiGm5JEqD5jDTwhQySvt3WkTgfV6K0NmxpOR7yJxP84yqFhg3QZrps/nIYOBkQ==', N'73b3ff50-d156-4cbe-ad93-53025ae5228c', NULL, 0, 0, NULL, 1, 0, N'royelsoft@gmail.com', N'Admin', 1521426578)
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Address], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Phone]) VALUES (N'dfdcd1c6-3e36-4029-bf66-c1c633c5b5f4', N'Rangpur', N'royelurmy@gmail.com', 0, N'APffTFqCJ8H0nzl7wvsaK1OuQn/xXOVAy8lK2ZmUiFF2KZAS1A3pycT0P1/Bjxeytg==', N'ed496554-5925-4d30-9bf4-404223fb5ee5', NULL, 0, 0, NULL, 1, 0, N'royelurmy@gmail.com', N'gest@gmail.com', 1722732677)
                    
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4fa7069d-7f55-4bd7-8328-2a1e60796c56', N'CanManagePatient')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d9985a7-2450-474e-a6f9-c8b37985abff', N'4fa7069d-7f55-4bd7-8328-2a1e60796c56')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
