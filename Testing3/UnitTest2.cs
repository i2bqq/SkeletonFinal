using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class TestStockCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOk()
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            List<ClsStock> TestList = new List<ClsStock>();
            ClsStock TestItem = new ClsStock();
            TestItem.ProductID = 2;
            TestItem.ProductName = "lipstick";
            TestItem.CategoryName = "Face";
            TestItem.Price = 12;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        
        [TestMethod]
        public void ThisStaffpropertyOk()
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            ClsStock TestStock = new ClsStock();
            TestStock.ProductID = 2;
            TestStock.ProductName = "lipstick";
            TestStock.CategoryName = "Face";
            TestStock.Price = 12;
            TestStock.StockQuantity = 45;
            TestStock.CreatedOn = DateTime.Now;
            TestStock.InStock = true;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOk()
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            List<ClsStock> TestList = new List<ClsStock>();
            ClsStock TestItem = new ClsStock();
            TestItem.ProductID = 2;
            TestItem.ProductName = "lipstick";
            TestItem.CategoryName = "Face";
            TestItem.Price = 12;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        

    }
}
