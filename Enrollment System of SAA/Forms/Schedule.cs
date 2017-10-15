using Enrollment_System_of_SAA.DAL;
using Enrollment_System_of_SAA.Models;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    public partial class Schedule : UserControl
    {
        private SAADBContext _context = null;
        private int sectionRowIndex = 0;
        private int scheduleRowIndex = 0;
        private int _sectionId = 0;
        private bool scheduleControls = false;
        private bool scheduleDetailsControls = false;
        private ClassSchedule _classSchedule = null;

        public Schedule()
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

        private void ClassList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSection();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading data");
            }

            dgvListOfClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        }

        private void LoadSection()
        {
            var result = (from section in _context.Sections
                          join teacher in _context.Teachers
                              on section.TeahcerId equals teacher.TeacherId
                          let FullName = teacher.LastName + ", " + teacher.FirstName
                          orderby section.GradeLevel
                          select new
                          {
                              section.SectionId,
                              section.GradeLevel,
                              section.SectionName,
                              FullName
                          }).ToList();

            dgvListOfClasses.DataSource = result;
            dgvListOfClasses.Columns[3].Width = 400;
            dgvListOfClasses.Columns[0].Visible = false;
        }

        private void addSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SectionForm newSection = new SectionForm();
            newSection.FormClosed += delegate
            {
                LoadSection();
            };
            newSection.ShowDialog();
        }

        private void editSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvListOfClasses.SelectedCells.Count > 0)
            {
                int sectionId = Convert.ToInt32(dgvListOfClasses.Rows[sectionRowIndex].Cells["SectionId"].Value.ToString());
                SectionForm editSection = new SectionForm(sectionId);
                editSection.FormClosed += delegate
                {
                    LoadSection();
                };
                editSection.ShowDialog();
            }
        }

        private void deleteSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete this section?", "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            try
            {
                if (dgvListOfClasses.SelectedCells.Count > 0)
                {
                    var sectionId = Convert.ToInt32(dgvListOfClasses.Rows[sectionRowIndex].Cells["SectionId"].Value.ToString());
                    var sectionToRemove = _context.Sections.FirstOrDefault(t => t.SectionId == sectionId);
                    _context.Sections.Remove(sectionToRemove);
                    _context.SaveChanges();
                }
                MessageBox.Show("Record removed successfully");
                LoadSection();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Transaction failed");
            }
        }

        private void dgvListOfClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sectionRowIndex = dgvListOfClasses.Rows[e.RowIndex].Index;
                _sectionId = Convert.ToInt32(dgvListOfClasses.Rows[sectionRowIndex].Cells["SectionId"].Value);
                lblSection.Text = dgvListOfClasses.Rows[sectionRowIndex].Cells[2].Value.ToString();
                EnableControls();
                LoadSchedules();
            }
            catch { }
        }

        private string GetDays()
        {
            StringBuilder days = new StringBuilder();
            if (chkMonday.Checked)
                days.Append("Mon ");
            if (chkTuesday.Checked)
                days.Append("Tue ");
            if (chkWednesday.Checked)
                days.Append("Wed ");
            if (chkThursday.Checked)
                days.Append("Thu ");
            if (chkFriday.Checked)
                days.Append("Fri ");
            if (chkSaturday.Checked)
                days.Append("Sat");
            return days.ToString();
        }

        private void EnableControls()
        {
            addSubjectToSchedule.Enabled = true;
            editSubjectFromSchedule.Enabled = true;
            deleteSubjectFromSchedule.Enabled = true;
            printPreview.Enabled = true;
        }

        private void addSubjectToSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadControlData(-1, null);
            groupBoxDetails.Enabled = true;
        }

        private void LoadControlData(int row, ClassSchedule schedule)
        {
            try
            {
                string gradelvl = _context.Sections.FirstOrDefault(t => t.SectionId == _sectionId).GradeLevel;

                cbSubjects.DataSource = _context.Subjects.Where(t => t.GradeLevel == gradelvl).ToList();
                cbSubjects.DisplayMember = "SubjectName";
                cbSubjects.ValueMember = "SubjectId";

                cbRooms.DataSource = _context.Rooms.ToList();
                cbRooms.DisplayMember = "RoomName";
                cbRooms.ValueMember = "RoomId";

                cbTeachers.DataSource = Teacher.TeacherList();
                cbTeachers.DisplayMember = "FullName";
                cbTeachers.ValueMember = "TeacherId";

                if (row == -1)
                {
                    cbSubjects.SelectedIndex = -1;
                    cbRooms.SelectedIndex = -1;
                    cbTeachers.SelectedIndex = -1;
                }
                else
                {
                    cbSubjects.Text = dgvSubjectList.Rows[row].Cells["SubjectName"].Value.ToString();
                    cbRooms.Text = dgvSubjectList.Rows[row].Cells["RoomName"].Value.ToString();
                    cbTeachers.Text = dgvSubjectList.Rows[row].Cells["Instructor"].Value.ToString();
                    txtFrom.Text = dgvSubjectList.Rows[row].Cells["StartTime"].Value.ToString();
                    txtTo.Text = dgvSubjectList.Rows[row].Cells["EndTime"].Value.ToString();
                    string days = dgvSubjectList.Rows[row].Cells["Days"].Value.ToString();
                    days.Trim();
                    LoadDays(days);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in loading data");
            }
        }

        private void LoadDays(string days)
        {
            if (days.ToLower().Contains("mon"))
                chkMonday.Checked = true;
            if (days.ToLower().Contains("tue"))
                chkTuesday.Checked = true;
            if (days.ToLower().Contains("wed"))
                chkWednesday.Checked = true;
            if (days.ToLower().Contains("thu"))
                chkThursday.Checked = true;
            if (days.ToLower().Contains("fri"))
                chkFriday.Checked = true;
            if (days.ToLower().Contains("sat"))
                chkSaturday.Checked = true;
        }

        private void LoadSchedules()
        {
            var result = (from schedule in _context.ClassSchedules
                          join subject in _context.Subjects
                              on schedule.SubjectId equals subject.SubjectId
                          join room in _context.Rooms
                              on schedule.RoomId equals room.RoomId
                          join teacher in _context.Teachers
                              on schedule.TeacherId equals teacher.TeacherId
                          let Instructor = teacher.LastName + ", " + teacher.FirstName
                          where schedule.SectionId == _sectionId
                          orderby schedule.Meridiem, schedule.StartTime
                          select new
                          {
                              schedule.Id,
                              subject.SubjectName,
                              schedule.StartTime,
                              schedule.EndTime,
                              schedule.Days,
                              room.RoomName,
                              Instructor
                          }).ToList();
            dgvSubjectList.DataSource = result;

            dgvSubjectList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvSubjectList.Columns[0].Visible = false;
        }

        private void editSubjectFromSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvSubjectList.SelectedCells.Count > 0)
            {
                groupBoxDetails.Enabled = true;
            }
        }

        private void deleteSubjectFromSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int scheduleId = Convert.ToInt32(dgvSubjectList.Rows[scheduleRowIndex].Cells["Id"].Value.ToString());
            ClassSchedule scheduleToDelete = _context.ClassSchedules.FirstOrDefault(t => t.Id == scheduleId);
            _context.ClassSchedules.Remove(scheduleToDelete);
            _context.SaveChanges();
            LoadSchedules();

        }

        private void dgvSubjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormHelper.ClearForm(groupBoxDetails.Controls);
                int scheduleId = Convert.ToInt32(dgvSubjectList.Rows[e.RowIndex].Cells[0].Value.ToString());
                _classSchedule = _context.ClassSchedules.FirstOrDefault(t => t.Id == scheduleId);
                LoadControlData(e.RowIndex, _classSchedule);
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_classSchedule == null)
                {
                    ClassSchedule newClassSchedule = new ClassSchedule();
                    newClassSchedule.SectionId = _sectionId;
                    newClassSchedule.SubjectId = Convert.ToInt32(cbSubjects.SelectedValue);
                    newClassSchedule.RoomId = Convert.ToInt32(cbRooms.SelectedValue);
                    newClassSchedule.TeacherId = Convert.ToInt32(cbTeachers.SelectedValue);
                    newClassSchedule.StartTime = txtFrom.Text;
                    newClassSchedule.EndTime = txtTo.Text;
                    newClassSchedule.Days = GetDays();
                    newClassSchedule.Term = lblTerm.Text;
                    newClassSchedule.Meridiem = GetMeridiem(txtFrom.Text);

                    _context.ClassSchedules.Add(newClassSchedule);
                }
                else
                {
                    ClassSchedule classScheduleFromDb = _context.ClassSchedules.FirstOrDefault(t => t.Id == _classSchedule.Id);
                    classScheduleFromDb.SectionId = _sectionId;
                    classScheduleFromDb.SubjectId = Convert.ToInt32(cbSubjects.SelectedValue);
                    classScheduleFromDb.RoomId = Convert.ToInt32(cbRooms.SelectedValue);
                    classScheduleFromDb.TeacherId = Convert.ToInt32(cbTeachers.SelectedValue);
                    classScheduleFromDb.StartTime = txtFrom.Text;
                    classScheduleFromDb.EndTime = txtTo.Text;
                    classScheduleFromDb.Days = GetDays();
                    classScheduleFromDb.Term = lblTerm.Text;
                }

                FormHelper.ClearForm(groupBoxDetails.Controls);
                _context.SaveChanges();
                LoadSchedules();
                groupBoxDetails.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Saving record failed");
            }
        }

        private string GetMeridiem(string time)
        {
            int hour = Convert.ToInt32(time.Substring(0, 2));
            return (hour >= 7 && hour <= 12 ? "AM" : "PM");
        }

        private void printPreview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
//            rptScheduleModel scheduleDetails = new rptScheduleModel();
            ClassSchedule classScheduleModel = new ClassSchedule();
            PrintScedule printScedule = new PrintScedule();
            printScedule.ShowDialog();
        }

//        private DataTable GetScheduleDetails()
//        {
//            DataTable dt = new DataTable();
//            var section = _context.Sections.FirstOrDefault(t => t.SectionId == _sectionId);
//            var teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == section.TeahcerId);
//            var grade = section.GradeLevel;
//            var term = SAADBDataSet.GetScheduleDetailDataTable(dt);
//        }
    }
}
