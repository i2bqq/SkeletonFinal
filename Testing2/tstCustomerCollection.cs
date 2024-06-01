using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            List<ClsCustomer>TestList = new List<ClsCustomer>();
            ClsCustomer TestItem = new ClsCustomer();
            TestItem.IsActive = true;
            
        }
    }
}
