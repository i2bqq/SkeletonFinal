using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<ClsStaff> mStaffList = new List<ClsStaff>();

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
                
            }
        }
        ClsStaff mThisStaff = new ClsStaff();
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
public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Staff_SelelctAll");
            RecordCount = DB.Count;
            while (Index < RecordCount) 
            {
                ClsStaff AnStaff = new ClsStaff();
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Phone = Convert.ToInt32(DB.DataTable.Rows[Index]["Phone"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AnStaff.CountryCode = Convert.ToString(DB.DataTable.Rows[Index]["CountryCode"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]);
                AnStaff.PasswordHash = Convert.ToString(DB.DataTable.Rows[Index]["PasswordHash"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }
        
        public int Add()
        {
            mThisStaff.StaffID = 123;
            return mThisStaff.StaffID;
        }
    }
}