using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class AYConfiguration : EntityTypeConfiguration<AY>
    {
        public AYConfiguration()
        {
            HasKey(t => t.AYID);

            Property(t => t.AYID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.AYName).IsRequired().HasMaxLength(255);
        }
    }
}
