using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int evenNumbersSum = 0;
            int oddNumbersSum = 0;
            int numberToCheck = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                numberToCheck = int.Parse(Console.ReadLine());
                if (i %2 == 0)
                {
                    evenNumbersSum += numberToCheck;
                }
                else
                {
                    oddNumbersSum += numberToCheck;
                }
            }
            if (evenNumbersSum == oddNumbersSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumbersSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenNumbersSum-oddNumbersSum)}");
            }
        }
    }
}
