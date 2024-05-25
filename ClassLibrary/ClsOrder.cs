using System;

namespace ClassLibrary
{
    public class ClsOrder
    {
        public ClsOrder()
        {
        }

        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
    }
}