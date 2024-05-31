using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Security.Policy;

namespace Testing2
{
    [TestClass]
    public class TestCustomer
    {
        string CustomerID = "2";
        string FirstName = "Sally";
        string LastName = "Brown";
        string Email = "sbrown@gmail.com";
        string Phone = "07836527197";
        string CountryCode = "US";
        string Address = "12 Blue lane";
        string IsActive = "True";
        string CreatedOn = "12/12/24";
        string Password = "Blue1234";
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
        [TestMethod]
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
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void CustomerIdFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 2)
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
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.FirstName != "Saumya")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.LastName != "Bhakri")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EmailFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Email != "grey@mycloud.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PhoneFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Phone != "097652459810")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CountryCodeFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CountryCode != "US")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Address != "12 Blossom Street ")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void IsActiveFound()
        {

            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 2;
            Found = AnCustomer.Find(AddressId);
            if (AnCustomer.IsActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CreatedOnFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CreatedOn != Convert.ToDateTime("12/09/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PasswordFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Password != "wer345")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void ValidMethodOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void LastNameMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            FirstName = FirstName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            FirstName = FirstName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = "";
            FirstName = FirstName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void EmailMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "";
            FirstName = FirstName.PadRight(99, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "";
            FirstName = FirstName.PadRight(100, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "";
            FirstName = FirstName.PadRight(101, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Email = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void PhoneMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "";
            FirstName = FirstName.PadRight(19, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonelMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "";
            FirstName = FirstName.PadRight(20, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "";
            FirstName = FirstName.PadRight(21, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phone = "";
            FirstName = FirstName.PadRight(10, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");

        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]

        public void CreatedOnExtremeMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CreatedOn = TestDate.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CreatedOnExtremeMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CreatedOn = TestDate.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CreatedOnEMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string CreatedOn = TestDate.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CreatedOnMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CreatedOn = TestDate.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CreatedOnExtremeMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string CreatedOn = TestDate.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void AddressMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            FirstName = FirstName.PadRight(99, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            FirstName = FirstName.PadRight(100, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            FirstName = FirstName.PadRight(101, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void PasswordMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Address = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Password = "";
            FirstName = FirstName.PadRight(99, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Password = "";
            FirstName = FirstName.PadRight(100, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Password = "";
            FirstName = FirstName.PadRight(101, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Password = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            Assert.AreEqual(Error, "");
        }

    }
}

        
