using Enrollment_System_of_SAA.DAL;
using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class StudentMasterList : UserControl
    {
        private SAADBContext _context = null;

        public StudentMasterList()
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

        private void StudentMasterList_Load(object sender, EventArgs e)
        {
            //            var resutlt = (from student in _context.Students
            //                           join details in _context.StudentDetails
            //                               on student.StudentId equals details.StudentDetailsId
            //                           select new
            //                           {
            //                               student.StudentNo,
            //                               student.FirstName,
            //                               student.MiddleName,
            //                               student.LastName,
            //                               student.Gender,
            //                               student.Contact,
            //                               student.BirthDate,
            //                               details.FatherName,
            //                               details.MotherName,
            //                               details.GuardianName,
            //                               details.ContactInCaseOfEmergency
            //                           }).ToList();
            //
            //            dgvStudentMasterList.DataSource = resutlt;

            dgvStudentMasterList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudentMasterList.Columns[0].HeaderText = "Student No";
            dgvStudentMasterList.Columns[1].HeaderText = "First Name";
            dgvStudentMasterList.Columns[2].HeaderText = "Middle Name";
            dgvStudentMasterList.Columns[3].HeaderText = "Last Name";
            dgvStudentMasterList.Columns[4].HeaderText = "Gender";
            dgvStudentMasterList.Columns[5].HeaderText = "Contact";
            dgvStudentMasterList.Columns[6].HeaderText = "Birthdate";
            dgvStudentMasterList.Columns[7].HeaderText = "Father's Name";
            dgvStudentMasterList.Columns[8].HeaderText = "Mother's Name";
            dgvStudentMasterList.Columns[9].HeaderText = "Guardian's Name";
            dgvStudentMasterList.Columns[10].HeaderText = "Contact in case of Emergency";
        }
    }
}
