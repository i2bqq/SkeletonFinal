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

        public bool Find(int ProductID)
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_Stock_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mCategoryName = Convert.ToString(DB.DataTable.Rows[0]["CategoryName"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mCreatedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedOn"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public string Valid(string productName, string categoryName, string price, string stockQuantity, string createdOn)
        {
            double PriceTemp;
            Int32 QuantityTemp;
            DateTime DateTemp;


            String Error = "";
            if(productName.Length == 0)
            {
                Error = Error + "The Product Name Cannot be blank : ";
            }
            if(productName.Length > 50)
            {
                Error = Error + "The Product Name Cannot Be over 50 Characters";
            }
            if (categoryName.Length == 0)
            {
                Error = Error + "The Category Name Cannot be blank : ";
            }
            if (categoryName.Length > 50)
            {
                Error = Error + "The Category Name Cannot Be over 50 Characters";
            }
            if (price == null || price == "")
            {
                Error = Error + "Price cannot be left blank : ";
            }
            else
            {
                try
                {
                    PriceTemp = Convert.ToDouble(price);

                    if (PriceTemp < 0.10)
                    {
                        Error = Error + "Price cannot be less than 0.1 : ";
                    }

                    if (PriceTemp > 10000.00)
                    {
                        Error = Error + "Price cannot be greater than 10,000";
                    }
                }
                catch
                {
                    Error = Error + "The price was not valid : ";
                }
            }
            if (stockQuantity == null || stockQuantity == "")
            {
                Error = Error + "Quantity cannot be left blank : ";
            }
            else
            {
                try
                {
                    QuantityTemp = Convert.ToInt32(stockQuantity);

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
                DateTime DateComp = DateTime.Now.Date;
                try
                {
                    //copy the arrivedOn value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(createdOn);

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