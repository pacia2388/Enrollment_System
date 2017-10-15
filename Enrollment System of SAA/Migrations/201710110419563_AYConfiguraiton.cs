namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AYConfiguraiton : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AYs", "AYName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AYs", "AYName", c => c.String());
        }
    }
}
