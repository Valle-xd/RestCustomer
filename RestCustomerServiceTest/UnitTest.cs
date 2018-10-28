using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestServiceTest.Controllers;
using RestServiceTest;

namespace RestCustomerServiceTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetOne()
        {
            CustomerController cc = new CustomerController();
            //Customer c = new Customer(1, "Knud", "dunk", 2019);

            Assert.AreEqual("Knud", cc.GetId(1).FirstName);
        }

        public void GetAll()
        {
            CustomerController cc = new CustomerController();
            List<Customer> cList = cc.Get();
            Assert.AreEqual("Knud", cList[0].FirstName);

        }

        [TestMethod]
        public void Post()
        {
            CustomerController cc = new CustomerController();
            Customer cToPost = new Customer(100, "Dang", "brutha", 2080);
            cc.Post(cToPost);
            Assert.AreEqual(cToPost.FirstName, cc.GetId(cToPost.Id).FirstName);
        }
        [TestMethod]
        public void Put()
        {
            CustomerController cc = new CustomerController();
            Customer cToPut = new Customer(100, "Dang", "brutha", 2080);
            cc.Put(cToPut.Id, cToPut);
            Assert.AreEqual(cToPut.FirstName, cc.GetId(cToPut.Id).FirstName);
        }
        [TestMethod]
        public void Delete()
        {
            CustomerController cc = new CustomerController();
            //Customer cToPost = new Customer(100, "Dang", "brutha", 2080);
            //cc.Post((cToPost));
            cc.Delete(1);
            Customer cGet = cc.GetId(1);
            Console.WriteLine(cGet);
            Assert.IsNull(cGet);
        }
    }
}
