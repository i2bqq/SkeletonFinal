using System;
using System.Collections.Generic;
using System.Data;
namespace ClassLibrary

{
    public class ClsCustomerCollection
    {

        List<ClsCustomer> mCustomerList = new List<ClsCustomer>();
        ClsCustomer mThisCustomer = new ClsCustomer();
        public List<ClsCustomer> CustomerList
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
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public ClsCustomer ThisCustomer
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
        public ClsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Customer_SelelctAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@CountryCode", mThisCustomer.CountryCode);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@CreatedOn", mThisCustomer.CreatedOn);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);
            return DB.Execute("sproc_Customer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@CountryCode", mThisCustomer.CountryCode);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@CreatedOn", mThisCustomer.CreatedOn);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);
            DB.Execute("sproc_Customer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_Customer_FilterByFirstName");
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<ClsCustomer>();
            while (Index < RecordCount)
            {
                ClsCustomer AnCustomer = new ClsCustomer();
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnCustomer.CountryCode = Convert.ToString(DB.DataTable.Rows[Index]["CountryCode"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AnCustomer.CreatedOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedOn"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
        }
    }
}






