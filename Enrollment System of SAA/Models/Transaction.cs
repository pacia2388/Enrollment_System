using System;

namespace Enrollment_System_of_SAA.Models
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public int PaymentId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
        public string ReferenceNum { get; set; }

        //navigation
        public virtual Payment Payment { get; set; }
    }
}
