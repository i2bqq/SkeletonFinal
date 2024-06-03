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
       // [TestMethod]
       // public void CountPropertyOk()
       // {
        //    ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
        //    Int32 SomeCount = 2;
        //    AllOrderItem.Count = SomeCount;
        //    Assert.AreEqual(AllOrderItem.Count, SomeCount);
        //}
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
        //[TestMethod]
        //public void TwoRecordPresent()
        // {
        // ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
        //   Assert.AreEqual(AllOrderItem.Count, 2);
        // }
        [TestMethod]
        public void AddMethodOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            ClsOrderItem TestItem = new ClsOrderItem();
            Int32 PrimaryKey = 0;
            TestItem.OrderItemID = 5;
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.Quantity = 5;
            TestItem.UnitPrice = 5;
            TestItem.TotalPrice = 5;
            AllOrderItem.ThisOrderItem = TestItem;
            PrimaryKey = AllOrderItem.Add();
            TestItem.OrderItemID = PrimaryKey;
            AllOrderItem.ThisOrderItem.Find(PrimaryKey);
            Assert.AreEqual(AllOrderItem.ThisOrderItem, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            ClsOrderItem TestItem = new ClsOrderItem();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.Quantity = 5;
            TestItem.UnitPrice = 5;
            TestItem.TotalPrice = 5;
            AllOrderItem.ThisOrderItem = TestItem;
            PrimaryKey = AllOrderItem.Add();
            TestItem.OrderItemID = PrimaryKey;
            TestItem.OrderID = 3;
            TestItem.ProductID = 3;
            TestItem.Quantity =3;
            TestItem.UnitPrice = 3;
            TestItem.TotalPrice = 3;
            AllOrderItem.ThisOrderItem = TestItem;
            AllOrderItem.Update();
            AllOrderItem.ThisOrderItem.Find(PrimaryKey);
            Assert.AreEqual(AllOrderItem.ThisOrderItem , TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            ClsOrderItem TestItem = new ClsOrderItem();
            Int32 PraimaryKey = 0;
            TestItem.OrderItemID = 5;
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.Quantity = 5;
            TestItem.UnitPrice = 5;
            AllOrderItem.ThisOrderItem= TestItem;
            PraimaryKey = AllOrderItem.Add();
            TestItem.OrderItemID = PraimaryKey;
            AllOrderItem.ThisOrderItem.Find(PraimaryKey);
            AllOrderItem.Delete();
            Boolean Found = AllOrderItem.ThisOrderItem.Find(PraimaryKey);
            Assert.IsFalse( Found );

        }
        [TestMethod]
        public void ReportByOrderID()
        {
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();
            ClsOrderItemCollection FilteredOrderItem = new ClsOrderItemCollection();
            FilteredOrderItem.ReportByOrderID( "");
            Assert.AreEqual(AllOrderItem.Count, FilteredOrderItem.Count );
        }
        [TestMethod]
        public void ReportByOrderIDNoneFound()
        {
            ClsOrderItemCollection FilteredOrderItem = new ClsOrderItemCollection();
            ClsOrderItemCollection AllOrderItem = new ClsOrderItemCollection();

            FilteredOrderItem.ReportByOrderID("");
            Assert.AreEqual(AllOrderItem.Count, FilteredOrderItem.Count);
        }
    }
}
