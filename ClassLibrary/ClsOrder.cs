using System;

namespace ClassLibrary
{
    public class ClsOrder
    {
        public bool OrderStatus { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        
    }
}