using Enrollment_System_of_SAA.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enrollment_System_of_SAA.DAL.Configurations
{
    class ClassScheduleConfiguration : EntityTypeConfiguration<ClassSchedule>
    {
        public ClassScheduleConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.StartTime).IsRequired();

            Property(t => t.EndTime).IsRequired();

            Property(t => t.Term).IsRequired().HasMaxLength(50);

            Property(t => t.Days).IsRequired().HasMaxLength(50);

            Property(t => t.Meridiem).HasMaxLength(10);

            HasMany(t => t.Rooms).WithMany(t => t.ClassSchedules).Map(m =>
            {
                m.ToTable("RommSchedules");
                m.MapLeftKey("RoomId");
                m.MapRightKey("ClassScheduleId");
            });

            HasMany(t => t.Subjects).WithMany(t => t.ClassSchedules).Map(m =>
            {
                m.ToTable("SubjectSchedules");
                m.MapLeftKey("SubjectId");
                m.MapRightKey("ClassScheduleId");
            });

            HasMany(t => t.Teachers).WithMany(t => t.ClassSchedules).Map(m =>
            {
                m.ToTable("TeachersSchedules");
                m.MapLeftKey("TeacherId");
                m.MapRightKey("ClassScheduleId");
            });
        }
    }
}