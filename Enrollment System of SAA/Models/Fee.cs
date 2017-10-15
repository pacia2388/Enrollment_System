using System.Collections.Generic;

namespace Enrollment_System_of_SAA.Models
{
    class Fee
    {
        public Fee()
        {
            Payment = new HashSet<Payment>();
        }
        public byte FeeId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        //navigation
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
