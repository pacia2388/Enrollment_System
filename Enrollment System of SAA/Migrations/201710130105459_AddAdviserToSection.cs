namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdviserToSection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sections", "AdviserName", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sections", "AdviserName");
        }
    }
}
