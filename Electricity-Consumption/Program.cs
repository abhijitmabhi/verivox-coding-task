// See https://aka.ms/new-console-template for more information
using Electricity_Consumption.Model;
using Electricity_Consumption.Model.DTO;
using System.Text;

Console.WriteLine("------ Tariff Comparison ------ \n");

double[] consumptions = { 3500, 4500, 6000 };

Console.OutputEncoding = Encoding.Default;
Console.OutputEncoding = Encoding.UTF8;


for (int i = 0; i < consumptions.Length; i++)
{
    ProductA productA = new ProductA(consumptions[i]);
    ProductB productB = new ProductB(consumptions[i]);

    List<TariffComparisonDTO> tariffComparisonLists = new List<TariffComparisonDTO>();

    tariffComparisonLists.Add(new TariffComparisonDTO { TariffName = productA.ToString(), AnnualCosts = productA.AnnualCosts() });
    tariffComparisonLists.Add(new TariffComparisonDTO { TariffName = productB.ToString(), AnnualCosts = productB.AnnualCosts() });

    Console.WriteLine(consumptions[i] + " kWh/year");

    foreach (var item in tariffComparisonLists.OrderBy(x => x.AnnualCosts))
    {
        Console.WriteLine(item.TariffName);
    }

    Console.WriteLine();
}


