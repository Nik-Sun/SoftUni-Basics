using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double solution = (sideA + sideB) * height / 2;
            Console.WriteLine($"{solution :f2}");

        }
    }
}
