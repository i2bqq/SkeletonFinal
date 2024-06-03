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
    }
}
