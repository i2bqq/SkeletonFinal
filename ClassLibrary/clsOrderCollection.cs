﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<ClsOrder> mOrderList = new List<ClsOrder>();
        //private member data for ThisOrder
        ClsOrder mThisOrder = new ClsOrder();
        public List<ClsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public ClsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Order_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database of the values of mThisOrder
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("OrderStatus", mThisOrder.OrderStatus);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //conect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fo the stored procedure
            DB.AddParameter("@OrderID",mThisOrder.OrderID);
            //execute the sp
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerID(string CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            //send the customerID parameer to the database
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //variabe for index
            Int32 Index = 0;
            //variable to store the count
            Int32 RecordCount;
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<ClsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                ClsOrder AnOrder = new ClsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderStatus"]);
                //add he record to the private data server
                mOrderList.Add(AnOrder);
                //point at the next record
                Index ++;
            }
        }
    }
}
