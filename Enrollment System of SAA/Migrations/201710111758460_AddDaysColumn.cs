namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDaysColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassSchedules", "Days", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClassSchedules", "Days");
        }
    }
}
