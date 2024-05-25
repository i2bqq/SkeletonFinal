using System;

namespace ClassLibrary
{
    public class ClsPayment
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Amount { get; set; }
        public bool Status { get; set; }
    }
}