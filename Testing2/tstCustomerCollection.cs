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
            TestItem.CreatedOn = DateTime.Now;
            TestItem.Password = "hdhfffisif";
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);

        }



    }

        
    
}



 





  
    
       








