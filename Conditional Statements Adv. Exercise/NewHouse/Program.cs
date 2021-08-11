using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double discount = 1;
            double priceOfFlowers = 0;
            switch (flowerType)
            {
                case "Roses":
                    if (numberOfFlowers >80)
                    {
                        discount -= 0.1;
                    }
                    priceOfFlowers = numberOfFlowers * 5;
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        discount -= 0.15;
                    }
                    priceOfFlowers = numberOfFlowers * 3.80;
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        discount -= 0.15;
                    }
                    priceOfFlowers = numberOfFlowers * 2.80;
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        discount += 0.15;
                    }
                    priceOfFlowers = numberOfFlowers * 3;
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        discount += 0.2;
                    }
                    priceOfFlowers = numberOfFlowers * 2.50;
                    break;
            }
            double totalPrice = priceOfFlowers * discount;
            if (budget>=totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {budget - totalPrice :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget :f2} leva more.");
            }
        }
    }
}
