using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersCount = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 1 && number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number < 400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{(p1 / numbersCount) * 100:f2}%");
            Console.WriteLine($"{(p2 / numbersCount) * 100:f2}%");
            Console.WriteLine($"{(p3 / numbersCount) * 100:f2}%");
            Console.WriteLine($"{(p4 / numbersCount) * 100:f2}%");
            Console.WriteLine($"{(p5 / numbersCount) * 100:f2}%");

        }
    }
}
