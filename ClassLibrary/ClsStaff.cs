using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        private Int32 mStaffID;

        public bool Active { get; set; }
        public DateTime HireDate { get; set; }
        public string CountryCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string PasswordHash { get; set; }

        public bool Find(int StaffID)
        {
            mStaffID = 21;
            return true;
        }
    }
}