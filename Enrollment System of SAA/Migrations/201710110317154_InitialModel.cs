namespace Enrollment_System_of_SAA.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsers",
                c => new
                {
                    AppUserId = c.Byte(nullable: false),
                    UserName = c.String(),
                    Password = c.String(),
                })
                .PrimaryKey(t => t.AppUserId);

            CreateTable(
                "dbo.AYs",
                c => new
                {
                    AYID = c.Int(nullable: false, identity: true),
                    AYName = c.String(),
                })
                .PrimaryKey(t => t.AYID);

            CreateTable(
                "dbo.ClassSchedules",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SectionId = c.Int(nullable: false),
                    SubjectId = c.Int(nullable: false),
                    RoomId = c.Int(nullable: false),
                    TeacherId = c.Int(nullable: false),
                    StartTime = c.Time(nullable: false, precision: 7),
                    EndTime = c.Time(nullable: false, precision: 7),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Enrollments",
                c => new
                {
                    EnrollmentId = c.Int(nullable: false, identity: true),
                    StudentId = c.Int(nullable: false),
                    AYID = c.Int(nullable: false),
                    SectionId = c.Int(nullable: false),
                    DateOfEnrollment = c.DateTime(nullable: false),
                    Status = c.String(),
                })
                .PrimaryKey(t => t.EnrollmentId);

            CreateTable(
                "dbo.Fees",
                c => new
                {
                    FeeId = c.Byte(nullable: false),
                    Name = c.String(),
                    Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.FeeId);

            CreateTable(
                "dbo.GradeLists",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    StudentId = c.Int(nullable: false),
                    _1stGrading = c.Decimal(nullable: false, precision: 18, scale: 2),
                    _2ndGrading = c.Decimal(nullable: false, precision: 18, scale: 2),
                    _3rdGrading = c.Decimal(nullable: false, precision: 18, scale: 2),
                    _4thGrading = c.Decimal(nullable: false, precision: 18, scale: 2),
                    SubjectId = c.Int(nullable: false),
                    TeacherId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Payments",
                c => new
                {
                    PaymentId = c.Int(nullable: false, identity: true),
                    StudentId = c.Int(nullable: false),
                    TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    AYID = c.Int(nullable: false),
                    DueDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.PaymentId);

            CreateTable(
                "dbo.Requirements",
                c => new
                {
                    Id = c.Int(nullable: false),
                    PDS = c.Boolean(nullable: false),
                    NSO = c.Boolean(nullable: false),
                    GM = c.Boolean(nullable: false),
                    FORM137 = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Rooms",
                c => new
                {
                    RoomId = c.Byte(nullable: false),
                    RoomName = c.String(),
                })
                .PrimaryKey(t => t.RoomId);

            CreateTable(
                "dbo.Sections",
                c => new
                {
                    SectionId = c.Int(nullable: false, identity: true),
                    SectionName = c.String(),
                    GradeLevel = c.String(),
                })
                .PrimaryKey(t => t.SectionId);

            CreateTable(
                "dbo.StudentDetails",
                c => new
                {
                    StudentDetailsId = c.Int(nullable: false),
                    Address = c.String(),
                    Religion = c.String(),
                    Citizenship = c.String(),
                    FatherName = c.String(),
                    FatherOccup = c.String(),
                    MotherName = c.String(),
                    MotherOccup = c.String(),
                    GuardianName = c.String(),
                    GuardianOccup = c.String(),
                    Relationship = c.String(),
                    ContactInCaseOfEmergency = c.String(),
                    GoodMoralCertificateRefNum = c.String(),
                    NsoRefNum = c.String(),
                    ReportCardRefNum = c.String(),
                    BaptismalCertificateRefNum = c.String(),
                    Status = c.String(),
                })
                .PrimaryKey(t => t.StudentDetailsId);

            CreateTable(
                "dbo.Students",
                c => new
                {
                    StudentId = c.Int(nullable: false, identity: true),
                    StudentNo = c.String(),
                    LastName = c.String(),
                    FirstName = c.String(),
                    MiddleName = c.String(),
                    NameSuffix = c.String(),
                    Contact = c.String(),
                    Gender = c.String(),
                    BirthDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.StudentId);

            CreateTable(
                "dbo.Subjects",
                c => new
                {
                    SubjectId = c.Int(nullable: false),
                    SubjectCode = c.String(),
                    SubjectName = c.String(),
                    Description = c.String(),
                    GradeLevel = c.String(),
                })
                .PrimaryKey(t => t.SubjectId);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    TeacherId = c.Int(nullable: false, identity: true),
                    TeacherNo = c.String(),
                    LastName = c.String(),
                    FirstName = c.String(),
                    MiddleName = c.String(),
                    ContactNo = c.String(),
                    Gender = c.String(),
                    BirthDate = c.DateTime(nullable: false),
                    Address = c.String(),
                })
                .PrimaryKey(t => t.TeacherId);

            CreateTable(
                "dbo.Transactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    PaymentId = c.Int(nullable: false),
                    StudentId = c.Int(nullable: false),
                    AmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                    DatePaid = c.DateTime(nullable: false),
                    ReferenceNum = c.String(),
                })
                .PrimaryKey(t => t.TransactionId);

        }

        public override void Down()
        {
            DropTable("dbo.Transactions");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Sections");
            DropTable("dbo.Rooms");
            DropTable("dbo.Requirements");
            DropTable("dbo.Payments");
            DropTable("dbo.GradeLists");
            DropTable("dbo.Fees");
            DropTable("dbo.Enrollments");
            DropTable("dbo.ClassSchedules");
            DropTable("dbo.AYs");
            DropTable("dbo.AppUsers");
        }
    }
}
