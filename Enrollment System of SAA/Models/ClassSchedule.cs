using System.Collections.Generic;

namespace Enrollment_System_of_SAA.Models
{
    class ClassSchedule
    {
        public ClassSchedule()
        {
            //            Subjects = new HashSet<Subject>();
            //            Rooms = new HashSet<Room>();
            //            Teachers = new HashSet<Teacher>();
        }
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int SubjectId { get; set; }
        public int RoomId { get; set; }
        public int TeacherId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Days { get; set; }
        public string Term { get; set; }
        public string Meridiem { get; set; }

        //navigation
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
