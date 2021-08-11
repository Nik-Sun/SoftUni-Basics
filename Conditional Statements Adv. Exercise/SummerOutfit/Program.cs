using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempInDegrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            switch (timeOfDay)
            {
                case "Morning":
                    if (tempInDegrees >= 10 && tempInDegrees <=18)
                    {
                        outfit += "Sweatshirt";
                        shoes += "Sneakers";
                    }
                    else if (tempInDegrees >18 && tempInDegrees <=24)
                    {
                        outfit += "Shirt";
                        shoes += "Moccasins";
                    }
                    else if (tempInDegrees >=25)
                    {
                        outfit += "T-Shirt";
                        shoes += "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (tempInDegrees >= 10 && tempInDegrees <= 18)
                    {
                        outfit += "Shirt";
                        shoes += "Moccasins";
                    }
                    else if (tempInDegrees > 18 && tempInDegrees <= 24)
                    {
                        outfit += "T-Shirt";
                        shoes += "Sandals";
                    }
                    else if (tempInDegrees >= 25)
                    {
                        outfit += "Swim Suit";
                        shoes += "Barefoot";
                    }
                    break;
                case "Evening":
                       outfit += "Shirt";
                       shoes += "Moccasins";
                    break;
            }
            Console.WriteLine($"It's {tempInDegrees} degrees, get your {outfit} and {shoes}."
);
        }
    }
}
