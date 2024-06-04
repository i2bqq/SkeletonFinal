using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSatffCollection
    {
        

            public clsSatffCollection() 
        {
            
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Staff_SelelctAll");
            PopulateArray(DB);
            
        }
        
        List<ClsStaff> mStaffList = new List<ClsStaff>();
        ClsStaff mThisStaff = new ClsStaff();
        public List<ClsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
               mStaffList = value;
            }


        }
        

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //
            }
        }
        public ClsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {

                mThisStaff = value;
            }
        }


        public int Add()
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", ThisStaff.StaffID);
            DB.AddParameter("@FirstName", ThisStaff.FirstName);
            DB.AddParameter("@LastName", ThisStaff.LastName);
            DB.AddParameter("@EmailID", ThisStaff.EmailID);
            DB.AddParameter("@CountryCode", ThisStaff.CountryCode);
            DB.AddParameter("@Contact", ThisStaff.Contact);
            DB.AddParameter("@Role",ThisStaff.Role);
            DB.AddParameter("@IsActive", ThisStaff.IsActive);
            DB.AddParameter("@Password",ThisStaff.Password);
            return DB.Execute("sproc_Staff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.AddParameter("FirstName", mThisStaff.FirstName);
            DB.AddParameter("LastName", mThisStaff.LastName);
            DB.AddParameter("EmailID", mThisStaff.EmailID);
            DB.AddParameter("CountryCode", mThisStaff.CountryCode);
            DB.AddParameter("Conatact", mThisStaff.Contact);
            DB.AddParameter("Role", mThisStaff.Role);
            DB.AddParameter("IsActive", mThisStaff.IsActive);
            DB.AddParameter("Password", mThisStaff.Password);
            DB.Execute("sproc_Staff_update");
        }

        public void Delete()
        {
            clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_staff_delete");
        }

        public void FilterByStaffID(string StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_Staff_FilterByStaffID");
            PopulateArray(DB);
        }

        public void ReportByStaffID(string StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID" , StaffID);
            DB.Execute("sproc_reportbycategoryname");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<ClsStaff>();
            while (Index < RecordCount)
            {
                ClsStaff AnStaff = new ClsStaff();
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.EmailID = Convert.ToString(DB.DataTable.Rows[Index]["EmailID"]);
                AnStaff.CountryCode = Convert.ToInt32(DB.DataTable.Rows[Index]["CountryCode"]);
                AnStaff.Contact = Convert.ToInt32(DB.DataTable.Rows[Index]["Contact"]);
                AnStaff.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["ROle"]);
                AnStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnStaff.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }
    }
}