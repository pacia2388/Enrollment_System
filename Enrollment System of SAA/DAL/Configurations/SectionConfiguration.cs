using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class SectionConfiguration : EntityTypeConfiguration<Section>
    {
        public SectionConfiguration()
        {
            HasKey(t => t.SectionId);

            Property(t => t.SectionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.SectionName).IsRequired().HasMaxLength(255);

            Property(t => t.GradeLevel).IsRequired().HasMaxLength(255);

            HasRequired(t => t.Teacher).WithMany(t => t.Sections).HasForeignKey(t => t.TeahcerId).WillCascadeOnDelete(false);
        }
    }
}
