using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Testing5
{
    [TestClass]
    public class TestOrderItem
    {
        String UnitPrice = "2";
        String TotalPrice = "2";
        String Quantity = "2";
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
            decimal TestData = 20;
            AnOrderItem.UnitPrice = TestData;
            Assert.AreEqual(AnOrderItem.UnitPrice, TestData);
        }
        [TestMethod]
        public void TotalPricePropertyOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            decimal TestData = 206;
            AnOrderItem.TotalPrice = TestData;
            Assert.AreEqual(AnOrderItem.TotalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderItemIDFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.OrderItemID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.OrderID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.ProductID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.Quantity != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUnitPriceFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.UnitPrice != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderItemID = 3;
            Found = AnOrderItem.Find(OrderItemID);
            if (AnOrderItem.TotalPrice != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidmethodOk()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String  Error = "";
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
        }
        [TestMethod]
        public void QuantityExtremeMin()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = -999;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of min (0) -1 
            TestInt = -1;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the min value
            TestInt = 0;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 1;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 199;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 200;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 201;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 100;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            int TestInt;
            TestInt = 999;
            string Quantity = TestInt.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestDouble;
            TestDouble = 2.5;
            string Quantity = TestDouble.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityBlank()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            string Quantity = "";
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceExtremeMin()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = -5000.99;
            UnitPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = -0.9;
            //add the temp var to test data
            UnitPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMin()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 0.10;
            //add the temp var to test data
            UnitPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 1.10;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 9999.00;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 10000.00;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 10001.00;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 5000.00;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceExtremeMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 9999999.00;
            UnitPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceInvalidData()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            string UnitPrice = "Tst";
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = -5000.99;
            TotalPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = -0.9;
            //add the temp var to test data
            TotalPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create instance
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 0.10;
            //add the temp var to test data
            TotalPrice = TestPrice.ToString();
            //invoke method
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 1.10;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 9999.00;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 10000.00;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 10001.00;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 5000.00;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            double TestPrice;
            TestPrice = 9999999.00;
            TotalPrice = TestPrice.ToString();
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceInvalidData()
        {
            ClsOrderItem AnOrderItem = new ClsOrderItem();
            String Error = "";
            string TotalPrice = "Tst";
            Error = AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
            Assert.AreNotEqual(Error, "");
        }

    }
}
