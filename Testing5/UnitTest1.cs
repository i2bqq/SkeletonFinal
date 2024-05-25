using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TestOrderItem
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Assert.IsNotNull(AnOrderItem);
        }
        [TestMethod]
        public void OrderItemIdpropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Int32 TestData = 1;
            AnOrderItem.OrderItemID = TestData;
            Assert.AreEqual(AnOrderItem.OrderItemID, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Int32 TestData = 1;
            AnOrderItem.OrderID = TestData;
            Assert.AreEqual(AnOrderItem.OrderID, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Int32 TestData = 1;
            AnOrderItem.ProductID = TestData;
            Assert.AreEqual(AnOrderItem.ProductID, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Int32 TestData = 1;
            AnOrderItem.Quantity = TestData;
            Assert.AreEqual(AnOrderItem.Quantity, TestData);
        }
        [TestMethod]
        public void UnitPricePropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            string TestData = "20.12";
            AnOrderItem.UnitPrice = TestData;
            Assert.AreEqual(AnOrderItem.UnitPrice, TestData);
        }
        [TestMethod]
        public void TotalPricePropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            string TestData = "20.12";
            AnOrderItem.TotalPrice = TestData;
            Assert.AreEqual(AnOrderItem.TotalPrice, TestData);
        }
    }
}
