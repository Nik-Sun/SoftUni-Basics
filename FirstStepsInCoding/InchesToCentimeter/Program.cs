using System;

namespace InchestoCentimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeters = double.Parse(Console.ReadLine());
            Console.WriteLine(centimeters * 2.54);
        }
    }
}
