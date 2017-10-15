using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.Models
{
    class Requirement
    {
        public int Id { get; set; }
        public bool PDS { get; set; }
        public bool NSO { get; set; }
        public bool GM { get; set; }
        public bool FORM137 { get; set; }

        //navigation
        public virtual Student Student { get; set; }
    }
}
