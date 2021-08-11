using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            bool isNumberValid = number >= -100 && number <= 100 && number != 0;
            if (isNumberValid)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
