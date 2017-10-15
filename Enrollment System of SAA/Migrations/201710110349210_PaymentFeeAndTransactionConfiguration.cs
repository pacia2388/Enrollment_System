namespace Enrollment_System_of_SAA.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PaymentFeeAndTransactionConfiguration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Fees");
            CreateTable(
                "dbo.StudentFeeList",
                c => new
                {
                    PaymentId = c.Int(nullable: false),
                    FeeId = c.Byte(nullable: false),
                })
                .PrimaryKey(t => new { t.PaymentId, t.FeeId })
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: false)
                .ForeignKey("dbo.Fees", t => t.FeeId, cascadeDelete: false)
                .Index(t => t.PaymentId)
                .Index(t => t.FeeId);

            AddColumn("dbo.Transactions", "Student_StudentId", c => c.Int());
            AlterColumn("dbo.Fees", "FeeId", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.Fees", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Fees", "Amount", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Payments", "TotalAmount", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Transactions", "AmountPaid", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Transactions", "ReferenceNum", c => c.String(nullable: false, maxLength: 255));
            AddPrimaryKey("dbo.Fees", "FeeId");
            CreateIndex("dbo.Payments", "StudentId");
            CreateIndex("dbo.Payments", "AYID");
            CreateIndex("dbo.Transactions", "PaymentId");
            CreateIndex("dbo.Transactions", "Student_StudentId");
            AddForeignKey("dbo.Payments", "AYID", "dbo.AYs", "AYID", cascadeDelete: false);
            AddForeignKey("dbo.Payments", "StudentId", "dbo.Students", "StudentId", cascadeDelete: false);
            AddForeignKey("dbo.Transactions", "PaymentId", "dbo.Payments", "PaymentId");
            AddForeignKey("dbo.Transactions", "Student_StudentId", "dbo.Students", "StudentId");
            DropColumn("dbo.Transactions", "StudentId");
        }

        public override void Down()
        {
            AddColumn("dbo.Transactions", "StudentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Transactions", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Transactions", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Payments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentFeeList", "FeeId", "dbo.Fees");
            DropForeignKey("dbo.StudentFeeList", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Payments", "AYID", "dbo.AYs");
            DropIndex("dbo.StudentFeeList", new[] { "FeeId" });
            DropIndex("dbo.StudentFeeList", new[] { "PaymentId" });
            DropIndex("dbo.Transactions", new[] { "Student_StudentId" });
            DropIndex("dbo.Transactions", new[] { "PaymentId" });
            DropIndex("dbo.Payments", new[] { "AYID" });
            DropIndex("dbo.Payments", new[] { "StudentId" });
            DropPrimaryKey("dbo.Fees");
            AlterColumn("dbo.Transactions", "ReferenceNum", c => c.String());
            AlterColumn("dbo.Transactions", "AmountPaid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Payments", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Fees", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Fees", "Name", c => c.String());
            AlterColumn("dbo.Fees", "FeeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Transactions", "Student_StudentId");
            DropTable("dbo.StudentFeeList");
            AddPrimaryKey("dbo.Fees", "FeeId");
        }
    }
}
