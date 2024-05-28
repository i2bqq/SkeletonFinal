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

       
    }
}
