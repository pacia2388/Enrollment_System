namespace Enrollment_System_of_SAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRooms : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(1,'ICT 1')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(2,'ICT 2')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(3,'ICT 3')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(4,'ICT 4')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(5,'ICT 5')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(6,'ICT 6')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(7,'ICT 7')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(8,'ICT 8')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(9,'ICT 9')");
            Sql("INSERT INTO Rooms(RoomId,RoomName) VALUES(10,'ICT 10')");
        }
        
        public override void Down()
        {
        }
    }
}
