using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        string FirstName = "meet";
        string LastName = "patel";
        string EmailID = "meet030405@gmail.com";
        string Contact = "1234567896";
        string CountryCode = "45";
        string Role = "HR";
        string HireDate = DateTime.Now.ToShortDateString();
        string Password = "meet123";

        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of a class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //test to see if that exists
            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
        public void StafIsActivePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean TestData = true;
            AnStaff.IsActive = TestData;
            Assert.AreEqual(AnStaff.IsActive, TestData);

        }
        [TestMethod]
        public void HireDatePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.HireDate = TestData;
            Assert.AreEqual(AnStaff.HireDate, TestData);

        }
        [TestMethod]
        public void CountryCodePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            Int32 TestData = 45;
            AnStaff.CountryCode = TestData;
            Assert.AreEqual(AnStaff.CountryCode, TestData);

        }
        [TestMethod]
        public void FirstNamePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "meet";
            AnStaff.FirstName = TestData;
            Assert.AreEqual(AnStaff.FirstName, TestData);

        }
        [TestMethod]
        public void LastNamePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "patel";
            AnStaff.LastName = TestData;
            Assert.AreEqual(AnStaff.LastName, TestData);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            ClsStaff AnStaff = new ClsStaff();
            Int32 TestData = 1;
            AnStaff.StaffID = TestData;
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }
        [TestMethod]
        public void EmailIDPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "meet030405@gmail.com";
            AnStaff.EmailID = TestData;
            Assert.AreEqual(AnStaff.EmailID, TestData);

        }
        [TestMethod]
        public void ContactPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            Int32 TestData = 1234567896;
            AnStaff.Contact = TestData;
            Assert.AreEqual(AnStaff.Contact, TestData);

        }
        [TestMethod]
        public void RolePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "HR";
            AnStaff.Role = TestData;
            Assert.AreEqual(AnStaff.Role, TestData);

        }
        [TestMethod]
        public void PasswordPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "meet123";
            AnStaff.Password = TestData;
            Assert.AreEqual(AnStaff.Password, TestData);

        }
        [TestMethod]
        public void FindMethodOk()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffID()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.FirstName != "meet")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.LastName != "patel")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmaiIDlFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.EmailID != "meet030405@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Contact != 1234567896)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountryCodeFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.CountryCode != 44)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRoleFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Role != "HR")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHireDateFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.HireDate != Convert.ToDateTime("05/03/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsActiveFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.IsActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Password != "meet123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsStaff AnStaff = new ClsStaff();
            string Error = "";
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(13, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(14, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string FirstName = "";
            FirstName = FirstName.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(7, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(13, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(14, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string LastName = "";
            LastName = LastName.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(7, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmaiIDlMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmailID = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmailID = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmailID = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmailID = "meet030405@gmail.com";
            EmailID = EmailID.PadRight(23, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmailID = "";
            EmailID = EmailID.PadRight(24, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmailID = "";
            EmailID = EmailID.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmailID = "";
            EmailID = EmailID.PadRight(12, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIDMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmailID = "";
            EmailID = EmailID.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct    
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "";
            Role = Role.PadRight(13, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "";
            Role = Role.PadRight(14, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role = "";
            Role = Role.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "";
            Role = Role.PadRight(7, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role = "";
            Role = Role.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(17, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(18, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(19, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(9, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            ClsStaff AnStaff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string HireDate = TestDate.ToString();
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HireDateMaxPlusOne()
        {
            ClsStaff AnStaff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string HireDate = TestDate.ToString();
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HireDateInvalidData()
        {
            ClsStaff AnStaff = new ClsStaff();
            String Error = "";
            string HireDate = "This is not A date !";
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HireDateExtremeMin()
        {
            ClsStaff AnStaff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string HireDate = TestDate.ToString();
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HireDateMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, EmailID, Role, HireDate, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
