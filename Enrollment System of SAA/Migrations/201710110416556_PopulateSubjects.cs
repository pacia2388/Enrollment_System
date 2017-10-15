namespace Enrollment_System_of_SAA.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateSubjects : DbMigration
    {
        public override void Up()
        {
            //Grade 7
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel,GradeLevel) VALUES(701,'Filipino 7','Grade 7 - Filipino','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(702,'English 7','Grade 7 - English','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(703,'Math 7','Grade 7 - Mathemathics','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(704,'Science 7','Grade 7 - Science','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(705,'AP 7','Grade 7 - Araling Panlipunan','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(706,'EsP 7','Grade 7 - Edukasyon sa Pagpapakatao','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(707,'MAPEH 7','Grade 7 - Music, Arts, PE, and Health','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(708,'EPP 7','Grade 7 - Edukasyon Pantahanan at Pangkabuhayan','Grade 7')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(709,'TLE 7','Grade 7 - Technology and Livelihood Education','Grade 7')");

            //Grade 8
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(801,'Filipino 8','Grade 8 - Filipino','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(802,'English 8','Grade 8 - English','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(803,'Math 8','Grade 8 - Mathemathics','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(804,'Science 8','Grade 8 - Science','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(805,'AP 8','Grade 8 - Araling Panlipunan','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(806,'EsP 8','Grade 8 - Edukasyon sa Pagpapakatao','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(807,'MAPEH 8','Grade 8 - Music, Arts, PE, and Health','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(808,'EPP 8','Grade 8 - Edukasyon Pantahanan at Pangkabuhayan','Grade 8')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(809,'TLE 8','Grade 8 - Technology and Livelihood Education','Grade 8')");

            //Grade 9
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(901,'Filipino 9','Grade 9 - Filipino','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(902,'English 9','Grade 9 - English','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(903,'Math 9','Grade 9 - Mathemathics','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(904,'Science 9','Grade 9 - Science','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(905,'AP 9','Grade 9 - Araling Panlipunan','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(906,'EsP 9','Grade 9 - Edukasyon sa Pagpapakatao','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(907,'MAPEH 9','Grade 9 - Music, Arts, PE, and Health','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(908,'EPP 9','Grade 9 - Edukasyon Pantahanan at Pangkabuhayan','Grade 9')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(909,'TLE 9','Grade 9 - Technology and Livelihood Education','Grade 9')");

            //Grade 10
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1001,'Filipino 10','Grade 10 - Filipino','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1002,'English 10','Grade 10 - English','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1003,'Math 10','Grade 10 - Mathemathics','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1004,'Science 10','Grade 10 - Science','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1005,'AP 10','Grade 10 - Araling Panlipunan','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1006,'EsP 10','Grade 10 - Edukasyon sa Pagpapakatao','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1007,'MAPEH 10','Grade 10 - Music, Arts, PE, and Health','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1008,'EPP 10','Grade 10 - Edukasyon Pantahanan at Pangkabuhayan','Grade 10')");
            Sql("INSERT INTO Subjects(SubjectId,SubjectName,Description,GradeLevel) VALUES(1009,'TLE 10','Grade 10 - Technology and Livelihood Education','Grade 10')");
        }

        public override void Down()
        {
        }
    }
}
