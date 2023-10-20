using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electricity_Consumption.Model.Tests
{
    [TestClass()]
    public class ProductBTests
    {
        [TestMethod()]
        public void ProductB_Annual_Cost_For_UpTo_4000_kWh_Per_year()
        {
            ProductB productB = new ProductB(4000);
            Assert.AreEqual(800, productB.AnnualCosts());

            productB = new ProductB(4100);
            Assert.IsTrue(800 < productB.AnnualCosts());

        }

        [TestMethod()]
        public void ProductB_Annual_Cost_For_More_Than_4000_kWh_Per_year()
        {
            ProductB productB = new ProductB(6000);
            Assert.AreEqual(1400, productB.AnnualCosts());

        }

    }
}