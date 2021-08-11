using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result =  side * height / 2;
            Console.WriteLine($"{result :f2}");
        }
    }
}
