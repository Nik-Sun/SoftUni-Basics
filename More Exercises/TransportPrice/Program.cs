using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kmToTravel = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;
            if (kmToTravel>=100)
            {
                price+=kmToTravel * 0.06;
            }
            else if (kmToTravel>=20)
            {
                price += kmToTravel * 0.09;
            }
            else
            {
                switch (dayOrNight)
                {
                    case "day":
                        price += (kmToTravel * 0.79)+0.70;
                        break;
                    case "night":
                        price += (kmToTravel * 0.90) + 0.70;
                        break;
                }
            }
            Console.WriteLine($"{price :f2}");
        }
    }
}
