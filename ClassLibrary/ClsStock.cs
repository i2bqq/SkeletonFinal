using System;

namespace ClassLibrary
{
    public class ClsStock
    {

        private Int32 mProductID;

        public ClsStock()
        {
        }

        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public Decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool InStock { get; set; }

        public bool Find(int staffID)
        {
            return true;
        }
    }
}