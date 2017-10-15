using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.Models
{
    class GradeList
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public decimal _1stGrading { get; set; }
        public decimal _2ndGrading { get; set; }
        public decimal _3rdGrading { get; set; }
        public decimal _4thGrading { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        //navigation
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }

    }
}
