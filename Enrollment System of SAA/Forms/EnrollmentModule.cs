using Enrollment_System_of_SAA.DAL;
using Enrollment_System_of_SAA.Models;
using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class EnrollmentModule : UserControl
    {
        private SAADBContext _context = null;

        public EnrollmentModule()
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

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            LoadRecord(out var student, out var details, out var requirement);

            SaveRecord(student, details, requirement);

            FormHelper.ClearForm(this.Controls);

        }

        private void SaveRecord(Student student, StudentDetails details, Requirement requirement)
        {
            try
            {
                student.StudentDetails = details;
                student.Requirement = requirement;
                _context.Students.Add(student);
                _context.SaveChanges();
                MessageBox.Show("Record saved successfully");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Saving record failed" + exception.Message);
            }
        }

        private void LoadRecord(out Student student, out StudentDetails details, out Requirement requirement)
        {
            student = new Student
            {
                FirstName = txtFName.Text,
                MiddleName = txtMName.Text,
                LastName = txtLName.Text,
                NameSuffix = txtNameSuffix.Text,
                BirthDate = dpDOB.Value,
                Contact = txtContact.Text,
                Gender = (rbMale.Checked == true ? "Male" : "Female"),
            };
            details = new StudentDetails
            {
                Address = string.Concat(txtStreet.Text, ", ", txtCity.Text, ", ", txtState.Text, ", ", txtZIP.Text),
                Religion = txtReligion.Text,
                Citizenship = txtCitizenship.Text,
                FatherName = txtFathersName.Text,
                FatherOccup = txtFathersOccup.Text,
                MotherName = txtMothersName.Text,
                MotherOccup = txtMothersOccup.Text,
                GuardianName = txtGuardiansName.Text,
                GuardianOccup = txtGuardiansOccup.Text,
                Relationship = txtRelationship.Text,
                ContactInCaseOfEmergency = txtContactInEmergency.Text,
                Status = Status.Pre_registration,
            };
            requirement = new Requirement
            {
                FORM137 = false,
                GM = false,
                NSO = false,
                PDS = false
            };
        }
    }
}
