namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropRelationBetweenStudentAndTransaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.Transactions", new[] { "Student_StudentId" });
            DropColumn("dbo.Transactions", "Student_StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Student_StudentId", c => c.Int());
            CreateIndex("dbo.Transactions", "Student_StudentId");
            AddForeignKey("dbo.Transactions", "Student_StudentId", "dbo.Students", "StudentId");
        }
    }
}
