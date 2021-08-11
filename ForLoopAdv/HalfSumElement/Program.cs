using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (maxNumber<number)
                {
                    maxNumber = number;
                    sum += number;
                }
                else
                {
                    sum += number;
                }
            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if (maxNumber  == sumWithoutMaxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNumber}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNumber-maxNumber)}");
            }
        }
    }
}
