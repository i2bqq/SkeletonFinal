using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        private bool mActive;
        //Active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        private DateTime mDateOfBirth;
        //DateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
            }
        }
        private string mFirstName;
        //FullName public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }
        private string mLastName;
        //FullName public property
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        private string mContactNumber;
        //Email public property
        public string ContactNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mContactNumber;
            }
            set
            {
                //this line of code allows data into the property
                mContactNumber = value;
            }
        }
        private string mCountryCode;
        //Email public property
        public string CountryCode
        {
            get
            {
                //this line of code sends data out of the property
                return mCountryCode;
            }
            set
            {
                //this line of code allows data into the property
                mCountryCode = value;
            }
        }
        private string mPassword;
        //Password public property
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }
        private string mAddress;
        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //create an istance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mActive = true;
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mCountryCode = Convert.ToString(DB.DataTable.Rows[0]["CountryCode"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string password, string CountryCode, string ContactNumber, string email, string address, string dateOfBirth, string dateOfBirth1, string dateOfBirth2)
        {
            String Error = "";
            DateTime DateTemp;

            //validate first name
            if (FirstName.Length <= 0)
            {
                Error = Error + "The FullName must not be blank : ";
            }

            if (LastName.Length > 50)
            {
                Error = Error + "The FullName must not less than 50 character : ";
            }
            //validate last name
            if (LastName.Length <= 0)
            {
                Error = Error + "The LaslName must not be blank : ";
            }

            if (LastName.Length > 50)
            {
                Error = Error + "The LastlName must not less than 50 character : ";
            }
            //validate contact number
            if (ContactNumber.Length <= 0)
            {
                Error = Error + "The ContactNumber must not be blank : ";
            }

            if (ContactNumber.Length != 11)
            {
                Error = Error + "The FullName must be 10 digit long : ";
            }
            //validate country code
            if (CountryCode.Length <= 0)
            {
                Error = Error + "The FullName must not be blank : ";
            }
            //validate date
            try
            {
                //Copy the date of birth value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                //mimium
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be above today's date : ";
                }
                //mimum
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The date cannot be less than 100 years : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the Customer Address is blank or less
            if (address.Length <= 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }

            //if the Customer Address is more than 50 character
            if (address.Length >= 50)
            {
                //record the error
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }

            //if the customer Email is left blank
            if (email.Length < 11)
            {
                //record the error
                Error = Error + "The Customer Email may not be less 11 characters : ";
            }
            if (email.Length > 40)
            {
                //record the error
                Error = Error + "The Customer Email must be less than 40 characters : ";
            }

            if (password.Length < 1)
            {
                //record the error
                Error = Error + "The Customer Email may not be less 11 characters : ";
            }
            if (password.Length > 80)
            {
                //record the error
                Error = Error + "The Customer Email must be less than 40 characters : ";
            }

            return Error;
        }

        public string Valid(string firstName, string lastName, string password, string ContactNumber, string CountryCode, string email, string address, string dateOfBirth, string address1)
        {
            throw new NotImplementedException();
        }

        public string Valid(string firstName, string lastName, string contactNumber, string countryCode, string password, string email, string address, string dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
