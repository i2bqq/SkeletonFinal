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

        public bool Find(int PaymentID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", PaymentID);
            DB.Execute("sproc_tblPayment_FilterByPaymentID");
            if (DB.Count == 1)
            {
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                string statusStr = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mStatus = statusStr.ToLower() == "true" || statusStr == "1";
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

        public string Valid(string orderID, string paymentDate, string paymentMethod, string amount, string status, string createdOn)
        {
            // Create a string variable to store the error
            String error = "";
            DateTime dateTemp;
            decimal amountTemp;
            bool statusTemp;

            // OrderID validation
            if (string.IsNullOrEmpty(orderID))
            {
                error += "The order ID may not be blank. ";
            }
            else if (!int.TryParse(orderID, out _))
            {
                error += "The order ID must be a valid integer. ";
            }

            // PaymentDate validation
            if (string.IsNullOrEmpty(paymentDate))
            {
                error += "The payment date may not be blank. ";
            }
            else if (!DateTime.TryParse(paymentDate, out dateTemp))
            {
                error += "The payment date was not a valid date. ";
            }
            else
            {
                if (dateTemp > DateTime.Now)
                {
                    error += "The payment date cannot be in the future. ";
                }
            }

            // PaymentMethod validation
            if (string.IsNullOrEmpty(paymentMethod))
            {
                error += "The payment method may not be blank. ";
            }
            else if (paymentMethod.Length > 50)
            {
                error += "The payment method must be less than 50 characters. ";
            }

            // Amount validation
            if (string.IsNullOrEmpty(amount))
            {
                error += "The amount may not be blank. ";
            }
            else if (!decimal.TryParse(amount, out amountTemp))
            {
                error += "The amount must be a valid decimal. ";
            }
            else if (amountTemp <= 0)
            {
                error += "The amount must be greater than zero. ";
            }

            // Status validation
            if (string.IsNullOrEmpty(status))
            {
                error += "The status may not be blank. ";
            }
            else if (!bool.TryParse(status, out statusTemp))
            {
                error += "The status must be a valid boolean. ";
            }

            // CreatedOn validation
            if (string.IsNullOrEmpty(createdOn))
            {
                error += "The created on date may not be blank. ";
            }
            else if (!DateTime.TryParse(createdOn, out dateTemp))
            {
                error += "The created on date was not a valid date. ";
            }
            else
            {
                if (dateTemp > DateTime.Now)
                {
                    error += "The created on date cannot be in the future. ";
                }
            }

            // Return any error messages
            return error;
        }
    }
}
