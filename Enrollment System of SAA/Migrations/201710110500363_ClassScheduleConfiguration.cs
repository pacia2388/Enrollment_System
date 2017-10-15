namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassScheduleConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassSchedules", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.ClassSchedules", new[] { "SubjectId" });
            CreateTable(
                "dbo.RommSchedules",
                c => new
                    {
                        RoomId = c.Int(nullable: false),
                        ClassScheduleId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomId, t.ClassScheduleId })
                .ForeignKey("dbo.ClassSchedules", t => t.RoomId, cascadeDelete: false)
                .ForeignKey("dbo.Rooms", t => t.ClassScheduleId, cascadeDelete: false)
                .Index(t => t.RoomId)
                .Index(t => t.ClassScheduleId);
            
            CreateTable(
                "dbo.SubjectSchedules",
                c => new
                    {
                        SubjectId = c.Int(nullable: false),
                        ClassScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SubjectId, t.ClassScheduleId })
                .ForeignKey("dbo.ClassSchedules", t => t.SubjectId, cascadeDelete: false)
                .ForeignKey("dbo.Subjects", t => t.ClassScheduleId, cascadeDelete: false)
                .Index(t => t.SubjectId)
                .Index(t => t.ClassScheduleId);
            
            CreateTable(
                "dbo.TeachersSchedules",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        ClassScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.ClassScheduleId })
                .ForeignKey("dbo.ClassSchedules", t => t.TeacherId, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.ClassScheduleId, cascadeDelete: false)
                .Index(t => t.TeacherId)
                .Index(t => t.ClassScheduleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeachersSchedules", "ClassScheduleId", "dbo.Teachers");
            DropForeignKey("dbo.TeachersSchedules", "TeacherId", "dbo.ClassSchedules");
            DropForeignKey("dbo.SubjectSchedules", "ClassScheduleId", "dbo.Subjects");
            DropForeignKey("dbo.SubjectSchedules", "SubjectId", "dbo.ClassSchedules");
            DropForeignKey("dbo.RommSchedules", "ClassScheduleId", "dbo.Rooms");
            DropForeignKey("dbo.RommSchedules", "RoomId", "dbo.ClassSchedules");
            DropIndex("dbo.TeachersSchedules", new[] { "ClassScheduleId" });
            DropIndex("dbo.TeachersSchedules", new[] { "TeacherId" });
            DropIndex("dbo.SubjectSchedules", new[] { "ClassScheduleId" });
            DropIndex("dbo.SubjectSchedules", new[] { "SubjectId" });
            DropIndex("dbo.RommSchedules", new[] { "ClassScheduleId" });
            DropIndex("dbo.RommSchedules", new[] { "RoomId" });
            DropTable("dbo.TeachersSchedules");
            DropTable("dbo.SubjectSchedules");
            DropTable("dbo.RommSchedules");
            CreateIndex("dbo.ClassSchedules", "SubjectId");
            AddForeignKey("dbo.ClassSchedules", "SubjectId", "dbo.Subjects", "SubjectId", cascadeDelete: false);
        }
    }
}
