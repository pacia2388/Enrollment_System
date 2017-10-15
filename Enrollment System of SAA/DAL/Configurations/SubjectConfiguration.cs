using Enrollment_System_of_SAA.Models;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            HasKey(t => t.SubjectId);

            Property(t => t.SubjectCode).HasMaxLength(255);
            Property(t => t.SubjectName).IsRequired().HasMaxLength(255);
            Property(t => t.Description).IsMaxLength();
            Property(t => t.GradeLevel).HasMaxLength(255);
        }
    }
}
