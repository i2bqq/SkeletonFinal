using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsPayment aPayment = new ClsPayment();
            Assert.IsNotNull(aPayment);
        }

        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            int testData = 3;
            aPayment.PaymentID = testData;
            Assert.AreEqual(aPayment.PaymentID, testData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            int testData = 2;
            aPayment.OrderID = testData;
            Assert.AreEqual(aPayment.OrderID, testData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime testData = Convert.ToDateTime("01/06/2023");
            aPayment.PaymentDate = testData;
            Assert.AreEqual(aPayment.PaymentDate, testData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            string testData = "Card";
            aPayment.PaymentMethod = testData;
            Assert.AreEqual(aPayment.PaymentMethod, testData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal testData = 10.00m;
            aPayment.Amount = testData;
            Assert.AreEqual(aPayment.Amount, testData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            bool testData = true;
            aPayment.Status = testData;
            Assert.AreEqual(aPayment.Status, testData);
        }

        [TestMethod]
        public void CreatedOnPropertyOK()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime testData = Convert.ToDateTime("01/06/2023");
            aPayment.CreatedOn = testData;
            Assert.AreEqual(aPayment.CreatedOn, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.OrderID, 2);
        }

        [TestMethod]
        public void TestPaymentDateFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.PaymentDate, Convert.ToDateTime("01/06/2023"));
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.PaymentMethod, "Card");
        }

        [TestMethod]
        public void TestAmountFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.Amount, 10.00m);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.Status, true);
        }

        [TestMethod]
        public void TestCreatedOnFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.CreatedOn, Convert.ToDateTime("01/06/2023"));
        }

        [TestMethod]
        public void FindByPaymentIDMethodOK()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestPaymentIDNotFound()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(9999);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void TestOrderIDFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.OrderID, 2);
        }

        [TestMethod]
        public void TestPaymentDateFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.PaymentDate, Convert.ToDateTime("01/06/2023"));
        }

        [TestMethod]
        public void TestPaymentMethodFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.PaymentMethod, "Card");
        }

        [TestMethod]
        public void TestAmountFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.Amount, 10.00m);
        }

        [TestMethod]
        public void TestStatusFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.Status, true);
        }

        [TestMethod]
        public void TestCreatedOnFoundByPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(3);
            Assert.IsTrue(found);
            Assert.AreEqual(aPayment.CreatedOn, Convert.ToDateTime("01/06/2023"));
        }

        // Additional Tests

        [TestMethod]
        public void InvalidPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(-1);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ExtremeHighPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(Int32.MaxValue);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ExtremeLowPaymentID()
        {
            ClsPayment aPayment = new ClsPayment();
            bool found = aPayment.Find(Int32.MinValue);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void EmptyPaymentMethod()
        {
            ClsPayment aPayment = new ClsPayment();
            aPayment.PaymentMethod = "";
            Assert.AreEqual(aPayment.PaymentMethod, "");
        }

        [TestMethod]
        public void LongPaymentMethod()
        {
            ClsPayment aPayment = new ClsPayment();
            aPayment.PaymentMethod = new string('a', 51);
            Assert.AreEqual(aPayment.PaymentMethod, new string('a', 51));
        }

        [TestMethod]
        public void InvalidAmount()
        {
            ClsPayment aPayment = new ClsPayment();
            aPayment.Amount = -10.00m;
            Assert.AreEqual(aPayment.Amount, -10.00m);
        }
        [TestMethod]
        public void PaymentMethodMinMinusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = ""; // Min - 1
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentMethodMinBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = "a"; // Min boundary
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = "ab"; // Min + 1
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentMethodMaxMinusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = new string('a', 49); // Max - 1
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentMethodMaxBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = new string('a', 50); // Max boundary
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = new string('a', 51); // Max + 1
            aPayment.PaymentMethod = TestData;
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void AmountMinMinusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = -0.01m; // Min - 1
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        [TestMethod]
        public void AmountMinBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = 0.00m; // Min boundary
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = 0.01m; // Min + 1
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        [TestMethod]
        public void AmountMaxMinusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = 9999.99m; // Max - 1
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        [TestMethod]
        public void AmountMaxBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = 10000.00m; // Max boundary
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        [TestMethod]
        public void AmountMaxPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            decimal TestData = 10000.01m; // Max + 1
            aPayment.Amount = TestData;
            Assert.AreEqual(aPayment.Amount, TestData);
        }

        

        [TestMethod]
        public void StatusMinBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = "true"; // Min boundary
            aPayment.Status = Convert.ToBoolean(TestData);
            Assert.AreEqual(aPayment.Status, Convert.ToBoolean(TestData));
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            string TestData = "false"; // Min + 1
            aPayment.Status = Convert.ToBoolean(TestData);
            Assert.AreEqual(aPayment.Status, Convert.ToBoolean(TestData));
        }

    

        [TestMethod]
        public void CreatedOnMinBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime TestData = DateTime.MinValue; // Min boundary
            aPayment.CreatedOn = TestData;
            Assert.AreEqual(aPayment.CreatedOn, TestData);
        }

        [TestMethod]
        public void CreatedOnMinPlusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime TestData = DateTime.MinValue.AddDays(1); // Min + 1
            aPayment.CreatedOn = TestData;
            Assert.AreEqual(aPayment.CreatedOn, TestData);
        }

        [TestMethod]
        public void CreatedOnMaxMinusOne()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime TestData = DateTime.MaxValue.AddDays(-1); // Max - 1
            aPayment.CreatedOn = TestData;
            Assert.AreEqual(aPayment.CreatedOn, TestData);
        }

        [TestMethod]
        public void CreatedOnMaxBoundary()
        {
            ClsPayment aPayment = new ClsPayment();
            DateTime TestData = DateTime.MaxValue; // Max boundary
            aPayment.CreatedOn = TestData;
            Assert.AreEqual(aPayment.CreatedOn, TestData);
        }

        
    }
}

