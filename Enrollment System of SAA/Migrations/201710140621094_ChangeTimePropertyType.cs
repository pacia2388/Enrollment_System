namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTimePropertyType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClassSchedules", "StartTime", c => c.String(nullable: false));
            AlterColumn("dbo.ClassSchedules", "EndTime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClassSchedules", "EndTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ClassSchedules", "StartTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
