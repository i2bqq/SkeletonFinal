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
        [TestMethod]
        public void AddMethodOK()
        {
            //create instance
            ClsStockCollection AllStock = new ClsStockCollection();
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 2;
            TestItem.ProductName = "lipstick";
            TestItem.CategoryName = "Face";
            TestItem.Price = 12;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ProductID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance
            ClsStockCollection AllStock = new ClsStockCollection();
            ClsStock TestItem = new ClsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = PrimaryKey;
            TestItem.ProductName = "lipstick";
            TestItem.CategoryName = "Face";
            TestItem.Price = 12;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ProductID = PrimaryKey;
            TestItem.ProductName = "Shadow";
            TestItem.CategoryName = "eyes";
            TestItem.Price = 20;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk() 
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            ClsStock TestItem = new ClsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductName = "Shadow";
            TestItem.CategoryName = "eyes";
            TestItem.Price = 20;
            TestItem.StockQuantity = 45;
            TestItem.CreatedOn = DateTime.Now;
            TestItem.InStock = true;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ProductID = PrimaryKey;
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse( Found );

        }
        [TestMethod]
        public void ReportByCategoryNameMethodOk()
        {
            ClsStockCollection AllStock = new ClsStockCollection();
            ClsStockCollection FilterStock = new ClsStockCollection();
            FilterStock.ReportByCategoryName("");
            Assert.AreEqual(AllStock.Count, FilterStock.Count);
        }
        [TestMethod]
        public void ReportByCategoryNameNoneFound()
        {
            ClsStockCollection Filterstock = new ClsStockCollection();
            Filterstock.ReportByCategoryName("None");
            Assert.AreEqual(0, Filterstock.Count);
        }
        


    }
}
