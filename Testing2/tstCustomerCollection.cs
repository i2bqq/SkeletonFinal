using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsCustomerCollection AllCustomer = new ClsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            List<ClsCustomer> TestList = new List<ClsCustomer>();
            ClsCustomer TestItem = new ClsCustomer();
            TestItem.CustomerID = 2;
            TestItem.FirstName = "Saumya";
            TestItem.LastName = "Bhakri";
            TestItem.Email = "asdasd";
            TestItem.Phone = "07888333444";
            TestItem.CountryCode = "US";
            TestItem.Address = "sad";
            TestItem.IsActive = true;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "shdewjjd";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            ClsCustomer TestCustomer = new ClsCustomer();
            TestCustomer.CustomerID = 2;
            TestCustomer.FirstName = "Saumya";
            TestCustomer.LastName = "Bhakri";
            TestCustomer.Email = "sb@gmail.com";
            TestCustomer.Phone = "07888222333";
            TestCustomer.CountryCode = "US";
            TestCustomer.Address = "12 blue lane";
            TestCustomer.IsActive = false;
            TestCustomer.CreatedOn = DateTime.Now;
            TestCustomer.Password = "28edb92e8";

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            ClsCustomerCollection AllCustomer = new ClsCustomerCollection();
            List<ClsCustomer> TestList = new List<ClsCustomer>();
            ClsCustomer TestItem = new ClsCustomer();
            TestItem.CustomerID = 6;
            TestItem.FirstName = "Talal";
            TestItem.LastName = "dbfjsdg";
            TestItem.Email = "3648hd";
            TestItem.Phone = "0762338393";
            TestItem.CountryCode = "GB";
            TestItem.Address = "SDJGEFUEB";
            TestItem.IsActive = false;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "hdhfffisif";
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            ClsCustomerCollection AllCustomer = new ClsCustomerCollection();
            ClsCustomer TestItem = new ClsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 6;
            TestItem.FirstName = "Talal";
            TestItem.LastName = "dbfjsdg";
            TestItem.Email = "3648hd";
            TestItem.Phone = "0762338393";
            TestItem.CountryCode = "GB";
            TestItem.Address = "SDJGEFUEB";
            TestItem.IsActive = false;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "hdhfffisif";
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            ClsCustomer TestItem = new ClsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 6;
            TestItem.FirstName = "Saumya";
            TestItem.LastName = "dbfjsdg";
            TestItem.Email = "3648hd";
            TestItem.Phone = "0762338393";
            TestItem.CountryCode = "GB";
            TestItem.Address = "SDJGEFUEB";
            TestItem.IsActive = false;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "hdhfffisif";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;

            TestItem.CustomerID = 6;
            TestItem.FirstName = "Sally";
            TestItem.LastName = "brown";
            TestItem.Email = "sbrown@gmail.com";
            TestItem.Phone = "071112222333";
            TestItem.CountryCode = "US";
            TestItem.Address = "13 Tree Lane";
            TestItem.IsActive = true;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "oiuyts";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        
      
    } 
}




       


 





  
    
       








