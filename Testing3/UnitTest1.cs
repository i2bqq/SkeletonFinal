using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class TestStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsStock AnStock = new ClsStock();

            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            Int32 TestData = 1;

            AnStock.ProductID = TestData;

            Assert.AreEqual(AnStock.ProductID, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            String TestData = "test";
            AnStock.ProductName = TestData;
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void CategoryNamePropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            string TestData = "test";
            AnStock.CategoryName = TestData;
            Assert.AreEqual(AnStock.CategoryName, TestData);
        }
        [TestMethod]
        public void pricePropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            decimal TestData = 123;
            AnStock.Price = TestData;
            Assert.AreEqual(AnStock.Price, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            int TestData = 14;
            AnStock.StockQuantity = TestData;
            Assert.AreEqual(AnStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void CreatedOnPropertyOK()
        {
            ClsStock AnStock = new ClsStock();
            DateTime TestData = DateTime.Now;
            AnStock.CreatedOn = TestData;
            Assert.AreEqual(AnStock.CreatedOn, TestData);
        }
        [TestMethod]
        public void InStockPropertyOk()
        {
            ClsStock AnStock = new ClsStock();
            Boolean TestData = true;
            AnStock.InStock = TestData;
            Assert.AreEqual(AnStock.InStock, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;

            Int32 ProductID = 21;
            Found = AnStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductID()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnStock.Find(ProductID);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnStock.Find(ProductID);
            if (AnStock.ProductName != "Make up")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCategoryNameFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 21;
            Found = AnStock.Find(ProductId);
            if (AnStock.CategoryName != "Face")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 21;
            Found = AnStock.Find(ProductId);
            if (AnStock.Price != 123)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 21;
            Found = AnStock.Find(ProductId);
            if (AnStock.StockQuantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCreatedOnFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 21;
            Found = AnStock.Find(ProductId);
            if (AnStock.CreatedOn != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 21;
            Found = AnStock.Find(ProductId);
            if (AnStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

