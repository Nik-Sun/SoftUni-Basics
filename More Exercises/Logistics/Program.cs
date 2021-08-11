using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            double cargoShipped = 0;
            double busCargo = 0;
            double truckCargo = 0;
            double tranVCargo = 0;
            double totalCost = 0;
            double tonnage = 0;
            while (cargoShipped<cargoCount)
            {
                int cargoInTonnes = int.Parse(Console.ReadLine());
                if (cargoInTonnes<=3)
                {
                    cargoShipped++;
                    busCargo+=cargoInTonnes;
                    totalCost += cargoInTonnes * 200;
                    tonnage += cargoInTonnes;
                }
                else if (cargoInTonnes>3&&cargoInTonnes<=11)
                {
                    cargoShipped++;
                    truckCargo+=cargoInTonnes;
                    totalCost += cargoInTonnes * 175;
                    tonnage += cargoInTonnes;
                }
                else
                {
                    cargoShipped++;
                    tranVCargo+=cargoInTonnes;
                    totalCost += cargoInTonnes * 120;
                    tonnage += cargoInTonnes;
                }
            
            }
            Console.WriteLine($"{(totalCost/ tonnage) :f2}");
            Console.WriteLine($"{(busCargo/tonnage)*100 :f2}%");
            Console.WriteLine($"{(truckCargo / tonnage) * 100 :f2}%");
            Console.WriteLine($"{(tranVCargo / tonnage) * 100 :f2}%");
        }
    }
}
