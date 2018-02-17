namespace HealthPrediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameandPhoneNumberToApplicationUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
