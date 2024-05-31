using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class TestStockUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsStockUser AnUser = new ClsStockUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDpropertyOk() 
        { 
            ClsStockUser AnUser = new ClsStockUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            ClsStockUser AnUser = new ClsStockUser();
            //create some test data to assign to the property
            string TestData = "Talal";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStockUser AnUser = new ClsStockUser();
            //create some test data to assign to the property
            string TestData = "123123123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            
         Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            ClsStockUser AnUser = new ClsStockUser();
            string TestData = "Stock";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            ClsStockUser AnUser = new ClsStockUser();
            Boolean Found = false;
            string UserName = "Talal";
            string Password = "123123123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
            
        }
        [TestMethod]
        public void TestUserNameStockFound()
        { 
            ClsStockUser AnUser = new ClsStockUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Talal";
            string Password = "123123123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }
    }
}
