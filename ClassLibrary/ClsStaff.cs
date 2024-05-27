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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_Staff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mCountryCode = Convert.ToString(DB.DataTable.Rows[0]["CountryCode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mPasswordHash = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);
                return true;

            }
           else
            {
                return false;
            }
        }

        public string Valid(String FirstName, String LastName, String Email, String Role,String HireDate , String PasswordHash)
        {
            string Error = "";
            DateTime  DateTemp;
            
            
            
            if (FirstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank : ";
            }
            if(FirstName.Length > 50) 
            {
                Error = Error + "The First Name must be less than 50 Characters : ";
            }
            if (LastName.Length == 0)
            {
                Error = Error + "The Last Name may not be blank : ";
            }
            if (LastName.Length > 50)
            {
                Error = Error + "The Last Name must be less than 50 Characters : ";
            }
            if (Email.Length == 0)
            {
                Error = Error + "The Email may not be blank : ";
            }
            if (Email.Length > 50)
            {
                Error = Error + "The Email must be less than 50 Characters : ";
            }
            if (Role.Length == 0)
            {
                Error = Error + "The Role may not be blank ";
            }
            if (Role.Length > 50)
            {
                Error = Error + "The Role must be less than 50 Characters ";
            }
            if (PasswordHash.Length == 0)
            {
                Error = Error + "The Password may not be blank ";
            }
            if (PasswordHash.Length > 50)
            {
                Error = Error + "The Password must be less than 50 Characters ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(HireDate);
                if (DateTemp > DateComp)
                {
                    Error = Error + "The Date cannot be in the futre ";
                }

            }
            catch 
            {
                Error = Error + "The Date is not a valid Date";
            }

            return Error;
        }
    }
}