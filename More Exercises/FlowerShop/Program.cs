using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int BluebellsCount = int.Parse(Console.ReadLine());
            int RosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double profit = (magnoliasCount * 3.25) + (BluebellsCount * 4) + (RosesCount * 3.5) + (cactusesCount * 8);
            profit -= profit * 0.05;
            if (profit>=giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit-giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-profit)} leva.");
            }
        }
    }
}
