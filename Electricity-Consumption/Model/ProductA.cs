using System.Globalization;

namespace Electricity_Consumption.Model
{
    public class ProductA : ProductBase
    {
        public ProductA(double consumption) {
            BaseCost = 5;
            ConsumptionCostPerUnit = 0.22;
            ProductName = "Basic Electricity Tariff";
            Consumption = consumption;
        }

        public override double AnnualCosts() {
           
            return BaseCost * 12 + Consumption * ConsumptionCostPerUnit;
        }

        public override string ToString()
        {
            CultureInfo de = new CultureInfo("de-DE");
            return $"{ProductName}: Annual costs = {AnnualCosts().ToString("c", de)}/year";
        }

    }
}
