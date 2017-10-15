namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectConfiguration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sections", "SectionName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Sections", "GradeLevel", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sections", "GradeLevel", c => c.String());
            AlterColumn("dbo.Sections", "SectionName", c => c.String());
        }
    }
}
