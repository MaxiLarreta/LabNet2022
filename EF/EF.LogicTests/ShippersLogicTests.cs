using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.LogicTests;
using EF.Entities;

namespace EF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            InMemoryShippers memory = new InMemoryShippers();
            memory.CreateNewShipper(new Shippers
            {
                ShipperID = 1,
                CompanyName = "New Company",
                Phone = "1535615412"
            }
            );
            memory.CreateNewShipper(new Shippers
            {
                ShipperID = 2,
                CompanyName = "New Company2",
                Phone = "1535615"
            }
            );
            Assert.IsTrue(memory.GetAllShippers().Count() == 2);
        }

        [TestMethod()]
        public void AddTest()
        {

            InMemoryShippers memory = new InMemoryShippers();
            Shippers shipper = new Shippers
            {
                ShipperID = 1,
                CompanyName = "New Company",
                Phone = "1535615412"
            };
            memory.CreateNewShipper(shipper);

            Assert.AreEqual(memory.GetShipperByID(1), shipper);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            InMemoryShippers memory = new InMemoryShippers();
            Shippers shipper = new Shippers
            {
                ShipperID = 1,
                CompanyName = "New Company",
                Phone = "1535615412"
            };
            memory.CreateNewShipper(shipper);
            memory.DeleteShipper(1);
            Assert.IsTrue(memory.GetAllShippers().Count() == 0);
        }
    }
}