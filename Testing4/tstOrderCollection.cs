using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a list of objects to assign to the property
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.TotalAmount = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            ClsOrder TestOrder = new ClsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 2;
            TestOrder.CustomerID = 1;
            TestOrder.TotalAmount = 20;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderStatus = true;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a list of objects to assign to the property
            List<ClsOrder> TestList = new List<ClsOrder>();
            //create the item of test data
            ClsOrder TestItem = new ClsOrder();
            //set its properties
            TestItem.OrderID = 2;
            TestItem.CustomerID = 1;
            TestItem.TotalAmount = 20;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the first data
            ClsOrder TestItem = new ClsOrder();
            //variable to store the prmary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 2;
            TestItem.CustomerID = 1;
            TestItem.TotalAmount = 20;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            ClsOrder TestItem = new ClsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = true;
            TestItem.TotalAmount = 20;
            //set ThisOrder to the data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey=AllOrders.Add();
            //set the primary key to the tst data
            TestItem.OrderID = PrimaryKey;
            //modify the test record
            TestItem.CustomerID = 2;
            TestItem.TotalAmount = 40;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = false;
            //set the record based on the new test data
            AllOrders.ThisOrder= TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create he item for the test data
            ClsOrder TestItem = new ClsOrder();
            //variable o store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderID = 2;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = true;
            TestItem.TotalAmount = 20;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerIDMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //aply a bblank string to return all records
            FilteredOrders.ReportByCustomerID("");
            //test to see if its the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //aply a code that doesnt exist
            FilteredOrders.ReportByCustomerID("234433");
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //doesnt exist
            FilteredOrders.ReportByCustomerID("3");
            //check if the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //first record is 4
                if (FilteredOrders.OrderList[0].OrderID != 4)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 39)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
