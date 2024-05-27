using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        String FirstName = "Talal";
        String LastName = "Alotaibi";
        String Email = "1234f@gmail.com";
        String Phone = "20849172";
        String CountryCode = "US";
        String Role = "dsada";
        String HireDate = "02/05/2022";
        string PasswordHash = "safsaf";


        [TestMethod]
        public void InstanceOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
        public void ActiveStaffPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            Boolean TestData = true;
            AnStaff.Active = TestData;
            Assert.AreEqual(AnStaff.Active, TestData);

        }
        [TestMethod]
        public void HireDateAddedPropertyOk()
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

            string TestData = "US";

            AnStaff.CountryCode = TestData;


            Assert.AreEqual(AnStaff.CountryCode, TestData);

        }
        [TestMethod]
        public void FirstNamePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            string TestData = "harry";

            AnStaff.FirstName = TestData;


            Assert.AreEqual(AnStaff.FirstName, TestData);

        }
        [TestMethod]
        public void LastNamePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            string TestData = "Alotaibi";

            AnStaff.LastName = TestData;


            Assert.AreEqual(AnStaff.LastName, TestData);

        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {

            ClsStaff AnStaff = new ClsStaff();

            Int32 TestData = 1;

            AnStaff.StaffID = TestData;

            Assert.AreEqual(AnStaff.StaffID, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            string TestData = "asdqewfds@gmail.com";

            AnStaff.Email = TestData;


            Assert.AreEqual(AnStaff.Email, TestData);

        }
        [TestMethod]
        public void PhonePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            Int32 TestData = 071642972;

            AnStaff.Phone = TestData;


            Assert.AreEqual(AnStaff.Phone, TestData);

        }
        [TestMethod]
        public void RolePropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            string TestData = "Manager";

            AnStaff.Role = TestData;


            Assert.AreEqual(AnStaff.Role, TestData);

        }
        [TestMethod]
        public void PasswordHashPropertyOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            string TestData = "13281635";

            AnStaff.PasswordHash = TestData;


            Assert.AreEqual(AnStaff.PasswordHash, TestData);

        }
        [TestMethod]
        public void FindMethodOk()
        {
            ClsStaff AnStaff = new ClsStaff();

            Boolean Found = false;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffID != 19)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.FirstName != "Talal")
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
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.LastName != "Alotaibi")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Email != "1234f@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Phone != 20849172)
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
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.CountryCode != "US")
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
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Role != "dsada")
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
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.HireDate != Convert.ToDateTime("02/05/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordHashFound()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 19;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.PasswordHash != "safsaf")
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Role = Role.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Role = Role.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Role = Role.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Role = Role.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordHashMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PasswordHash = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMin()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PasswordHash = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PasswordHash = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PasswordHash = "";
            PasswordHash = PasswordHash.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMax()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PasswordHash = "";
            PasswordHash = PasswordHash.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PasswordHash = "";
            PasswordHash = PasswordHash.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMid()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PasswordHash = "";
            PasswordHash = PasswordHash.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordHashMax500()
        {
            //create an instance of the class we want to create
            ClsStaff AnStaff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PasswordHash = "";
            PasswordHash = PasswordHash.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void HireDateExtremeMax()
        {
            ClsStaff AnStaff = new ClsStaff();
            String  Error = "";
            DateTime  TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string HireDate = TestDate.ToString();
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
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
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HireDateInvalidData()
        {
            ClsStaff AnStaff = new ClsStaff();
            String Error = "";
            string HireDate = "This is not A date !";
            Error = AnStaff.Valid(FirstName, LastName, Email, Role, HireDate, PasswordHash);
            Assert.AreNotEqual(Error, "");

        }





    }

}
