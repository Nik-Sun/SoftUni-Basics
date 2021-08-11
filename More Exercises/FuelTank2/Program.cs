using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelInLiters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            bool haveClubCard = clubCard == "Yes";
            double discount = 1;
            double totalPrice = 0;
            if (fuelInLiters>=20 && fuelInLiters <= 25)
            {
                discount = 0.92;
            }
            else if (fuelInLiters>25)
            {
                discount = 0.9;
            }
            if (haveClubCard)
            {
                switch (fuelType)
                {
                    case "Gas":
                        totalPrice = fuelInLiters * 0.85;
                        break;
                    case "Gasoline":
                        totalPrice = fuelInLiters * 2.04;
                        break;
                    case "Diesel":
                        totalPrice = fuelInLiters * 2.21;
                        break;
                }
            }
            else
            {
                switch (fuelType)
                {
                    case "Gas":
                        totalPrice = fuelInLiters * 0.93;
                        break;
                    case "Gasoline":
                        totalPrice = fuelInLiters * 2.22;
                        break;
                    case "Diesel":
                        totalPrice = fuelInLiters * 2.33;
                        break;
                }
            }
            Console.WriteLine($"{totalPrice*discount :f2} lv.");


        }
    }
}
