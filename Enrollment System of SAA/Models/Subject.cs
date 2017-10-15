using System.Collections.Generic;

namespace Enrollment_System_of_SAA.Models
{
    class Subject
    {
        public Subject()
        {
            ClassSchedules = new HashSet<ClassSchedule>();
            GradeLists = new HashSet<GradeList>();
            //            Students = new HashSet<Student>();
        }
        public int SubjectId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string GradeLevel { get; set; }

        //navigation
        public virtual ICollection<ClassSchedule> ClassSchedules { get; set; }
        public virtual ICollection<GradeList> GradeLists { get; set; }
        //        public virtual ICollection<Student> Students { get; set; }
    }
}
