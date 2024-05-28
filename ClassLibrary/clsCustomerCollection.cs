using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return CustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }



        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                ACustomer.CountryCode = Convert.ToString(DB.DataTable.Rows[Index]["CountryCode"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                // Check for DBNull before converting to DateTime
                if (DB.DataTable.Rows[Index]["DateOfBirth"] != DBNull.Value)
                {
                    ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                }
                else
                {
                    // Handle DBNull case appropriately, maybe assign a default value or handle it differently
                    ACustomer.DateOfBirth = DateTime.MinValue; // For example, assign a default value
                }
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LasttName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@CountryCode", mThisCustomer.CountryCode);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@CountryCode", mThisCustomer.CountryCode);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.Execute("sproc_tblCustomer_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            PopulateArray(DB);
        }
    }
}