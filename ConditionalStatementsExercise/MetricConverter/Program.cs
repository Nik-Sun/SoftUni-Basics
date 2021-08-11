using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberForConversion = double.Parse(Console.ReadLine());
            string unitToConvert = Console.ReadLine();
            string convertToUnit = Console.ReadLine();
            bool convertingMm = unitToConvert == "mm";
            bool convertingCm = unitToConvert == "cm";
            bool convertingM = unitToConvert == "m";
            bool convertToMm = convertToUnit == "mm";
            bool convertToCm = convertToUnit == "cm";
            bool convertToM = convertToUnit == "m";

            if (convertingMm && convertToCm)
            {
                Console.WriteLine($"{numberForConversion * 0.1:f3}");
            }
            else if (convertingMm && convertToM)
            {
                Console.WriteLine($"{numberForConversion * 0.001:f3}");
            }
            else if (convertingCm && convertToMm)
            {
                Console.WriteLine($"{numberForConversion * 10:f3}");
            }
            else if (convertingCm && convertToM)
            {
                Console.WriteLine($"{numberForConversion * 0.01:f3}");
            }
            else if (convertingM && convertToMm)
            {
                Console.WriteLine($"{numberForConversion * 1000:f3}");
            }
            else if (convertingM && convertToCm)
            {
                Console.WriteLine($"{numberForConversion * 100:f3}");
            }
        
        }
    }
}
