using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        private Int32 mStaffID;
        private Boolean mActive;
        private DateTime mHireDate;
        private string mCountryCode;
        private String mFirstName;
        private String mLastName;
        private String mEmail;
        private Int32 mPhone;
        private String mRole;
        private String mPasswordHash;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime HireDate
        {
            get
            {
                return mHireDate;
            }
            set
            {
                mHireDate = value;
            }
        }
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
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
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
        public Int32 Phone
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
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }
        public string PasswordHash
        {
            get
            {
                return mPasswordHash;
            }
            set
            {
                mPasswordHash = value;
            }
        }

        public bool Find(int StaffID)
        {
            mStaffID = 21;
            mFirstName = "Test";
            mLastName = "Test2";
            mEmail = "Test";
            mPhone = 123214364;
            mRole = "Test";
            mCountryCode = "UK";
           mActive = true;
            mHireDate = Convert.ToDateTime("23/05/2022");
            mPasswordHash = "893324kd";
            return true;
        }
    }
}