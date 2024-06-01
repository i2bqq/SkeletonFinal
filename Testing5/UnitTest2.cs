using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstOrderItemCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            Assert.IsNotNull(AllOrderItem);
        }
        [TestMethod]
        public void OrderItemsListOK()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            List<ClsOrderItem> TestList = new List<ClsOrderItem>();
            ClsOrderItem TestItem = new ClsOrderItem();
            TestItem.OrderItemID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.UnitPrice = 1;
            TestItem.TotalPrice = 1;
            TestList.Add(TestItem);
            AllOrderItem.OrderItemList = TestList;
            Assert.AreEqual(AllOrderItem.OrderItemList, TestList);
        }
        [TestMethod]
        public void CountPropertyOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            Int32 SomeCount = 0;
            AllOrderItem.Count = SomeCount;
            Assert.AreEqual(AllOrderItem.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderItemPropertyOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            ClsOrderItem TestOrderItem = new ClsOrderItem();
            TestOrderItem.OrderItemID = 1;
            TestOrderItem.OrderID = 1;
            TestOrderItem.ProductID = 1;
            TestOrderItem.Quantity = 1;
            TestOrderItem.UnitPrice = 1;
            TestOrderItem.TotalPrice = 1;
            AllOrderItem.ThisOrderItem = TestOrderItem;
            Assert.AreEqual(AllOrderItem.ThisOrderItem, TestOrderItem);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            List<ClsOrderItem> TestList = new List<ClsOrderItem>();
            ClsOrderItem TestItem = new ClsOrderItem();
            TestItem.OrderItemID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.UnitPrice = 1;
            TestItem.TotalPrice= 1;
            TestList.Add(TestItem);
            AllOrderItem.OrderItemList = TestList;
            Assert.AreEqual(AllOrderItem.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordPresent()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            Assert.AreEqual(AllOrderItem.Count, 2);
        }
    }
}
