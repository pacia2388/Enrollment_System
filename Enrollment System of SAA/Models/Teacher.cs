using System;
using System.Collections.Generic;
using System.Linq;
using Enrollment_System_of_SAA.DAL;

namespace Enrollment_System_of_SAA.Models
{
    class Teacher
    {
        public Teacher()
        {
            ClassSchedules = new HashSet<ClassSchedule>();
            GradeLists = new HashSet<GradeList>();
        }
        public int TeacherId { get; set; }
        public string TeacherNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;

            }
        }

        public static List<Teacher> TeacherList()
        {
            var result = (from teacher in SAADBContext.GetInstance().Teachers
                let FullName = teacher.LastName + ", " + teacher.FirstName
                select teacher
            ).ToList();

            return result;
        }

        //navigation
        public virtual ICollection<ClassSchedule> ClassSchedules { get; set; }
        public virtual ICollection<GradeList> GradeLists { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
