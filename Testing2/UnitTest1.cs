using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class TestCustomer
    {
        public object AnCustomer { get; private set; }

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

            AnCustomer.IsActive = TestData;

            Assert.AreEqual(AnCustomer.IsActive, TestData);
        }
        [TestMethod]
        public void PassowrdHashPropertyOK()
        {

            ClsCustomer AnCustomer = new ClsCustomer();

            Boolean TestData = true;

            AnCustomer.IsActive = TestData;

            Assert.AreEqual(AnCustomer.IsActive, TestData);
        }
        [TestMethod]
        public void HireDateAddedPropertyOk()
        {
            ClsCustomer AnStaff = new ClsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnStaff.CreatedOn = TestData;

            Assert.AreEqual(AnStaff.CreatedOn, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void CustomerIdFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.FirstName != "Test Saumya")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void LastNameFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.LastName != "Test Bhakri")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void EmailFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Email != "Test veda1@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void PhoneFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Phone != "Test 07345876302")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void CountryCodeFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CountryCode != "Test UK")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void AddressFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Address != "14 Blue Lane")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        public void IsActiveFound()
        {

            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 21;
            Found = AnCustomer.Find(AddressId);
            if (AnCustomer.IsActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        public void CreatedOnFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CreatedOn != Convert.ToDateTime("16/11/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void PasswordFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Password != "TRGTERYTER2637")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}








  
       
