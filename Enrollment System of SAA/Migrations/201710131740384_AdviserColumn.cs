namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdviserColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sections", "TeahcerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sections", "TeahcerId");
            AddForeignKey("dbo.Sections", "TeahcerId", "dbo.Teachers", "TeacherId");
            DropColumn("dbo.Teachers", "SectionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "SectionId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sections", "TeahcerId", "dbo.Teachers");
            DropIndex("dbo.Sections", new[] { "TeahcerId" });
            DropColumn("dbo.Sections", "TeahcerId");
        }
    }
}
