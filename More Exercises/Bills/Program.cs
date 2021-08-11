using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            double electricityTotal = 0;
            double other = 0;
            
            for (int i = 0; i < period; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityTotal += electricity;
                other += (electricity + 15 + 20) * 1.2;
            }
            Console.WriteLine($"Electricity: {electricityTotal :f2} lv");
            Console.WriteLine($"Water: {period * 20:f2} lv");
            Console.WriteLine($"Internet: {period * 15:f2} lv");
            Console.WriteLine($"Other: {other :f2} lv");
            Console.WriteLine($"Average: {((electricityTotal+other)+(period*20)+(period*15))/period :f2} lv");
        }
    }
}
