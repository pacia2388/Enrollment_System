using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL
{
    class EnrollmentConfiguration : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentConfiguration()
        {
            HasKey(t => t.EnrollmentId);

            Property(t => t.EnrollmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.DateOfEnrollment).IsRequired();

            HasRequired(t => t.Section).WithMany(t => t.Enrollments).HasForeignKey(t => t.SectionId);

            HasRequired(t => t.Student).WithMany(t => t.Enrollments).HasForeignKey(t => t.StudentId);
        }
    }
}
