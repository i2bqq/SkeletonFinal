using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
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

    }
}
