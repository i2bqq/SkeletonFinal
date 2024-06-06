using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        public ClsStaff()
        {
        }
        private Boolean mIsActive;
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
        private DateTime mHireDate;
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
        private Int32 mCountryCode;
        public Int32 CountryCode
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
        private string mFirstName;
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
        private string mLastName;
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
        private Int32 mStaffID;
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
        private string mEmailID;
        public string EmailID
        {
            get
            {
                return mEmailID;
            }
            set
            {
                mEmailID = value;
            }
        }
        private int mContact;
        public int Contact
        {
            get
            {
                return mContact;
            }
            set
            {
                mContact = value;
            }
        }
        private string mRole;
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
        private string mPassword;
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
                mEmailID = Convert.ToString(DB.DataTable.Rows[0]["EmailID"]);
                mContact = Convert.ToInt32(DB.DataTable.Rows[0]["Contact"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mCountryCode = Convert.ToInt32(DB.DataTable.Rows[0]["CountryCode"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;

            }
            else
            {
                return false;
            }
        }

        public string Valid(String FirstName, String LastName, String EmailID, String Role, string HireDate, String Password)
        {
            DateTime DateTemp;

            string Error = "";
            if (FirstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank : ";
            }
            if (FirstName.Length > 14)
            {
                Error = Error + "The First Name must be less than 13 Characters : ";
            }
            if (LastName.Length == 0)
            {
                Error = Error + "The Last Name may not be blank : ";
            }
            if (LastName.Length > 14)
            {
                Error = Error + "The Last Name must be less than 13 Characters : ";
            }
            if (EmailID.Length == 0)
            {
                Error = Error + "The Email may not be blank : ";
            }
            if (EmailID.Length > 24)
            {
                Error = Error + "The Email must be less than 25 Characters : ";
            }
            if (Role.Length == 0)
            {
                Error = Error + "The Role may not be blank ";
            }
            if (Role.Length > 14)
            {
                Error = Error + "The Role must be less than 15 Characters ";
            }
            if (Password.Length == 0)
            {
                Error = Error + "The Password may not be blank ";
            }
            if (Password.Length > 18)
            {
                Error = Error + "The Password must be less than 18 Characters ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(HireDate);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the futre ";
                }
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past ";
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

