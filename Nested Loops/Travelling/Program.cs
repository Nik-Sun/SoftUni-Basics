using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();  
            double moneySaved = 0;
            while (destination!="End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                while (moneySaved<moneyNeeded)
                {
                    moneySaved += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                moneySaved = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
