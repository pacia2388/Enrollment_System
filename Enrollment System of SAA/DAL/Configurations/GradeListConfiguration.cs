using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class GradeListConfiguration : EntityTypeConfiguration<GradeList>
    {
        public GradeListConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.StudentId).IsRequired();

            Property(t => t.SubjectId).IsRequired();

            Property(t => t.TeacherId).IsRequired();

            Property(t => t._1stGrading).IsOptional();

            Property(t => t._2ndGrading).IsOptional();

            Property(t => t._3rdGrading).IsOptional();

            Property(t => t._4thGrading).IsOptional();

            HasRequired(t => t.Student).WithMany(t => t.GradeLists).HasForeignKey(t => t.StudentId);

            HasRequired(t => t.Subject).WithMany(t => t.GradeLists).HasForeignKey(t => t.SubjectId);

            HasRequired(t => t.Teacher).WithMany(t => t.GradeLists).HasForeignKey(t => t.TeacherId);
        }
    }
}
