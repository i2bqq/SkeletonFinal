using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
        
            //good test data
            //create some test data to pass the method
            string OrderDate = DateTime.Now.ToShortDateString();
            string TotalAmount = "20.00";
        
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
            Int32 OrderID = 2;
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
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 2)
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
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id property
            if (AnOrder.CustomerID != 1)
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
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("12/02/2002"))
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
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalAmount != Convert.ToDecimal("20.00"))
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
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderStatus != true)
            {
                OK = false;
            }
        Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,TotalAmount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate,TotalAmount);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate,TotalAmount);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = -5000.99;
            TotalAmount = TestPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance
            ClsOrder AnOrder = new ClsOrder();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = -0.9;
            //add the temp var to test data
            TotalAmount = TestPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create instance
            ClsOrder AnOrder = new ClsOrder();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 0.10;
            //add the temp var to test data
            TotalAmount = TestPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 1.10;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 9999.00;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 10000.00;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 10001.00;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 5000.00;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TestPrice;
            TestPrice = 100000000.00;
            TotalAmount = TestPrice.ToString();
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string TotalAmount = "Test Price";
            Error = AnOrder.Valid(OrderDate, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }


    }
}
