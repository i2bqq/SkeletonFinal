using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class TestPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsPayment AnPayment = new ClsPayment();
            Assert.IsNotNull(AnPayment);
        }
        [TestMethod]
        public void PaymentIDPropertyOK() 
        {
            ClsPayment Anpayment = new ClsPayment();
            Int32 TestData = 1;
            Anpayment.PaymentID = TestData;
            Assert.AreEqual(Anpayment.PaymentID, TestData);
        }
        [TestMethod]
        public void PaymentDatePropertyOK() 
        {
            ClsPayment AnPayment = new ClsPayment();
            DateTime TestData = DateTime.Now;
            AnPayment.PaymentDate = TestData;
            Assert.AreEqual(AnPayment.PaymentDate, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            ClsPayment AnPayment = new ClsPayment();
            string TestData = "Apple pay";
            AnPayment.PaymentMethod = TestData;
            Assert.AreEqual(AnPayment.PaymentMethod, TestData);
        }
        [TestMethod]
        public void AmountPropertyOK()
        {
            ClsPayment AnPayment = new ClsPayment();
            string TestData = "32";
            AnPayment.Amount = TestData;
            Assert.AreEqual(AnPayment.Amount, TestData);
        }
        [TestMethod]
        public void StatusPropertyOK()
        {
            ClsPayment AnPayment = new ClsPayment();
            Boolean TestData = true;
            AnPayment.Status = TestData;
            Assert.AreEqual(AnPayment.Status, TestData);
        }
    }
}

