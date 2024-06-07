using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstPaymentUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "Nivar";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "123";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "Payment";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            bool found = AUser.FindUser("Nivar", "123");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            bool found = AUser.FindUser("Nivar", "123");
            Assert.IsTrue(found);
            Assert.AreEqual(AUser.UserName, "Nivar");
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            bool found = AUser.FindUser("Nivar", "123");
            Assert.IsTrue(found);
            Assert.AreEqual(AUser.Password, "123");
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            bool found = AUser.FindUser("Nivar", "123");
            Assert.IsTrue(found);
            Assert.AreEqual(AUser.Department, "Payment");
        }

        // Additional Tests

        [TestMethod]
        public void EmptyUserName()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void LongUserName()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 51);
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void SpecialCharactersUserName()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "!@#$%^&*()";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void EmptyPassword()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void LongPassword()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('1', 51);
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void FindUserInvalidCredentials()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            bool found = AUser.FindUser("InvalidUser", "InvalidPassword");
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void UserNameMinMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = ""; // Min - 1
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void UserNameMinBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "a"; // Min boundary
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "ab"; // Min + 1
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void UserNameMaxMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 49); // Max - 1
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void UserNameMaxBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 50); // Max boundary
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 51); // Max + 1
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordMinMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = ""; // Min - 1
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "1"; // Min boundary
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "12"; // Min + 1
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void PasswordMaxMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('1', 49); // Max - 1
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('1', 50); // Max boundary
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('1', 51); // Max + 1
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentMinMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = ""; // Min - 1
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void DepartmentMinBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "P"; // Min boundary
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = "Pa"; // Min + 1
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void DepartmentMaxMinusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 49); // Max - 1
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void DepartmentMaxBoundary()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 50); // Max boundary
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            clsPaymentUser AUser = new clsPaymentUser();
            string TestData = new string('a', 51); // Max + 1
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }
    


    }
}

