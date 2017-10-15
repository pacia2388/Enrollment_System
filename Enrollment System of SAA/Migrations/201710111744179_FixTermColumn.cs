namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTermColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "AYID", "dbo.AYs");
            DropForeignKey("dbo.Payments", "AYID", "dbo.AYs");
            DropIndex("dbo.Enrollments", new[] { "AYID" });
            DropIndex("dbo.Payments", new[] { "AYID" });
            AddColumn("dbo.Enrollments", "Term", c => c.String());
            AddColumn("dbo.Students", "Status", c => c.String());
            AddColumn("dbo.ClassSchedules", "Term", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Payments", "Term", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Enrollments", "AYID");
            DropColumn("dbo.Enrollments", "Status");
            DropColumn("dbo.Payments", "AYID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "AYID", c => c.Int(nullable: false));
            AddColumn("dbo.Enrollments", "Status", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Enrollments", "AYID", c => c.Int(nullable: false));
            DropColumn("dbo.Payments", "Term");
            DropColumn("dbo.ClassSchedules", "Term");
            DropColumn("dbo.Students", "Status");
            DropColumn("dbo.Enrollments", "Term");
            CreateIndex("dbo.Payments", "AYID");
            CreateIndex("dbo.Enrollments", "AYID");
            AddForeignKey("dbo.Payments", "AYID", "dbo.AYs", "AYID", cascadeDelete: false);
            AddForeignKey("dbo.Enrollments", "AYID", "dbo.AYs", "AYID", cascadeDelete: false);
        }
    }
}
