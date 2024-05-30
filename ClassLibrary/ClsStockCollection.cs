using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class ClsStockCollection
    {
        

            public ClsStockCollection() 
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Stock_SelelctAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsStock AnStock = new ClsStock();
                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.CategoryName = Convert.ToString(DB.DataTable.Rows[Index]["CategoryName"]);
                AnStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AnStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AnStock.CreatedOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedOn"]);
                mStockList.Add(AnStock);
                Index++;




            }
        }
        
        List<ClsStock> mStockList = new List<ClsStock>();
        ClsStock mThisStock = new ClsStock();
        public List<ClsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
               mStockList = value;
            }


        }
        

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //////
            }
        }
        public ClsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {

                mThisStock = value;
            }
        }

        public int Add()
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ThisStock.ProductName);
            DB.AddParameter("@CategoryName", ThisStock.CategoryName);
            DB.AddParameter("@Price", ThisStock.Price);
            DB.AddParameter("@StockQuantity", ThisStock.StockQuantity);
            DB.AddParameter("@CreatedOn", ThisStock.CreatedOn);
            DB.AddParameter("@InStock", ThisStock.InStock);
            return DB.Execute("sproc_Stock_FilterByProductID");






        }
    }
}