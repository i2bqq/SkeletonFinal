using System;
using System.Data;

namespace ClassLibrary
{
    public class ClsOrder
    {
        //private data member for the adress id proeprty
        private Int32 mOrderID;
        //OrderID public property
        public int OrderID
        {
            get
            {
                //this line sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line allows data into the property
                mOrderID = value;
            }
        }

        private Boolean mOrderStatus;
        public bool OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }
        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private DateTime mDateTime;
        public DateTime OrderDate
        {
            get
            {
                return mDateTime;
            }
            set
            {
                mDateTime = value;
            }
        }
        private Decimal mTotalAmount;
        public decimal TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }
        public bool Find(Int32 OrderID)
        {
            //set the private data members to the test data value
            mOrderID = 21;
            mOrderStatus = true;
            mCustomerID = 21;
            mDateTime = Convert.ToDateTime("10/02/2002");
            mTotalAmount = Convert.ToDecimal("100.00");
            //always return true
            return true;
        }
    }
}
