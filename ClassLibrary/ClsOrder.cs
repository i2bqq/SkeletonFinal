using System;
using System.Data;
using System.Diagnostics;

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
        public string OrderDetails
        {
            get
            {
                return $"OrderID: {OrderID}, CustomerID: {CustomerID}, OrderDate: {OrderDate.ToShortDateString()}, TotalAmount: {TotalAmount:C}";
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

        public string Valid(object orderDate, object totalAmount)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            double PriceTemp;
            if (totalAmount == null || totalAmount == "")
            {
                Error = Error + "Total Amount cannot be left blank : ";
            }
            else
            {
                try
                {
                    PriceTemp = Convert.ToDouble(totalAmount);

                    if (PriceTemp < 0.10)
                    {
                        Error = Error + "total Amount cannot be less than 0.1 : ";
                    }

                    if (PriceTemp > 10000.00)
                    {
                        Error = Error + "total Amount cannot be greater than 10,000";
                    }
                }
                catch
                {
                    Error = Error + "The totalAmount was not valid : ";
                }
                DateTime DateComp = DateTime.Now.Date;
                try
                {
                    //copy the arrivedOn value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(orderDate);

                    if (DateTemp < DateComp)//compare the dates
                    {
                        //record the error
                        Error = Error + "The date cannot be in the past :";
                    }

                    if (DateTemp > DateComp)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the future :";
                    }
                }


                catch
                {
                    Error = Error + "The date was not a valid date : ";
                }



            }
            return Error;

        }
    }
}

