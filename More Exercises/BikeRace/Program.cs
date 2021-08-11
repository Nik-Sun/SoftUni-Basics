using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string courseType = Console.ReadLine();
            double moneyRaised = 0;
            switch (courseType)
            {
                case "trail":
                    moneyRaised = (juniorsCount * 5.50) + (seniorsCount * 7);
                    break;
                case "cross-country":
                    if (juniorsCount+seniorsCount>=50)
                    {
                        moneyRaised= (juniorsCount * (8*0.75)) + (seniorsCount * (9.5 * 0.75));
                    }
                    else
                    {
                        moneyRaised = (juniorsCount * 8) + (seniorsCount * 9.5);
                    }
                    break;
                case "downhill":
                    moneyRaised = (juniorsCount * 12.25) + (seniorsCount * 13.75);
                    break;
                case "road":
                    moneyRaised = (juniorsCount * 20) + (seniorsCount * 21.5);
                    break;
            }
            Console.WriteLine($"{moneyRaised-=moneyRaised*0.05:f2}");
        }
    }
}
