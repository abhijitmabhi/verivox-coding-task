using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Consumption.Model
{
    public class ProductB : ProductBase
    {
        public ProductB(double consumption) {
            BaseCost = 800;
            ConsumptionCostPerUnit = 0.30;
            ProductName = "Packaged tariff";
            Consumption = consumption;
        }
        public override double AnnualCosts()
        {
            if(Consumption <= 4000)
            {
                return 800;
            }
            else
            {
                return 800 + (Consumption - 4000) * ConsumptionCostPerUnit;
            }
        }

        public override string ToString()
        {
            CultureInfo de = new CultureInfo("de-DE");
            return $"{ProductName}: Annual costs = {AnnualCosts().ToString("c", de)}/year";
        }
    }
}
