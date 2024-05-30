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
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
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

        //FIND METHOD
        public bool Find(int OrderID)
        {
            //create a instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the adress id to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("Sproc_tblOrder_FilterByOrderID");
            if(DB.Count == 1)
            {
                //set the private data members to the test data value
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderStatus"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                //always return true
                return true;
            }
            //if record was not found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}

