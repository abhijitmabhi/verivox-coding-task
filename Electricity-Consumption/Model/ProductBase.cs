namespace Electricity_Consumption.Model
{
    public abstract class ProductBase
    {
        protected string ProductName { get; set; } = string.Empty;
        protected double BaseCost { get; set; }
        protected double ConsumptionCostPerUnit { get; set; }
        protected double Consumption { get; set; }
        
        public abstract double AnnualCosts();
        
    }
}
