using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class TestStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Talal";
            TestItem.LastName = "Alotaibi";
            TestItem.Email = "dsjfh@gmail.com";
            TestItem.Phone = 123412;
            TestItem.CountryCode = "UK";
            TestItem.PasswordHash = "543523";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStaffPropertyOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestStaff = new ClsStaff();
            
            TestStaff.Active = true;
            TestStaff.StaffID = 1;
            TestStaff.FirstName = "Talal";
            TestStaff.LastName = "Alotaibi";
            TestStaff.Email = "dsjfh@gmail.com";
            TestStaff.Phone = 123412;
            TestStaff.CountryCode = "UK";
            TestStaff.PasswordHash = "543523";
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void StaffAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Talal";
            TestItem.LastName = "Alotaibi";
            TestItem.Email = "dsjfh@gmail.com";
            TestItem.Phone = 123412;
            TestItem.CountryCode = "UK";
            TestItem.PasswordHash = "543523";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
    }
}
