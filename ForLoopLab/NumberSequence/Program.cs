using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int number = 0;
            int maxNumber = 0;
            int minNumber = 0;
            for (int i = 0; i < numberCount; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maxNumber = number;
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number <= minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
