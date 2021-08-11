using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salary = 0;
            if (kmPerMonth<=5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = (kmPerMonth * 4) * 0.75;
                        break;
                    case "Summer":
                        salary = (kmPerMonth * 4) * 0.90;
                        break;
                    case "Winter":
                        salary = (kmPerMonth * 4) * 1.05;
                        break;

                }
            }
            else if (kmPerMonth>5000 && kmPerMonth<=10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = (kmPerMonth * 4) * 0.95;
                        break;
                    case "Summer":
                        salary = (kmPerMonth * 4) * 1.10;
                        break;
                    case "Winter":
                        salary = (kmPerMonth * 4) * 1.25;
                        break;

                }
            }
            else if (kmPerMonth>10000&&kmPerMonth<=20000)
            {
                salary = (kmPerMonth * 4) * 1.45;
            }
            Console.WriteLine($"{salary*0.90 :f2}");
        }
    }
}
