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
            TestItem.HireDate = DateTime.Now;
            TestItem.Phone = 123412;
            TestItem.CountryCode = "UK";
            TestItem.PasswordHash = "543523";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
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
            TestStaff.HireDate= DateTime.Now;
            TestStaff.Phone = 123412;
            TestStaff.CountryCode = "UK";
            TestStaff.PasswordHash = "543523";
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffID = 2;
            TestItem.FirstName = "Tafglal";
            TestItem.LastName = "Alofgtaibi";
            TestItem.Email = "dsjfhgh@gmail.com";
            TestItem.Phone = 123412;
            TestItem.CountryCode = "UK";
            TestItem.PasswordHash = "54f3523";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethod()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.StaffID = 2;
            TestItem.FirstName = "Nivar";
            TestItem.LastName = "Anwar";
            TestItem.Email = "123asd@gmail.com";
            TestItem.Phone = 324323112 ;
            TestItem.CountryCode = "UK";
            TestItem.Role = "Manager";
            TestItem.PasswordHash = "hfdsjklsfdj";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}
