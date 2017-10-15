using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class FeeConfiguration : EntityTypeConfiguration<Fee>
    {
        public FeeConfiguration()
        {
            HasKey(t => t.FeeId);

            Property(t => t.FeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Name).IsRequired().HasMaxLength(255);

            Property(t => t.Amount).IsRequired().HasPrecision(10,2);
        }
    }
}
