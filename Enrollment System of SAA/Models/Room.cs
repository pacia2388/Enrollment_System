using System;
using System.Collections.Generic;

namespace Enrollment_System_of_SAA.Models
{
    class Room
    {
        public Room()
        {
            ClassSchedules = new HashSet<ClassSchedule>();
        }
        public byte RoomId { get; set; }
        public string RoomName { get; set; }

        //navigation
        public virtual ICollection<ClassSchedule> ClassSchedules { get; set; }
    }
}
