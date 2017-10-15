using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            HasKey(t => t.TransactionId);

            Property(t => t.TransactionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.AmountPaid).IsRequired().HasPrecision(10, 2);

            Property(t => t.DatePaid).IsRequired();

            Property(t => t.ReferenceNum).IsRequired().HasMaxLength(255);

            HasRequired(t => t.Payment).WithMany(t => t.Transactions).HasForeignKey(t => t.PaymentId).WillCascadeOnDelete(false);
        }
    }
}
