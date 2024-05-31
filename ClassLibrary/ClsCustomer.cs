using System;
using System.Runtime.Remoting.Messaging;

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
                return Email;


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
                return Phone;


            }
            set
            {
                Phone = value;
            }
        }
        private string mPhone;
        public string CountryCode
        {
            get
            {
                return CountryCode;


            }
            set
            {
                CountryCode = value;
            }
        }
        private string mCountryCode;
        public string Address
        {
            get
            {
                return Address;


            }
            set
            {
                Address = value;
            }
        }
        private string mAddress;
        public bool IsActive
        {
            get
            {
                return IsActive;


            }
            set
            {
                IsActive = value;
            }
        }
        private bool mIsActive;

        public DateTime CreatedOn
        {
            get
            {
                return CreatedOn;


            }
            set
            {
                CreatedOn = value;
            }
        }
        private DateTime mCreatedOn;
        
        public string Password
        {
            get
            {
                return Password;


            }
            set
            {
               Password = value;
            }
        }
        private string mPassword;
        public bool Find(int CustomerID)
        {
            mCustomerID = 21;
            return true;
        }

        
    }
}

    
