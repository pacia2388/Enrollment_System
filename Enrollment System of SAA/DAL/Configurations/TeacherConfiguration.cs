using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enrollment_System_of_SAA.Models;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            HasKey(t => t.TeacherId);

            Property(t => t.LastName).IsRequired().HasMaxLength(255);
            Property(t => t.FirstName).IsRequired().HasMaxLength(255);
            Property(t => t.MiddleName).IsRequired().HasMaxLength(255);
            Property(t => t.Address).HasMaxLength(500);
            Property(t => t.BirthDate).IsRequired();
            Property(t => t.Gender).IsRequired().HasMaxLength(50);
            Property(t => t.ContactNo).HasMaxLength(50);

            Ignore(t => t.FullName);
        }
    }
}
