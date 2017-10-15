using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class Home : Form
    {
        private static Home _instance;

        public Home()
        {
            InitializeComponent();
            _instance = this;
        }

        public void LoadMainPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }

        public void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.TopMost = true;
            MainPanel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        public static Home getInstance()
        {
            if (_instance == null)
            {
                _instance = new Home();
            }
            return _instance;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void tab1EnrollmentModule_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new EnrollmentModule());
        }

        private void tab2EnrollmentHistory_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new EnrollmentList());
        }

        private void tab8SubjectModule_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new ManageSubjects());
        }

        private void tab3StudentMasterList_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new StudentMasterList());
        }

        private void tab4RequirementCheckList_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new RequirementChecklist());
        }

        private void tab5StudentRecord_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new StudentRecord());
        }

        private void tab7ClassList_Click(object sender, EventArgs e)
        {
            LoadMainPanel(new Schedule());
        }
    }
}
