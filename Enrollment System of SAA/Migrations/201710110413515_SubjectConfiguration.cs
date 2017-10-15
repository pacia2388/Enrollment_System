namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subjects", "SubjectCode", c => c.String(maxLength: 255));
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Subjects", "GradeLevel", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "GradeLevel", c => c.String());
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String());
            AlterColumn("dbo.Subjects", "SubjectCode", c => c.String());
        }
    }
}
