using Enrollment_System_of_SAA.DAL;
using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class RequirementChecklist : UserControl
    {
        private SAADBContext _context = null;

        public RequirementChecklist()
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

        private void RequirementChecklist_Load(object sender, EventArgs e)
        {
            //            var result = (from requirement in _context.Requirements
            //                          join student in _context.Students
            //                              on requirement.Id equals student.StudentId
            //                          orderby student.StudentNo
            //                          select new
            //                          {
            //                              student.StudentNo,
            //                              student.FirstName,
            //                              student.MiddleName,
            //                              student.LastName,
            //                              requirement.PDS,
            //                              requirement.NSO,
            //                              requirement.GM,
            //                              requirement.FORM137
            //                          }).ToList();
            //
            //            dgvRequirements.DataSource = result;

            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvRequirements.Columns[0].HeaderText = "Student No";
            dgvRequirements.Columns[1].HeaderText = "First Name";
            dgvRequirements.Columns[2].HeaderText = "Middle Name";
            dgvRequirements.Columns[3].HeaderText = "Last Name";
            dgvRequirements.Columns[4].HeaderText = "PDS";
            dgvRequirements.Columns[5].HeaderText = "NSO";
            dgvRequirements.Columns[6].HeaderText = "GM";
            dgvRequirements.Columns[7].HeaderText = "FORM137";

            dgvRequirements.Columns[0].Width = 100;
            dgvRequirements.Columns[1].Width = 150;
            dgvRequirements.Columns[2].Width = 150;
            dgvRequirements.Columns[3].Width = 150;
            dgvRequirements.Columns[4].Width = 90;
            dgvRequirements.Columns[5].Width = 90;
            dgvRequirements.Columns[6].Width = 90;
            dgvRequirements.Columns[7].Width = 90;
        }
    }
}
