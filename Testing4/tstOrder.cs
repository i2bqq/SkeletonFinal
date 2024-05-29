using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Permissions;

namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsOrder AnOrder = new ClsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Int32 TestData = 1;

            AnOrder.OrderID = TestData;

            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Int32 TestData = 1;

            AnOrder.CustomerID = TestData;

            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            DateTime TestData = DateTime.Now;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            decimal TestData = 100.00m;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean TestData = true;
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create a instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id property
            if (AnOrder.CustomerID != 21)
            {
                OK =false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("10/02/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalAmountFound()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalAmount != Convert.ToDecimal("100.00"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderStatus != true)
            {
                OK = false;
            }
        Assert.IsTrue(OK);
        }
    }
}
