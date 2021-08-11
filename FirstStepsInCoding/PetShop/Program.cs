using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherPetsCount = int.Parse(Console.ReadLine());
            double moneyNeeeded = (dogsCount * 2.5) + (otherPetsCount * 4);
            Console.WriteLine($"{ moneyNeeeded} lv.");
        }
    }
}
