using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDpropertyOk()
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            Int32 TestData = 4;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            ClsStaffUser AnUser = new ClsStaffUser();
            //create some test data to assign to the property
            string TestData = "Meet";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStaffUser AnUser = new ClsStaffUser();
            //create some test data to assign to the property
            string TestData = "0611";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same

            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            string TestData = "staff";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            Boolean Found = false;
            string UserName = "Meet";
            string Password = "0611";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestUserNameFound()
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Meet";
            string Password = "0611";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }
    }
}
