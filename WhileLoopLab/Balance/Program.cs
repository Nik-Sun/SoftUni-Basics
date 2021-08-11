using System;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string depositSum = (Console.ReadLine());
            double sum = 0;
            while (depositSum!= "NoMoreMoney")
            {

                double depositSumAsDouble = double.Parse(depositSum);
                if (depositSumAsDouble<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += depositSumAsDouble;
                Console.WriteLine($"Increase: {depositSumAsDouble :f2}" );
                depositSum = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum :f2}");
        }
    }
}
