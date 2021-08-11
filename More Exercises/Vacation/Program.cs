using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string stayType = "";
            string stayLocation = "";
            double stayPrice = 0;
            if (budget<=1000)
            {
                stayType = "Camp";
                switch (season)
                {
                    case "Summer":
                        stayPrice = budget * 0.65;
                        stayLocation= "Alaska";
                        break;
                    case "Winter":
                        stayPrice = budget * 0.45;
                        stayLocation = "Morocco";
                        break;
                }
            }
            else if (budget>1000&&budget<=3000)
            {
                stayType = "Hut";
                switch (season)
                {
                    case "Summer":
                        stayPrice = budget * 0.80;
                        stayLocation = "Alaska";
                        break;
                    case "Winter":
                        stayPrice = budget * 0.60;
                        stayLocation = "Morocco";
                        break;
                }
            }
            else
            {
                stayType = "Hotel";
                stayPrice = budget * 0.90;
                switch (season)
                {
                    case "Summer":    
                        stayLocation = "Alaska";
                        break;
                    case "Winter":
                        stayLocation = "Morocco";
                        break;
                }
            }
            Console.WriteLine($"{stayLocation} - {stayType} - {stayPrice :f2}");
        }
    }
}
