using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = "";
            string carType = "";
            double carPrice = 0;
            if (budget <= 100)
            {
                carClass = "Economy class";
                switch (season)
                {
                    case "Summer":
                        carPrice = budget * 0.35;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        carPrice = budget * 0.65;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        carPrice = budget * 0.45;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        carPrice = budget * 0.80;
                        carType = "Jeep";
                        break;
                }

               
            }
            else
            {
                carClass = "Luxury class";
                carPrice = budget * 0.9;
                carType = "Jeep";
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice :f2}");
        }
    }
}
