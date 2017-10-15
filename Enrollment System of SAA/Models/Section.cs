using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enrollment_System_of_SAA.Models
{
    class Section
    {
        public Section()
        {
            Enrollments = new HashSet<Enrollment>();
        }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string GradeLevel { get; set; }
        public int TeahcerId { get; set; }

        //navigation
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual Teacher Teacher { get; set; }
        //        public virtual ClassSchedule ClassSchedules { get; set; }
    }
}
