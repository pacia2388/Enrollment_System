using Enrollment_System_of_SAA.Models;
using System;
using System.Windows.Forms;

namespace Enrollment_System_of_SAA.Forms
{
    static class FormHelper
    {
        public static void ClearAndEnableControls(GroupBox.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                    ctrl.Enabled = true;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                    ctrl.Enabled = true;
                }
                else if (ctrl is Bunifu.Framework.UI.BunifuImageButton)
                {
                    ctrl.Enabled = true;
                }
                else
                    ClearAndEnableControls(ctrl.Controls);
            }
        }

        public static void ClearForm(GroupBox.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl is Bunifu.Framework.UI.BunifuCheckbox)
                {
                    ((Bunifu.Framework.UI.BunifuCheckbox)ctrl).Checked = false;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Clear();
                }
                else
                    ClearAndEnableControls(ctrl.Controls);
            }
        }

        public static void DisplayValuesInConsoleWindow(ClassSchedule newClassSchedule)
        {
            Console.WriteLine("Section = " + newClassSchedule.SectionId.ToString());
            Console.WriteLine("Subject = " + newClassSchedule.SubjectId.ToString());
            Console.WriteLine("Room = " + newClassSchedule.RoomId.ToString());
            Console.WriteLine("Teacher = " + newClassSchedule.TeacherId.ToString());
            Console.WriteLine("Start = " + newClassSchedule.StartTime.ToString());
            Console.WriteLine("End = " + newClassSchedule.EndTime.ToString());
            Console.WriteLine("Days = " + newClassSchedule.Days);
        }
    }

}

