using Enrollment_System_of_SAA.DAL.Configurations;
using Enrollment_System_of_SAA.Forms;
using Enrollment_System_of_SAA.Models;
using System.Data.Entity;
using ClassScheduleConfiguration = Enrollment_System_of_SAA.DAL.Configurations.ClassScheduleConfiguration;
using SectionConfiguration = Enrollment_System_of_SAA.DAL.Configurations.SectionConfiguration;
using SubjectConfiguration = Enrollment_System_of_SAA.DAL.Configurations.SubjectConfiguration;

namespace Enrollment_System_of_SAA.DAL
{
    class SAADBContext : DbContext
    {
        public SAADBContext()
            : base("name=SAADBContext")
        {
            _instance = this;
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SAADBContext>());
        }

        private static SAADBContext _instance = null;

        public static SAADBContext GetInstance()
        {
            return _instance ?? (_instance = new SAADBContext());
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<ClassSchedule> ClassSchedules { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<AY> AY { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Requirement> Requirements { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<GradeList> GradeLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new StudentDetailsConfiguration());
            modelBuilder.Configurations.Add(new RequirementConfiguration());
            modelBuilder.Configurations.Add(new FeeConfiguration());
            modelBuilder.Configurations.Add(new TransactionConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
            modelBuilder.Configurations.Add(new AYConfiguration());
            modelBuilder.Configurations.Add(new SectionConfiguration());
            modelBuilder.Configurations.Add(new ClassScheduleConfiguration());
            modelBuilder.Configurations.Add(new EnrollmentConfiguration());
            modelBuilder.Configurations.Add(new GradeListConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
        }


    }
}
