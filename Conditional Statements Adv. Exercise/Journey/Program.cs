using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfBed = "";
            double stayCost = 0;
            if (budget <= 100)
            {
                destination += "Bulgaria";
                if (season == "summer")
                {
                    stayCost = budget * 0.3;
                    typeOfBed += "Camp";
                }
                else
                {
                    stayCost = budget * 0.7;
                    typeOfBed += "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination += "Balkans";
                if (season == "summer")
                {
                    stayCost = budget * 0.4;
                    typeOfBed += "Camp";
                }
                else
                {
                    stayCost = budget * 0.8;
                    typeOfBed += "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination += "Europe";
                stayCost = budget * 0.9;
                typeOfBed += "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfBed} - {stayCost:f2}");


        }
    }
}
