using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class TestStock
    {
        //Good Test Data
        string ProductName = "Eye shadow";
        string CategoryName = "Face";
        string Price = "30.20";
        string StockQuantity = "15";
        string CreatedOn = DateTime.Now.ToShortDateString();


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

            Int32 ProductID = 1;
            Found = AnStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductID()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AnStock.Find(ProductID);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            ClsStock AnStock = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AnStock.Find(ProductID);
            if (AnStock.ProductName != "Revlon ColorStay Foundation")
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
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            if (AnStock.CategoryName != "Foundation")
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
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            if (AnStock.Price != 12m)
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
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            if (AnStock.StockQuantity != 20)
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
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            if (AnStock.CreatedOn != Convert.ToDateTime("06/06/2024"))
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
            Int32 ProductId = 7;
            Found = AnStock.Find(ProductId);
            if (AnStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            ClsStock AnStock = new ClsStock();
            string Error = "";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "aa"; 
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49 , 'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(51, 'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "a";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50,'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(500);
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMinLessOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMinPlusOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "aa";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMin()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "a";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMaxLessOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "";
            CategoryName = CategoryName.PadRight(49, 'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "";
            CategoryName = CategoryName.PadRight(50 , 'a');
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameMid()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "";
            CategoryName = CategoryName.PadRight(25);
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryNameExtremeMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string CategoryName = "";
            CategoryName = CategoryName.PadRight(500);
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = -5000.99;
            Price = TestPrice.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = -0.9;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 0.10;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 1.10;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 9999.00;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 10000.00;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 10001.00;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 5000.00;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            double TestPrice;
            TestPrice = 100000000.00;
            Price = TestPrice.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            string Price = "Test Price";
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMin()
        {
            ClsStock AnStock = new ClsStock();
            String Error = "";
            int TestInt;
            TestInt = -999;
            string StockQuantity = TestInt.ToString();
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of min (0) -1 
            TestInt = -1;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the min value
            TestInt = 0;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of min +1
            TestInt = 1;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of max (200) -1
            TestInt = 199;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the max value
            TestInt = 200;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the max value +1
            TestInt = 201;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the mid value 
            TestInt = 100;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign an extreme max value
            TestInt = 999;
            //convert to string
            string StockQuantity = TestInt.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a test variable that is not of type int
            double TestDouble;
            //assign a non int value
            TestDouble = 2.5;
            //convert to string
            string StockQuantity = TestDouble.ToString();
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityBlank()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //leave the variable blank
            string StockQuantity = "";
            //invoke method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreatedOnExtremeMin()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMinLessOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 1 day
            TestDate = TestDate.AddDays(-1); //should cause error
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMin()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMinPlusOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date add 1 day
            TestDate = TestDate.AddDays(1); //should cause error
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMax()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMaxPlusOne()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 1 day
            TestDate = TestDate.AddDays(1); //should cause error
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnExtremeMax()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 100 years
            TestDate = TestDate.AddYears(100); //should cause error
            //convert the date variable to a string type
            string CreatedOn = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreatedOnInvalidData()
        {
            //create instance
            ClsStock AnStock = new ClsStock();
            //string c=variable to store error message
            String Error = "";
            //set arrived on to a invalid data type
            string CreatedOn = "Test";
            //invoke the method
            Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}

