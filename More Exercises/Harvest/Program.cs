using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldInSqM = int.Parse(Console.ReadLine());
            double kgGrapesPerSqM = double.Parse(Console.ReadLine());
            int litersWineNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            double grapesProduced = fieldInSqM * kgGrapesPerSqM;
            double wineProduced =((grapesProduced / 2.5)*0.4);
            if (wineProduced>=litersWineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineProduced-litersWineNeeded)} liters left -> {Math.Ceiling((wineProduced - litersWineNeeded)/workersCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersWineNeeded-wineProduced)} liters wine needed.");

            }
        }
    }
}
