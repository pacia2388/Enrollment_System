namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeridiemInClassSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassSchedules", "Meridiem", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClassSchedules", "Meridiem");
        }
    }
}
