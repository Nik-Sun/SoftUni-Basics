using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int teddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int toyTrucksCount = int.Parse(Console.ReadLine());

            int totalToysCount = puzzlesCount + talkingDollsCount + teddyBearsCount + minionsCount + toyTrucksCount;
            double discount = 0;
            if (totalToysCount >=50)
            {
                discount = 0.25;
            }
            double profit = (puzzlesCount * 2.6) + (talkingDollsCount * 3) + (teddyBearsCount * 4.1) + (minionsCount * 8.2) + (toyTrucksCount * 2);
            double rent = (profit - (profit*discount))*0.1 ;
            double moneyMade = profit - (profit*discount) - rent;
            if (moneyMade >= holidayPrice)
            {
                Console.WriteLine($"Yes! {moneyMade - holidayPrice :f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! { holidayPrice - moneyMade :f2} lv needed.");
            }
        }
    }
}
