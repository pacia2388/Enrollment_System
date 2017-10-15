namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentDetailsAndRequirementConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentDetails", "Address", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.StudentDetails", "Religion", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "Citizenship", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.StudentDetails", "FatherName", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "FatherOccup", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "MotherName", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "MotherOccup", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "GuardianName", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "GuardianOccup", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "Relationship", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "ContactInCaseOfEmergency", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "GoodMoralCertificateRefNum", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "NsoRefNum", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "ReportCardRefNum", c => c.String(maxLength: 255));
            AlterColumn("dbo.StudentDetails", "BaptismalCertificateRefNum", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "StudentNo", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Students", "MiddleName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "NameSuffix", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Contact", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Requirements", "Id");
            CreateIndex("dbo.StudentDetails", "StudentDetailsId");
            AddForeignKey("dbo.StudentDetails", "StudentDetailsId", "dbo.Students", "StudentId");
            AddForeignKey("dbo.Requirements", "Id", "dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requirements", "Id", "dbo.Students");
            DropForeignKey("dbo.StudentDetails", "StudentDetailsId", "dbo.Students");
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailsId" });
            DropIndex("dbo.Requirements", new[] { "Id" });
            AlterColumn("dbo.Students", "Gender", c => c.String());
            AlterColumn("dbo.Students", "Contact", c => c.String());
            AlterColumn("dbo.Students", "NameSuffix", c => c.String());
            AlterColumn("dbo.Students", "MiddleName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "StudentNo", c => c.String());
            AlterColumn("dbo.StudentDetails", "BaptismalCertificateRefNum", c => c.String());
            AlterColumn("dbo.StudentDetails", "ReportCardRefNum", c => c.String());
            AlterColumn("dbo.StudentDetails", "NsoRefNum", c => c.String());
            AlterColumn("dbo.StudentDetails", "GoodMoralCertificateRefNum", c => c.String());
            AlterColumn("dbo.StudentDetails", "ContactInCaseOfEmergency", c => c.String());
            AlterColumn("dbo.StudentDetails", "Relationship", c => c.String());
            AlterColumn("dbo.StudentDetails", "GuardianOccup", c => c.String());
            AlterColumn("dbo.StudentDetails", "GuardianName", c => c.String());
            AlterColumn("dbo.StudentDetails", "MotherOccup", c => c.String());
            AlterColumn("dbo.StudentDetails", "MotherName", c => c.String());
            AlterColumn("dbo.StudentDetails", "FatherOccup", c => c.String());
            AlterColumn("dbo.StudentDetails", "FatherName", c => c.String());
            AlterColumn("dbo.StudentDetails", "Citizenship", c => c.String());
            AlterColumn("dbo.StudentDetails", "Religion", c => c.String());
            AlterColumn("dbo.StudentDetails", "Address", c => c.String());
        }
    }
}
