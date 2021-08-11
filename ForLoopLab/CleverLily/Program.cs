using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMaschinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            int toysCount = 0;
            double moneySaved = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 ==0)
                {
                    moneySaved += (5*i);
                    moneySaved--;
                }
                else
                {
                    toysCount++;
                }
            }
            moneySaved += toysCount * toysPrice;
            if (moneySaved>=washingMaschinePrice)
            {
                Console.WriteLine($"Yes! {moneySaved-washingMaschinePrice :f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMaschinePrice-moneySaved :f2}");
            }
        }
    }
}
