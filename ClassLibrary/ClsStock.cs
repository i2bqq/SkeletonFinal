using System;

namespace ClassLibrary
{
    public class ClsStock
    {
        public ClsStock()
        {
        }

        public object ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Brand { get; set; }
        public int OrderID { get; set; }
    }
}