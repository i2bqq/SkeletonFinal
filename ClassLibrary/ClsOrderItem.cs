using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class ClsOrderItem
    {
        public ClsOrderItem()
        {
        }
        private Int32 mOrderItemID;
        public int OrderItemID
        {
            get
            {
                return mOrderItemID;
            }
            set
            {
                mOrderItemID = value;
            }
        }
        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        private Int32 mProductID;
        public int ProductID
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
        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private Decimal mUnitPrice;
        public decimal UnitPrice
        {
            get
            {
                return mUnitPrice;
            }
            set
            {
                mUnitPrice = value;
            }
        }
        private Decimal mTotalPrice;
        public decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public bool Find(int OrderItemID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderItemID", OrderItemID);
            DB.Execute("Sproc_OrderItem_FilterByOrderItemID");
            if (DB.Count == 1)
            {
                mOrderItemID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderItemID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mUnitPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["UnitPrice"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string unitPrice, string totalPrice, string quantity)
        {
            String Error = "";
            Int32 QuantityTemp;
            double PriceTemp;
            double TotalTemp;


            if (quantity == null || quantity == "")
            {
                Error = Error + "Quantity cannot be left blank : ";
            }
            else
            {
                try
                {
                    QuantityTemp = Convert.ToInt32(quantity);

                    if (QuantityTemp < 0)
                    {
                        Error = Error + "The quantity cannot be less than 0 : ";
                    }

                    if (QuantityTemp > 200)
                    {
                        Error = Error + "The quantity cannot be greater than 200 : ";
                    }


                }
                catch
                {
                    Error = Error + "The quantity was not valid : ";
                }
                
            }
            if (unitPrice == null || unitPrice == "")
            {
                Error = Error + "Price cannot be left blank : ";
            }
            else
            {
                try
                {
                    PriceTemp = Convert.ToDouble(unitPrice);

                    if (PriceTemp < 0.10)
                    {
                        Error = Error + "Unit Price cannot be less than 0.1 : ";
                    }

                    if (PriceTemp > 10000.00)
                    {
                        Error = Error + "Unit Price cannot be greater than 10,000";
                    }
                }
                catch
                {
                    Error = Error + "The Unit price was not valid : ";
                }
                if (totalPrice == null || totalPrice == "")
                {
                    Error = Error + "Price cannot be left blank : ";
                }
                else
                {
                    try
                    {
                        TotalTemp = Convert.ToDouble(totalPrice);

                        if (TotalTemp < 0.10)
                        {
                            Error = Error + "Unit Price cannot be less than 0.1 : ";
                        }

                        if (TotalTemp > 10000.00)
                        {
                            Error = Error + "Unit Price cannot be greater than 10,000";
                        }
                    }
                    catch
                    {
                        Error = Error + "The Unit price was not valid : ";
                    }
                }
            }
            return Error;
        }
    }
}