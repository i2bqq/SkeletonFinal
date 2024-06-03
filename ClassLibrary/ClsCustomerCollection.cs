using System;
using System.Collections.Generic;
using System.Data;
namespace ClassLibrary

{
    public class ClsCustomerCollection
    {

        List<ClsCustomer> mCustomerList = new List<ClsCustomer>();
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

        public ClsCustomer ThisCustomer { get; set; }
        public ClsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Customer_SelelctAll");

            RecordCount = DB.Count;
            while (Index < RecordCount)
            {

                ClsCustomer AnCustomer = new ClsCustomer();
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
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





