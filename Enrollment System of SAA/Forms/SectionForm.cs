using Enrollment_System_of_SAA.DAL;
using Enrollment_System_of_SAA.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class SectionForm : Form
    {
        private SAADBContext _context = null;

        private Section _section = null;

        private void SectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbAdviser.DataSource = Teacher.TeacherList();
                cbAdviser.ValueMember = "TeacherId";
                cbAdviser.DisplayMember = "FullName";

                cbGradeLevel.DataSource = GradeLevel.GradeLevels();

                if (_section == null)
                {
                    cbAdviser.SelectedIndex = -1;
                    cbGradeLevel.SelectedIndex = -1;
                }
                else
                {
                    txtSectionName.Text = _section.SectionName;
                    cbAdviser.Text = _section.Teacher.FullName;
                    cbGradeLevel.Text = _section.GradeLevel;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in loading data.");
            }
        }

        public SectionForm()
        {
            InitializeComponent();
            _context = new SAADBContext();
        }

        public SectionForm(int SectionId)
        {
            InitializeComponent();
            _context = new SAADBContext();
            _section = _context.Sections.FirstOrDefault(t => t.SectionId == SectionId);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            Section sectionInForm = new Section();
            sectionInForm.SectionName = txtSectionName.Text;
            sectionInForm.GradeLevel = cbGradeLevel.Text;
            sectionInForm.Teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == (int)cbAdviser.SelectedValue);

            try
            {
                if (_section == null)
                {
                    _context.Sections.Add(sectionInForm);
                }
                else
                {
                    _section.SectionName = sectionInForm.SectionName;
                    _section.GradeLevel = sectionInForm.GradeLevel;
                    _section.Teacher = sectionInForm.Teacher;
                }
                _context.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving record failed.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
