using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsOrderItemCollection
    {
        public ClsOrderItemCollection()
        {
            
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_orderItems_SelelctAll");
            PopulateArray(DB);


        }







        List<ClsOrderItem> mOrderItemList = new List<ClsOrderItem>();
        ClsOrderItem mThisOrderItem = new ClsOrderItem();
        public List<ClsOrderItem> OrderItemList
        {
            get { return mOrderItemList; }
            set { mOrderItemList = value; }
        }
        public int Count
        {
            get
            {
                return OrderItemList.Count;
            }
            set
            {
                //
            }
        }
        public ClsOrderItem ThisOrderItem
        {
            get { return mThisOrderItem; }
            set { mThisOrderItem = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderID", mThisOrderItem.OrderID);
            DB.AddParameter("ProductID", mThisOrderItem.ProductID);
            DB.AddParameter("Quantity",mThisOrderItem.Quantity);
            DB.AddParameter("UnitPrice", mThisOrderItem.UnitPrice);
            DB.AddParameter("TotalPrice", mThisOrderItem.TotalPrice);
            return DB.Execute("sproc_OrderItem_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderItemID", ThisOrderItem.OrderItemID);
            DB.AddParameter("OrderID", ThisOrderItem.OrderID);

            DB.AddParameter("ProductID", ThisOrderItem.ProductID);

            DB.AddParameter("Quantity", ThisOrderItem.Quantity);

            DB.AddParameter("UnitPrice", ThisOrderItem.UnitPrice);

            DB.AddParameter("TotalPrice", ThisOrderItem.TotalPrice);

            DB.Execute("sproc_OrderItem_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderItem", mThisOrderItem.OrderItemID);
            DB.Execute("sproc_OrderItem_delete");
        
        }

        public void ReportByOrderID(string OrderID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("OrderID", OrderID);
            DB.Execute("sproc_OrderItem_FilterbyOrderID");
            PopulateArray(DB);
         
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderItemList = new List<ClsOrderItem>();
            while (Index < RecordCount)
            {
                ClsOrderItem AnOrderItem = new ClsOrderItem();
                AnOrderItem.OrderItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderItemID"]);
                AnOrderItem.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderItem.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrderItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);

                AnOrderItem.UnitPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["UnitPrice"]);
                AnOrderItem.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                mOrderItemList.Add(AnOrderItem);
                Index++;


            }
        }
    }
}