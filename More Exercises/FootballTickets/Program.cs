using System;

namespace FootballTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string tickets = Console.ReadLine();
            int groupCount = int.Parse(Console.ReadLine());
            double transportCost = 0;
            double ticketsCost = 0;
            if (groupCount>=1&&groupCount<=4)
            {
                transportCost = budget * 0.75;
            }
            else if (groupCount>4&&groupCount<=9)
            {
                transportCost = budget * 0.6;
            }
            else if (groupCount>9&&groupCount<=24)
            {
                transportCost = budget * 0.5;
            }
            else if (groupCount>24&&groupCount<=49)
            {
                transportCost = budget * 0.4;
            }
            else
            {
                transportCost = budget * 0.25;
            }
            switch (tickets)
            {
                case "VIP":
                    ticketsCost = groupCount * 499.99;

                    break;
                case "Normal":
                    ticketsCost = groupCount * 249.99;
                    break;
            }
            if (budget>=ticketsCost+transportCost)
            {
                Console.WriteLine($"Yes! You have {budget-(ticketsCost+transportCost) :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(ticketsCost+transportCost)-budget :f2} leva.");
            }
        }
    }
}
//⦁	От 1 до 4 – 75 % от бюджета.
//⦁	От 5 до 9 – 60 % от бюджета.
//⦁	От 10 до 24 – 50 % от бюджета.
//⦁	От 25 до 49 – 40 % от бюджета.
//⦁	50 или повече – 25% от бюджета.
