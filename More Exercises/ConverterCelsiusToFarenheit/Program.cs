using System;

namespace ConverterCelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesC = double.Parse(Console.ReadLine());
            double degreesF = (degreesC * 1.8) + 32;
            Console.WriteLine($"{degreesF :f2}");
        }
    }
}
