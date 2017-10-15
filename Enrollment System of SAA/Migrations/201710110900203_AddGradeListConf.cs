namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeListConf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Status", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.GradeLists", "_1stGrading", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_2ndGrading", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_3rdGrading", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_4thGrading", c => c.Decimal(precision: 18, scale: 2));
            CreateIndex("dbo.GradeLists", "StudentId");
            CreateIndex("dbo.GradeLists", "SubjectId");
            CreateIndex("dbo.GradeLists", "TeacherId");
            AddForeignKey("dbo.GradeLists", "StudentId", "dbo.Students", "StudentId", cascadeDelete: false);
            AddForeignKey("dbo.GradeLists", "SubjectId", "dbo.Subjects", "SubjectId", cascadeDelete: false);
            AddForeignKey("dbo.GradeLists", "TeacherId", "dbo.Teachers", "TeacherId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GradeLists", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.GradeLists", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.GradeLists", "StudentId", "dbo.Students");
            DropIndex("dbo.GradeLists", new[] { "TeacherId" });
            DropIndex("dbo.GradeLists", new[] { "SubjectId" });
            DropIndex("dbo.GradeLists", new[] { "StudentId" });
            AlterColumn("dbo.GradeLists", "_4thGrading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_3rdGrading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_2ndGrading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GradeLists", "_1stGrading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Enrollments", "Status", c => c.String());
        }
    }
}
