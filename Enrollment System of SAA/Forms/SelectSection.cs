using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class SelectSection : Form
    {
        private int _studentId;
        public SelectSection(int StudentId)
        {
            InitializeComponent();
            _studentId = StudentId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
