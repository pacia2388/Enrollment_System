using Enrollment_System_of_SAA.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class EnrollmentList : UserControl
    {
        private SAADBContext _context = null;

        public EnrollmentList()
        {
            InitializeComponent();
            _context = new SAADBContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            _context.Dispose();

            base.Dispose(disposing);
        }

        private void EnrollmentList_Load(object sender, EventArgs e)
        {
            var result = (from enrollment in _context.Enrollments
                          join student in _context.Students
                              on enrollment.StudentId equals student.StudentId
                          join ay in _context.AY
                              on enrollment.Term equals ay.AYName
                          join section in _context.Sections
                              on enrollment.SectionId equals section.SectionId
                          orderby student.StudentNo
                          select new
                          {
                              student.StudentNo,
                              student.FirstName,
                              student.MiddleName,
                              student.LastName,
                              ay.AYName,
                              section.GradeLevel,
                              section.SectionName,
                              enrollment.DateOfEnrollment,
                              student.Status
                          }).ToList();

            dgvEnrollmentList.DataSource = result;

            dgvEnrollmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvEnrollmentList.Columns[0].HeaderText = "Student No";
            dgvEnrollmentList.Columns[1].HeaderText = "First Name";
            dgvEnrollmentList.Columns[2].HeaderText = "Middle Name";
            dgvEnrollmentList.Columns[3].HeaderText = "Last Name";
            dgvEnrollmentList.Columns[4].HeaderText = "A.Y.";
            dgvEnrollmentList.Columns[5].HeaderText = "Grade";
            dgvEnrollmentList.Columns[6].HeaderText = "Section";
            dgvEnrollmentList.Columns[7].HeaderText = "Date";
            dgvEnrollmentList.Columns[8].HeaderText = "Status";

            dgvEnrollmentList.Columns[0].Width = 100;
            dgvEnrollmentList.Columns[1].Width = 150;
            dgvEnrollmentList.Columns[2].Width = 150;
            dgvEnrollmentList.Columns[3].Width = 150;
            dgvEnrollmentList.Columns[4].Width = 100;
            dgvEnrollmentList.Columns[5].Width = 100;
            dgvEnrollmentList.Columns[6].Width = 100;
            dgvEnrollmentList.Columns[7].Width = 100;
            dgvEnrollmentList.Columns[8].Width = 85;

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            SelectSection form = new SelectSection(0);
            form.ShowDialog();
        }
    }
}
