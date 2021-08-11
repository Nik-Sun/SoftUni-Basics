using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int primeSum = 0;
            int nonprimeSum = 0;
            while (numberAsString != "stop")
            {
                int numberAsInt = int.Parse(numberAsString);
                if (numberAsInt<0)
                {
                    Console.WriteLine("Number is negative.");
                    numberAsString = Console.ReadLine();
                    continue;
                }
                int timesDivided = 0;
                for (int i = numberAsInt; i > 0; i--)
                {
                    if (numberAsInt%i==0)
                    {
                        timesDivided++;
                    }
                }
                if (timesDivided == 2)
                {
                    primeSum += numberAsInt;
                }
                else
                {
                    nonprimeSum += numberAsInt;
                }

                numberAsString = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");
        }
    }
}
