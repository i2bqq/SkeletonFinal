using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        private Int32 mStaffID;
        private Boolean mIsActive;
        private DateTime mHireDate;
        private Int32 mCountryCode;
        private String mFirstName;
        private String mLastName;
        private String mEmailID;
        private Int32 mContact;
        private String mRole;
        private String mPassword;
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
        public Int32 Contact
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
                mContact = Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]);
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

        public string Valid(String FirstName, 
                            String LastName,
                            String EmailID, 
                            String Role,
                            String HireDate , 
                            String Password)
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
            if (EmailID.Length == 0)
            {
                Error = Error + "The Email may not be blank : ";
            }
            if (EmailID.Length > 50)
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
            if (Password.Length == 0)
            {
                Error = Error + "The Password may not be blank ";
            }
            if (Password.Length > 50)
            {
                Error = Error + "The Password must be less than 50 Characters ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(HireDate);
                if (DateTemp > DateTime.Now.Date)
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

        public string Valid(object firstName, object lastName, object hireDate, object emailID, object password, object role)
        {
            throw new NotImplementedException();
        }
    }
}