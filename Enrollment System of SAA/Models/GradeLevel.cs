using System.Collections.Generic;

namespace Enrollment_System_of_SAA.Models
{
    class GradeLevel
    {
        public static string G7 = "Grade 7";
        public static string G8 = "Grade 8";
        public static string G9 = "Grade 9";
        public static string G10 = "Grade 10";
        public static string G11 = "Grade 11";
        public static string G12 = "Grade 12";

        public static List<string> GradeLevels()
        {
            List<string> gradeLevels = new List<string>();
            gradeLevels.Add(GradeLevel.G7);
            gradeLevels.Add(GradeLevel.G8);
            gradeLevels.Add(GradeLevel.G9);
            gradeLevels.Add(GradeLevel.G10);
            gradeLevels.Add(GradeLevel.G11);
            gradeLevels.Add(GradeLevel.G12);
            return gradeLevels;
        }
    }
}
