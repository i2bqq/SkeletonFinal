using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class CustomerUsertest
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsCustomerUser AnUser = new ClsCustomerUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDpropertyOk()
        {
            ClsCustomerUser AnUser = new ClsCustomerUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            ClsCustomerUser AnUser = new ClsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Saumya";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            ClsCustomerUser AnUser = new ClsCustomerUser();
            //create some test data to assign to the property
            string TestData = "sb1";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same

            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            ClsCustomerUser AnUser = new ClsCustomerUser();
            string TestData = "Customer";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            ClsCustomerUser AnUser = new ClsCustomerUser();

            Boolean Found = false;
            string UserName = "Saumya";
            string Password = "sb1";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestUserNameCustomerFound()
        {
            ClsCustomerUser AnUser = new ClsCustomerUser();

            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Saumya";
            string Password = "sb1";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }
    }
}
