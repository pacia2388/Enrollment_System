using Enrollment_System_of_SAA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using Enrollment_System_of_SAA.Models;

namespace Enrollment_System_of_SAA.Forms
{
    class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
            Payment = new HashSet<Payment>();
            GradeLists = new HashSet<GradeList>();
        }
        public int StudentId { get; set; }
        public string StudentNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NameSuffix { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Status { get; set; }

        //Navigation property
        public virtual StudentDetails StudentDetails { get; set; }
        public virtual Requirement Requirement { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<GradeList> GradeLists { get; set; }

        public int GetStudentId(string studentno)
        {
            return SAADBContext.GetInstance().Students.SingleOrDefault(t => t.StudentNo == studentno).StudentId;
        }
    }
}
