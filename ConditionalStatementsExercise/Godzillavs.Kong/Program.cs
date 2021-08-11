using System;

namespace Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            double extrasCount = double.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
            double movieDecor = movieBudget * 0.1;
            double costumeDiscount = 0;
            if (extrasCount >150)
            {
                costumeDiscount = (extrasCount*costumePrice) * 0.1;
            }
            double movieCost = extrasCount * costumePrice - (costumeDiscount) + (movieDecor);
            if (movieCost>movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {movieCost - movieBudget:F2} leva more.");
            }
            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - movieCost:F2} leva left."
);
            }
        }
    }
}
