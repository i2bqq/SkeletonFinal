using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();

            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerID = TestData;


            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "Nivaro";

            AnCustomer.FirstName = TestData;


            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "Nivaro";

            AnCustomer.LastName = TestData;


            Assert.AreEqual(AnCustomer.LastName, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "sajkfgas@gmail.com";

            AnCustomer.Email = TestData;


            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void PhonePropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "0629876539";

            AnCustomer.Phone = TestData;


            Assert.AreEqual(AnCustomer.Phone, TestData);
        }
        [TestMethod]
        public void CountryCodePropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();

            string TestData = "US";

            AnCustomer.CountryCode = TestData;


            Assert.AreEqual(AnCustomer.CountryCode, TestData);

        }
        public void AddressPropertyOk()
        {
            ClsCustomer AnCustomer = new ClsCustomer();

            string TestData = "W3 3ke";

            AnCustomer.Address = TestData;


            Assert.AreEqual(AnCustomer.Address, TestData);

        }
        [TestMethod]
        public void ActiveCustomerPropertyOK()
        {
            
            ClsCustomer AnCustomer = new ClsCustomer();
            
            Boolean TestData = true;
            
            AnCustomer.Active = TestData;
            
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void PassowrdHashPropertyOK()
        {

            ClsCustomer AnCustomer = new ClsCustomer();

            Boolean TestData = true;

            AnCustomer.Active = TestData;

            Assert.AreEqual(AnCustomer.Active, TestData);
        }
    }
}
