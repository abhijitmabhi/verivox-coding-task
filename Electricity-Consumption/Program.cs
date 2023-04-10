// See https://aka.ms/new-console-template for more information
using Electricity_Consumption.Model;
using System.Text;

Console.WriteLine("------ Tariff Comparison ------ \n");

double[] consumptions = { 3500, 4500, 6000 };

Console.OutputEncoding = Encoding.Default;
Console.OutputEncoding = Encoding.UTF8;


for (int i = 0; i < consumptions.Length; i++)
{
    ProductA productA = new ProductA(consumptions[i]);
    ProductB productB = new ProductB(consumptions[i]);

    Console.WriteLine(consumptions[i] + " kWh/year");
    Console.WriteLine(productA.ToString());
    Console.WriteLine(productB.ToString());
    Console.WriteLine();
}


