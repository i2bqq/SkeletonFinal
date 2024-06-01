using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class ClsPayment
    {
        private int mPaymentID;
        private int mOrderID;
        private DateTime mPaymentDate;
        private string mPaymentMethod;
        private decimal mAmount;
        private bool mStatus;
        private DateTime mCreatedOn;

        public int PaymentID
        {
            get { return mPaymentID; }
            set { mPaymentID = value; }
        }

        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        public DateTime PaymentDate
        {
            get { return mPaymentDate; }
            set { mPaymentDate = value; }
        }

        public string PaymentMethod
        {
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }

        public decimal Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        public bool Status
        {
            get { return mStatus; }
            set { mStatus = value; }
        }

        public DateTime CreatedOn
        {
            get { return mCreatedOn; }
            set { mCreatedOn = value; }
        }

        public bool Find(int OrderID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sp_FindPaymentByOrderID");

            if (DB.Count == 1)
            {
                // Set the private data members
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                mCreatedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedOn"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FindByPaymentID(int PaymentID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", PaymentID);
            DB.Execute("sp_FindPaymentByPaymentID");

            if (DB.Count == 1)
            {
                // Set the private data members
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                mCreatedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedOn"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
