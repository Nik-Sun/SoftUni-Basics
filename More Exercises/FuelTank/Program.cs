using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

            if (liters < 25)
            {
                switch (fuelType)
                {
                    case "Diesel":
                    case "Gas":
                    case "Gasoline":
                        
                        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;
                }
            }
            else
            {
                switch (fuelType)
                {
                    case "Diesel":
                    case "Gas":
                    case "Gasoline":
                        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;
                }
            }
        }
    }
}
