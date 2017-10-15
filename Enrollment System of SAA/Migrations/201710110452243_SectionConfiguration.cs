namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SectionConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ClassSchedules", "SectionId");
            CreateIndex("dbo.ClassSchedules", "SubjectId");
            AddForeignKey("dbo.ClassSchedules", "SectionId", "dbo.Sections", "SectionId", cascadeDelete: false);
            AddForeignKey("dbo.ClassSchedules", "SubjectId", "dbo.Subjects", "SubjectId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassSchedules", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.ClassSchedules", "SectionId", "dbo.Sections");
            DropIndex("dbo.ClassSchedules", new[] { "SubjectId" });
            DropIndex("dbo.ClassSchedules", new[] { "SectionId" });
        }
    }
}
