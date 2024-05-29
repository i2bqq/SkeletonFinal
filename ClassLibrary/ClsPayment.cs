using System;

namespace ClassLibrary
{
    public class ClsPayment
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public Decimal Amount { get; set; }
        public String Status { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}