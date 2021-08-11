using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int iterations = 0;
            for (int i = 0; i <= number; i++)
            {
                for (int ii = 0; ii <= number; ii++)
                {
                    for (int iii = 0; iii <= number; iii++)
                    {
                        if (i+ii+iii==number)
                        {
                            iterations++;
                        }
                    }
                }
            }
            Console.WriteLine(iterations);
        }
    }
}
