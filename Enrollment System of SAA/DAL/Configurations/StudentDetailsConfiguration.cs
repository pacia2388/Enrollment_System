using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL
{
    class StudentDetailsConfiguration : EntityTypeConfiguration<StudentDetails>
    {
        public StudentDetailsConfiguration()
        {
            HasKey(t => t.StudentDetailsId);

            Property(t => t.Address).IsRequired().HasMaxLength(500);

            Property(t => t.Religion).HasMaxLength(255);

            Property(t => t.Citizenship).IsRequired().HasMaxLength(255);

            Property(t => t.FatherName).HasMaxLength(255);

            Property(t => t.FatherOccup).HasMaxLength(255);

            Property(t => t.MotherName).HasMaxLength(255);

            Property(t => t.MotherOccup).HasMaxLength(255);

            Property(t => t.GuardianName).HasMaxLength(255);

            Property(t => t.GuardianOccup).HasMaxLength(255);

            Property(t => t.Relationship).HasMaxLength(255);

            Property(t => t.ContactInCaseOfEmergency).IsOptional().HasMaxLength(255);

            Property(t => t.BaptismalCertificateRefNum).HasMaxLength(255);

            Property(t => t.GoodMoralCertificateRefNum).HasMaxLength(255);

            Property(t => t.NsoRefNum).HasMaxLength(255);

            Property(t => t.ReportCardRefNum).HasMaxLength(255);

            HasRequired(t => t.Student).WithOptional(t => t.StudentDetails);
        }
    }
}