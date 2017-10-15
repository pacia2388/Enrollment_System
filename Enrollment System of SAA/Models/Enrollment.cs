using System;
using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.Models
{
    class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string Term { get; set; }
        public int SectionId { get; set; }
        public DateTime DateOfEnrollment { get; set; }

        //navigation
        public virtual Student Student { get; set; }
        public virtual Section Section { get; set; }
    }
}
