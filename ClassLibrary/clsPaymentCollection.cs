using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        private List<ClsPayment> mPaymentList = new List<ClsPayment>();
        private ClsPayment mThisPayment = new ClsPayment();

        public List<ClsPayment> PaymentList
        {
            get { return mPaymentList; }
            set { mPaymentList = value; }
        }

        public int Count
        {
            get { return mPaymentList.Count; }
            set
            {
                throw new InvalidOperationException("Cannot set the count directly. Modify the collection instead.");
            }
        }

        public ClsPayment ThisPayment
        {
            get { return mThisPayment; }
            set { mThisPayment = value; }
        }

        public clsPaymentCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sp_GetAllPayments");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@Status", mThisPayment.Status ? "true" : "false");
            DB.AddParameter("@CreatedOn", mThisPayment.CreatedOn);
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@Status", mThisPayment.Status ? "true" : "false");
            DB.AddParameter("@CreatedOn", mThisPayment.CreatedOn);
            DB.Execute("sproc_tblPayment_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.Execute("sproc_tblPayment_Delete");
        }

        public void ReportByPaymentMethod(string PaymentMethod)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentMethod", PaymentMethod);
            DB.Execute("sproc_tblPayment_FilterByPaymentMethod");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int recordCount = DB.Count;
            mPaymentList = new List<ClsPayment>();
            for (int i = 0; i < recordCount; i++)
            {
                ClsPayment aPayment = new ClsPayment();
                aPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[i]["PaymentID"]);
                aPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[i]["OrderID"]);
                aPayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[i]["PaymentDate"]);
                aPayment.PaymentMethod = Convert.ToString(DB.DataTable.Rows[i]["PaymentMethod"]);
                aPayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[i]["Amount"]);
                string statusStr = Convert.ToString(DB.DataTable.Rows[i]["Status"]);
                aPayment.Status = statusStr.ToLower() == "true" || statusStr == "1";
                aPayment.CreatedOn = Convert.ToDateTime(DB.DataTable.Rows[i]["CreatedOn"]);
                mPaymentList.Add(aPayment);
            }
        }
    }
}
