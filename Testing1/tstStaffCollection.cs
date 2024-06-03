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
            TestItem.FirstName = "Meet";
            TestItem.LastName = "Patel";
            TestItem.EmailID = "meet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.IsActive = true;
            TestItem.HireDate = DateTime.Now;
            TestItem.Password = "meet123";
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
            TestStaff.FirstName = "meet";
            TestStaff.LastName = "patel";
            TestStaff.EmailID = "meet030405@gmail.com";
            TestStaff.CountryCode = 44;
            TestStaff.Contact = 1234567896;
            TestStaff.Role = "HR";
            TestStaff.IsActive = true;
            TestStaff.Password = "meet123";
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
            TestItem.FirstName = "meet";
            TestItem.LastName = "patel";
            TestItem.EmailID = "mmeet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.IsActive = true;
            TestItem.Password = "meet123";
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
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.FirstName = "meet";
            TestItem.LastName = "patel";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "meet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.Password = "meet123";
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
            TestItem.StaffID = 1;
            TestItem.FirstName = "meet";
            TestItem.LastName = "patel";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "meet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.Password = "meet123";
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = 1;
            TestItem.FirstName = "meet";
            TestItem.LastName = "patel";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "meet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.Password = "meet123";
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
            TestItem.FirstName = "meet";
            TestItem.LastName = "patel";
            TestItem.HireDate = DateTime.Now;
            TestItem.EmailID = "meet030405@gmail.com";
            TestItem.CountryCode = 44;
            TestItem.Contact = 1234567896;
            TestItem.Role = "HR";
            TestItem.Password = "meet123";
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        } 
    }
}

