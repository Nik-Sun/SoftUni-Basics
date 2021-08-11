using System;

namespace OddorEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <=numbersCount; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 ==0)
                {
                    evenSum += number;
                    if (number <evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number<oddMin)
                    {
                        oddMin = number;
                    }
                    if (number>oddMax)
                    {
                        oddMax = number;
                    }
                }
            }
            if (oddMin==double.MaxValue)
            {
                Console.WriteLine($"OddSum={oddSum :f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum :f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (evenMin==double.MaxValue)
            {
                Console.WriteLine($"OddSum={oddSum :f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin :f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");

            }
        }
    }
}
