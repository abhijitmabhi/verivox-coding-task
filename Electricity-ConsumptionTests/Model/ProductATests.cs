using Microsoft.VisualStudio.TestTools.UnitTesting;

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