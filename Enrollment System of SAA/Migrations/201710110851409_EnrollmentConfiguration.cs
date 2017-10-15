namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnrollmentConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Enrollments", "StudentId");
            CreateIndex("dbo.Enrollments", "AYID");
            CreateIndex("dbo.Enrollments", "SectionId");
            AddForeignKey("dbo.Enrollments", "AYID", "dbo.AYs", "AYID", cascadeDelete: false);
            AddForeignKey("dbo.Enrollments", "SectionId", "dbo.Sections", "SectionId", cascadeDelete: false);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "StudentId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Enrollments", "AYID", "dbo.AYs");
            DropIndex("dbo.Enrollments", new[] { "SectionId" });
            DropIndex("dbo.Enrollments", new[] { "AYID" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
        }
    }
}
