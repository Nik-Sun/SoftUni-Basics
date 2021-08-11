using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNotHome = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodInKg = double.Parse(Console.ReadLine());
            double catFoodInKg = double.Parse(Console.ReadLine());
            double turtleFoodInGrams = double.Parse(Console.ReadLine());
            double foodEaten =  (dogFoodInKg + catFoodInKg + (turtleFoodInGrams/1000))*daysNotHome;
            if (foodEaten>foodLeft)
            {
                Console.WriteLine($"{Math.Ceiling(foodEaten-foodLeft)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft-foodEaten)} kilos of food left.");
            }

        }
    }
}
