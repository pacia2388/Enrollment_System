namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateFees : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(1,'Registration Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(2,'Tuition Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(3,'Identification Card',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(4,'Library Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(5,'Student Handbook',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(6,'Laboratory Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(7,'Library Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(8,'Student Information System',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(9,'Sports Development Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(10,'Admission Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(11,'Guidance Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(12,'Medical and Dental Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(13,'Application for Graduation',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(14,'Transcript of Record',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(15,'Diploma Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(16,'Graduation Fee',0.00)");
            Sql("INSERT INTO Fees(FeeId,Name,Amount) VALUES(17,'Certification',0.00)");
        }

        public override void Down()
        {
        }
    }
}
