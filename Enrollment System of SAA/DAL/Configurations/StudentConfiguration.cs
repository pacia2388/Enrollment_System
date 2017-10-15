using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.DAL
{
    class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(t => t.StudentId);

            Property(t => t.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.StudentNo).HasMaxLength(255);

            Property(t => t.LastName).IsRequired().HasMaxLength(255);

            Property(t => t.FirstName).IsRequired().HasMaxLength(255);

            Property(t => t.MiddleName).HasMaxLength(255);

            Property(t => t.NameSuffix).HasMaxLength(255);

            Property(t => t.Contact).HasMaxLength(255);

            Property(t => t.Gender).IsRequired().HasMaxLength(255);

            Property(t => t.BirthDate).IsRequired();


            //Relationship
//            HasMany(t => t.Enrollments).WithRequired(t => t.Student).HasForeignKey(t => t.StudentId);
        }
    }
}
