namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherConfiguration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "SectionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Teachers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Teachers", "MiddleName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Teachers", "Gender", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "Address", c => c.String(maxLength: 500));
            DropColumn("dbo.Sections", "AdviserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sections", "AdviserName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Teachers", "Address", c => c.String());
            AlterColumn("dbo.Teachers", "Gender", c => c.String());
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String());
            AlterColumn("dbo.Teachers", "MiddleName", c => c.String());
            AlterColumn("dbo.Teachers", "FirstName", c => c.String());
            AlterColumn("dbo.Teachers", "LastName", c => c.String());
            DropColumn("dbo.Teachers", "SectionId");
        }
    }
}
