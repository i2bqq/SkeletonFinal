using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class ClsStockCollection
    {
        

            public ClsStockCollection() 
        {
            
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Stock_SelelctAll");
            PopulateArray(DB);
            
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
            return DB.Execute("sproc_Stock_insert");






        }

        public void Update()
        {
            clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("ProductID", mThisStock.ProductID);
            DB.AddParameter("ProductName", mThisStock.ProductName);
            DB.AddParameter("CategoryName", mThisStock.CategoryName);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("CreatedOn", mThisStock.CreatedOn);
            DB.AddParameter("InStock", mThisStock.InStock);
            DB.Execute("sproc_Stock_update");



        }

        public void Delete()
        {
            clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.Execute("sproc_stock_delete");
        }

        public void ReportByCategoryName(string CategoryName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CategoryName", CategoryName);
            DB.Execute("sproc_reportbycategoryname");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<ClsStock>();
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
    }
}