using Enrollment_System_of_SAA.DAL;
using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class StudentRecord : UserControl
    {
        private string searchboxMessage = "PRESS ENTER KEY TO SEARCH";

        private SAADBContext _context = null;

        public StudentRecord()
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

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            txtSearchBox.text = searchboxMessage;
        }

        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            txtSearchBox.text = "";
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.text == "")
            {
                txtSearchBox.text = searchboxMessage;
            }
        }

        private void txtSearchBox_KeyDown(object sender, EventArgs e)
        {
            //            if (((KeyEventArgs)e).KeyCode == Keys.Enter)
            //            {
            //                var studentNo = txtSearchBox.text;
            //
            ////                var id = _context.Students.SingleOrDefault(t => t.StudentNo == studentNo).StudentId;
            //
            //
            //
            //                if (id == 0)
            //                {
            //                    MessageBox.Show("Student record not found.");
            //                    return;
            //                }
            //                else
            //                {
            //                    Student student = _context.Students.SingleOrDefault(t => t.StudentId == id);
            //                    StudentDetails details = _context.StudentDetails.SingleOrDefault(t => t.StudentDetailsId == id);
            //                    Requirement requirement = _context.Requirements.SingleOrDefault(t => t.Id == id);
            //
            //                    txtStudentNo.Text = student.StudentNo;
            //                    txtName.Text = string.Concat(student.FirstName, " ", student.MiddleName.Substring(0, 1), ". ",
            //                        student.LastName);
            //                    txtGender.Text = student.Gender;
            //                    txtDOB.Text = student.BirthDate.ToShortDateString();
            //                    txtContact.Text = student.Contact;
            //                    txtAddress.Text = details.Address;
            //                    txtReligion.Text = details.Religion;
            //                    txtCitizenship.Text = details.Citizenship;
            //                    txtFathersName.Text = details.FatherName;
            //                    txtMothersName.Text = details.MotherName;
            //                    txtGuardiansName.Text = details.GuardianName;
            //                    cbPDS.Checked = requirement.PDS;
            //                    cbGM.Checked = requirement.GM;
            //                    cbNSO.Checked = requirement.NSO;
            //                    cbFORM137.Checked = requirement.FORM137;
            //                }
            //            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //            var result = (from gradelist in _context.GradeLists
            //                          join student in _context.Students
            //                              on gradelist.StudentId equals student.StudentId
            //                          join subject in _context.Subjects
            //                              on gradelist.SubjectId equals subject.SubjectId
            //                          join teacher in _context.Teachers
            //                              on gradelist.TeacherId equals teacher.TeacherId
            //                          select new
            //                          {
            //                              subject.SubjectCode,
            //                              subject.SubjectName,
            //                              gradelist._1stGrading,
            //                              gradelist._2ndGrading,
            //                              gradelist._3rdGrading,
            //                              gradelist._4thGrading,
            //                              TeacherName = new { teacher.FirstName, teacher.MiddleName, teacher.LastName }
            //                          }).ToList();
            //
            //            dgvGradeList.DataSource = result;

            dgvGradeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvGradeList.Columns[0].HeaderText = "Code";
            dgvGradeList.Columns[1].HeaderText = "Title";
            dgvGradeList.Columns[2].HeaderText = "1st";
            dgvGradeList.Columns[3].HeaderText = "2nd";
            dgvGradeList.Columns[4].HeaderText = "3rd";
            dgvGradeList.Columns[5].HeaderText = "4th";
            dgvGradeList.Columns[6].HeaderText = "Teacher";
        }
    }
}
