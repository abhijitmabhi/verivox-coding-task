using Microsoft.VisualStudio.TestTools.UnitTesting;
using Electricity_Consumption.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Consumption.Model.Tests
{
    [TestClass()]
    public class ProductATests
    {
        [TestMethod()]
        public void ProductAannualCostsTest()
        {
            ProductA productA = new ProductA(3500);
            Assert.AreEqual(830, productA.AnnualCosts());
        }
    }
}