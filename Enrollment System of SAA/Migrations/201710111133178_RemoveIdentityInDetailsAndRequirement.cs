namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveIdentityInDetailsAndRequirement : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Requirements", new[] { "Id" });
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailsId" });
            DropPrimaryKey("dbo.Requirements");
            DropPrimaryKey("dbo.StudentDetails");
            AlterColumn("dbo.Requirements", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentDetails", "StudentDetailsId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Requirements", "Id");
            AddPrimaryKey("dbo.StudentDetails", "StudentDetailsId");
            CreateIndex("dbo.Requirements", "Id");
            CreateIndex("dbo.StudentDetails", "StudentDetailsId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailsId" });
            DropIndex("dbo.Requirements", new[] { "Id" });
            DropPrimaryKey("dbo.StudentDetails");
            DropPrimaryKey("dbo.Requirements");
            AlterColumn("dbo.StudentDetails", "StudentDetailsId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Requirements", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StudentDetails", "StudentDetailsId");
            AddPrimaryKey("dbo.Requirements", "Id");
            CreateIndex("dbo.StudentDetails", "StudentDetailsId");
            CreateIndex("dbo.Requirements", "Id");
        }
    }
}
