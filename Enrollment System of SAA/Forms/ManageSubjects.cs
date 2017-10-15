using Enrollment_System_of_SAA.DAL;
using Enrollment_System_of_SAA.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class ManageSubjects : UserControl
    {
        private SAADBContext _context = null;

        public ManageSubjects()
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

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            var result = (from subject in _context.Subjects
                          select new
                          {
                              subject.SubjectId,
                              subject.SubjectCode,
                              subject.SubjectName,
                              subject.Description,
                              subject.GradeLevel
                          }).ToList();

            dgvSubjectList.DataSource = result;

            dgvSubjectList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvSubjectList.Columns[0].HeaderText = "ID";
            dgvSubjectList.Columns[1].HeaderText = "Code";
            dgvSubjectList.Columns[2].HeaderText = "Title";
            dgvSubjectList.Columns[3].HeaderText = "Description";
            dgvSubjectList.Columns[4].HeaderText = "Grade";

            dgvSubjectList.Columns[0].Width = 100;
            dgvSubjectList.Columns[1].Width = 100;
            dgvSubjectList.Columns[2].Width = 150;
            dgvSubjectList.Columns[3].Width = 500;
            dgvSubjectList.Columns[4].Width = 100;

            lblCount.Text = result.Count.ToString();
        }


        private void dgvSubjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvSubjectList.Rows[e.RowIndex].Cells["SubjectId"].Value);
            var selectedRow = _context.Subjects.SingleOrDefault(t => t.SubjectId == id);

            if (selectedRow != null)
            {
                txtID.Text = selectedRow.SubjectId.ToString();
                txtCode.Text = selectedRow.SubjectCode;
                txtTitle.Text = selectedRow.SubjectName;
                txtDescription.Text = selectedRow.Description;
                cbGradeLevel.Text = selectedRow.GradeLevel;
            }
        }

        private void btnNewSubject_Click(object sender, EventArgs e)
        {
            groupSubject.Enabled = true;
            FormHelper.ClearForm(groupSubject.Controls);
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            groupSubject.Enabled = true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            Subject subjectInForm = new Subject
            {
                SubjectId = Convert.ToInt32(txtID.Text),
                SubjectCode = txtCode.Text,
                SubjectName = txtTitle.Text,
                Description = txtDescription.Text,
                GradeLevel = cbGradeLevel.SelectedText
            };

            Subject subjectInDb = _context.Subjects.SingleOrDefault(t => t.SubjectId == Convert.ToInt32(txtID.Text));

            if (subjectInDb == null)
            {
                _context.Subjects.Add(subjectInForm);
            }
            else
            {
                subjectInDb.SubjectCode = subjectInForm.SubjectCode;
                subjectInDb.SubjectName = subjectInForm.SubjectName;
                subjectInDb.Description = subjectInForm.Description;
                subjectInDb.GradeLevel = subjectInForm.GradeLevel;
            }
            
            _context.SaveChanges();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(txtID.Text);
            Subject subToRemove = _context.Subjects.Single(t => t.SubjectId == Id);
            _context.Subjects.Remove(subToRemove);
            _context.SaveChanges();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHelper.ClearForm(groupSubject.Controls);
        }
    }
}
