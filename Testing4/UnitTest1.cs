using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestOrder
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
        public void OrderStatusPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean TestData = true;
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }
        [TestMethod]
        public void CreatedOnPropertyOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            DateTime TestData = DateTime.Now;
            AnOrder.CreatedOn = TestData;
            Assert.AreEqual(AnOrder.CreatedOn, TestData);
        }
    }
}
