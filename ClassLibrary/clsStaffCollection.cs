using System.Collections.Concurrent;
using System.Collections.Generic;

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
        public ClsStaff ThisStaff { get; set; }
    }
}