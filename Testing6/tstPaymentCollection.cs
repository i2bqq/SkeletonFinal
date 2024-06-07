using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<ClsPayment> TestList = new List<ClsPayment>();
            ClsPayment TestItem = new ClsPayment();
            TestItem.PaymentID = 3;
            TestItem.OrderID = 2;
            TestItem.PaymentDate = Convert.ToDateTime("01/06/2023");
            TestItem.PaymentMethod = "Card";
            TestItem.Amount = 10.00m;
            TestItem.Status = true;
            TestItem.CreatedOn = Convert.ToDateTime("01/06/2023");
            TestList.Add(TestItem);
            AllPayments.PaymentList = TestList;
            Assert.AreEqual(AllPayments.PaymentList.Count, TestList.Count);
            Assert.AreEqual(AllPayments.PaymentList[0].PaymentID, TestItem.PaymentID);
        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            ClsPayment TestPayment = new ClsPayment();
            TestPayment.PaymentID = 3;
            TestPayment.OrderID = 2;
            TestPayment.PaymentDate = Convert.ToDateTime("01/06/2023");
            TestPayment.PaymentMethod = "Card";
            TestPayment.Amount = 10.00m;
            TestPayment.Status = true;
            TestPayment.CreatedOn = Convert.ToDateTime("01/06/2023");
            AllPayments.ThisPayment = TestPayment;
            Assert.AreEqual(AllPayments.ThisPayment.PaymentID, TestPayment.PaymentID);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<ClsPayment> TestList = new List<ClsPayment>();
            ClsPayment TestItem = new ClsPayment();
            TestItem.PaymentID = 3;
            TestItem.OrderID = 2;
            TestItem.PaymentDate = Convert.ToDateTime("01/06/2023");
            TestItem.PaymentMethod = "Card";
            TestItem.Amount = 10.00m;
            TestItem.Status = true;
            TestItem.CreatedOn = Convert.ToDateTime("01/06/2023");
            TestList.Add(TestItem);
            AllPayments.PaymentList = TestList;
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            ClsPayment TestItem = new ClsPayment();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 4;
            TestItem.PaymentDate = Convert.ToDateTime("01/06/2024");
            TestItem.PaymentMethod = "Card";
            TestItem.Amount = 10.00m;
            TestItem.Status = true;
            TestItem.CreatedOn = Convert.ToDateTime("01/06/2024");
            AllPayments.ThisPayment = TestItem;
            PrimaryKey = AllPayments.Add();
            TestItem.PaymentID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentID, TestItem.PaymentID);
            Assert.AreEqual(AllPayments.ThisPayment.OrderID, TestItem.OrderID);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentDate, TestItem.PaymentDate);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentMethod, TestItem.PaymentMethod);
            Assert.AreEqual(AllPayments.ThisPayment.Amount, TestItem.Amount);
            Assert.AreEqual(AllPayments.ThisPayment.Status, TestItem.Status);
            Assert.AreEqual(AllPayments.ThisPayment.CreatedOn, TestItem.CreatedOn);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            ClsPayment TestItem = new ClsPayment();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 4;
            TestItem.PaymentDate = Convert.ToDateTime("01/06/2024");
            TestItem.PaymentMethod = "Card";
            TestItem.Amount = 10.00m;
            TestItem.Status = true;
            TestItem.CreatedOn = Convert.ToDateTime("01/06/2024");
            AllPayments.ThisPayment = TestItem;
            PrimaryKey = AllPayments.Add();
            TestItem.PaymentID = PrimaryKey;
            TestItem.OrderID = 5;
            TestItem.PaymentDate = Convert.ToDateTime("02/06/2024");
            TestItem.PaymentMethod = "Cash";
            TestItem.Amount = 15.00m;
            TestItem.Status = false;
            TestItem.CreatedOn = Convert.ToDateTime("02/06/2024");
            AllPayments.ThisPayment = TestItem;
            AllPayments.Update();
            AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentID, TestItem.PaymentID);
            Assert.AreEqual(AllPayments.ThisPayment.OrderID, TestItem.OrderID);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentDate, TestItem.PaymentDate);
            Assert.AreEqual(AllPayments.ThisPayment.PaymentMethod, TestItem.PaymentMethod);
            Assert.AreEqual(AllPayments.ThisPayment.Amount, TestItem.Amount);
            Assert.AreEqual(AllPayments.ThisPayment.Status, TestItem.Status);
            Assert.AreEqual(AllPayments.ThisPayment.CreatedOn, TestItem.CreatedOn);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            ClsPayment TestItem = new ClsPayment();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 4;
            TestItem.PaymentDate = Convert.ToDateTime("01/06/2024");
            TestItem.PaymentMethod = "Card";
            TestItem.Amount = 10.00m;
            TestItem.Status = true;
            TestItem.CreatedOn = Convert.ToDateTime("01/06/2024");
            AllPayments.ThisPayment = TestItem;
            PrimaryKey = AllPayments.Add();
            TestItem.PaymentID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);
            AllPayments.Delete();
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPaymentMethodMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            FilteredPayments.ReportByPaymentMethod("");
            Assert.AreEqual(AllPayments.Count, FilteredPayments.Count);
        }

        [TestMethod]
        public void ReportByPaymentMethodNoneFound()
        {
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            FilteredPayments.ReportByPaymentMethod("xxxxxxx");
            Assert.AreEqual(0, FilteredPayments.Count);
        }

        [TestMethod]
        public void FindMethodOK()
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

        // Additional Tests

        [TestMethod]
        public void EmptyPaymentList()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<ClsPayment> TestList = new List<ClsPayment>();
            AllPayments.PaymentList = TestList;
            Assert.AreEqual(AllPayments.PaymentList.Count, 0);
        }

        [TestMethod]
        public void PaymentListMultipleItems()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<ClsPayment> TestList = new List<ClsPayment>();
            for (int i = 0; i < 10; i++)
            {
                ClsPayment TestItem = new ClsPayment();
                TestItem.PaymentID = i + 1;
                TestItem.OrderID = i + 2;
                TestItem.PaymentDate = DateTime.Now;
                TestItem.PaymentMethod = "Card";
                TestItem.Amount = 10.00m;
                TestItem.Status = true;
                TestItem.CreatedOn = DateTime.Now;
                TestList.Add(TestItem);
            }
            AllPayments.PaymentList = TestList;
            Assert.AreEqual(AllPayments.PaymentList.Count, 10);
        }
    }
}
