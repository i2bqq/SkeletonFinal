using System;

namespace ClassLibrary
{
    public class ClsStock
    {


        public ClsStock()
        {
        }
        private Int32 mProductID;
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
        private string mProductName;
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        private string mCategoryName;
        public string CategoryName
        {
            get
            {
                return mCategoryName;
            }
            set
            {
                mCategoryName = value;
            }
        }
        private Decimal mPrice;
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private int mStockQuantity;
        public int StockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        }
        private DateTime mCreatedOn;
        public DateTime CreatedOn
        {
            get
            {
                return mCreatedOn;
            }
            set
            {
                mCreatedOn = value;
            }
        }
        private Boolean mInStock;
        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }

        public bool Find(int staffID)
        {
            mProductID = 21;
            mProductName = "Make up";
            mCategoryName = "Face";
            mPrice = 123;
            mStockQuantity = 2;
            mCreatedOn = Convert.ToDateTime("12/12/2012");
            mInStock=true;
            return true;
        }
    }
}