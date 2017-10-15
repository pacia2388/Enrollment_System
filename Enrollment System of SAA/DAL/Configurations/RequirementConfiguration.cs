using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enrollment_System_of_SAA.Models;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class RequirementConfiguration : EntityTypeConfiguration<Requirement>
    {
        public RequirementConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.NSO).IsRequired();

            Property(t => t.GM).IsRequired();

            Property(t => t.FORM137).IsRequired();

            Property(t => t.PDS).IsRequired();
            
            HasRequired(t => t.Student).WithOptional(t => t.Requirement);
        }
    }
}
