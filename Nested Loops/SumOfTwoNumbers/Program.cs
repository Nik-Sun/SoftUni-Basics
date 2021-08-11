using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;     
            for (int i = start; i <= end; i++)
            {
                for (int ii = start; ii <= end; ii++)
                {
                    combinations++;
                    if (i+ii==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {ii} = {magicNumber})");
                        return;
                    }             
                }                
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            
        }
    }
}
