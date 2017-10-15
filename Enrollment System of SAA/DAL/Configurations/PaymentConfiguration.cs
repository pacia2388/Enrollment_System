using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            HasKey(t => t.PaymentId);

            Property(t => t.PaymentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.TotalAmount).HasPrecision(10, 2);

            Property(t => t.Term).IsRequired().HasMaxLength(50);



            HasMany(t => t.Fees).WithMany(t => t.Payment).Map(m =>
            {
                m.ToTable("StudentFeeList");
                m.MapLeftKey("PaymentId");
                m.MapRightKey("FeeId");
            });
        }
    }
}