using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TestUserOrderItem
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOk()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            Int32 TestData = 1;
            AnUser.UserID =TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOk()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            String TestData = "Talal";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOk()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            String TestData = "123123123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOk()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            String TestData = "Stock";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethod()
        {
            ClsOrderitemUser AnUser = new ClsOrderitemUser();
            Boolean Found = false;
            string UserName = "Talal";
            string Password = "123123123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
    }
}
