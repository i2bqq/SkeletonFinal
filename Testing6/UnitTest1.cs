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
    }
}
