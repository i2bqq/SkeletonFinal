using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.StaffID = 1;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "staff";
            TestItem.IsActive = true;
            TestItem.HireDate = DateTime.Now;
            TestItem.Password = "curry123";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropetyOK()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            ClsStaff TestStaff = new ClsStaff();
            TestStaff.StaffID = 1;
            TestStaff.FirstName = "stef";
            TestStaff.LastName = "curry";
            TestStaff.EmailID = "curry@123.gmail.com";
            TestStaff.CountryCode = 86;
            TestStaff.Contact = 1234564345;
            TestStaff.Role = "staff";
            TestStaff.IsActive = true;
            TestStaff.Password = "curry123";
            TestStaff.HireDate = DateTime.Now;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void StaffListAndCountOK()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.StaffID = 1;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "staff";
            TestItem.IsActive = true;
            TestItem.Password = "curry123";
            TestItem.HireDate= DateTime.Now;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void StaffAddMethodOK()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 1;
            TestItem.StaffID = PrimaryKey;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "staff";
            TestItem.Password = "curry123";
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance
            clsSatffCollection AllStaff = new clsSatffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "staff";
            TestItem.Password = "curry123";
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "stock";
            TestItem.Password = "curry123";
            TestItem.IsActive = true;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.FirstName = "stef";
            TestItem.LastName = "curry";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "curry@123.gmail.com";
            TestItem.CountryCode = 86;
            TestItem.Contact = 1234564345;
            TestItem.Role = "staff";
            TestItem.Password = "curry123";
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportBystaffIDMethodOk()
        {
            clsSatffCollection AllStaff = new clsSatffCollection();
            clsSatffCollection FilterStaff = new clsSatffCollection();
            FilterStaff.ReportByStaffName("");
            Assert.AreEqual(AllStaff.Count, FilterStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffIDNoneFound()
        {
            clsSatffCollection Filterstaff = new clsSatffCollection();
            Filterstaff.ReportByStaffName("None");
            Assert.AreEqual(0, Filterstaff.Count);
        }
    }
}

