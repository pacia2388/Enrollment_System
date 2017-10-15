using System;
using System.ComponentModel.DataAnnotations.Schema;
using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.Models
{
    class StudentDetails
    {
        public int StudentDetailsId { get; set; }
        public string Address { get; set; }
        public string Religion { get; set; }
        public string Citizenship { get; set; }
        public string FatherName { get; set; }
        public string FatherOccup { get; set; }
        public string MotherName { get; set; }
        public string MotherOccup { get; set; }
        public string GuardianName { get; set; }
        public string GuardianOccup { get; set; }
        public string Relationship { get; set; }
        public string ContactInCaseOfEmergency { get; set; }
        public string GoodMoralCertificateRefNum { get; set; }
        public string NsoRefNum { get; set; }
        public string ReportCardRefNum { get; set; }
        public string BaptismalCertificateRefNum { get; set; }
        public string Status { get; set; } // Graduate, Non-graduate, Dropped, Transfered

        //navigation property
        public virtual Student Student { get; set; }
    }
}