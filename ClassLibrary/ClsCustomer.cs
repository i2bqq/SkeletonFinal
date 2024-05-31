using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace ClassLibrary
{
    public class ClsCustomer
    {
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
        public string FirstName
        {
            get
            {
                return mFirstName;


            }
            set
            {
                mFirstName = value;
            }
        }
        private string mFirstName;
        public string LastName
        {
            get
            {
                return mLastName;


            }
            set
            {
                mLastName = value;
            }
        }
        private string mLastName;
        public string Email
        {
            get
            {
                return mEmail;


            }
            set
            {
                mEmail = value;
            }
        }
        private string mEmail;
        public string Phone
        {
            get
            {
                return mPhone;


            }
            set
            {
                mPhone = value;
            }
        }
        private string mPhone;
        public string CountryCode
        {
            get
            {
                return mCountryCode;


            }
            set
            {
                mCountryCode = value;
            }
        }
        private string mCountryCode;
        public string Address
        {
            get
            {
                return mAddress;


            }
            set
            {
                mAddress = value;
            }
        }
        private string mAddress;
        public bool IsActive
        {
            get
            {
                return mIsActive;


            }
            set
            {
                mIsActive = value;
            }
        }
        private bool mIsActive;

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
        private DateTime mCreatedOn;

        public string Password
        {
            get
            {
                return mPassword;


            }
            set
            {
                mPassword = value;
            }
        }
        private string mPassword;
        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mCountryCode = Convert.ToString(DB.DataTable.Rows[0]["CountryCode"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mCreatedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedOn"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }

            else
            {
                return false;
            }



        }

        public string Valid(string firstName, string lastName, string email, string phone, string createdOn, string address, string password)
        {
            string Error = "";
            DateTime DateTemp;
            if (firstName.Length == 0)
            {
                Error = Error + "The first name must not be blank";
            }
            if (firstName.Length > 50)
            {
                Error = Error + "The first name must be not less than 50 characters";
            }
            if (lastName.Length == 0)
            {
                Error = Error + "The last name must not be blank";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "The last name must be not less than 50 characters";
            }
            if (email.Length == 0)
            {
                Error = Error + "The email must not be blank";
            }
            if (email.Length > 255)
            {
                Error = Error + "The email must be not less than 255 characters";
            }
            if (phone.Length == 0)
            {
                Error = Error + "The phone must not be blank";
            }
            if (phone.Length > 20)
            {
                Error = Error + "The first name must be not less than 20 numbers";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(createdOn);

                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date :";
            }
            if (address.Length == 0)
            {
                Error = Error + "The address must not be blank";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address must be not less than 255 characters";

            }
            if (password.Length == 0)
            {
                Error = Error + "The address must not be blank";
            }
            if (password.Length > 50)
            {
                Error = Error + "The password must be not less than 50 characters";
            }
            return Error;
        }
    }
}

    
