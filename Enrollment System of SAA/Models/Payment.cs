using System;
using System.Collections.Generic;
using Enrollment_System_of_SAA.Forms;

namespace Enrollment_System_of_SAA.Models
{
    class Payment
    {
        public Payment()
        {
            Fees = new HashSet<Fee>();
            Transactions = new HashSet<Transaction>();
        }
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Term { get; set; }
        public DateTime DueDate { get; set; }

        //navigation
        public virtual Student Student { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
