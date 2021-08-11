using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double boatRent = 0;
            double discount = 1;

            if (fishermanCount <= 6)
            {
                discount -= 0.1;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                discount -= 0.15;
            }
            else if (fishermanCount >= 12)
            {
                discount -= 0.25;
            }

            switch (season)
            {
                case "Spring":
               
                    boatRent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatRent = 4200;
                    break;
                case "Winter":
                    boatRent = 2600;
                    break;
            }
            double totalPrice = boatRent * discount;
            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                totalPrice *= 0.95;
            }
            if (groupBudget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {groupBudget - totalPrice :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - groupBudget :f2} leva.");
            }
        }
	

	}
}


