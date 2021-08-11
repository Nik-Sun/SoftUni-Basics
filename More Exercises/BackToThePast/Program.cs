using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int currentYear = 1800;
            int age = 18;
            double moneySpend = 0;
            while (currentYear<=yearToLive)
            {
                
                if (currentYear%2==0)
                {
                    moneySpend += 12000;
                }
                else 
                {
                    moneySpend += 12000 + (50 * age);         
                }
                currentYear++;
                age++;

            }
            if (moneySpend<=heritage)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage-moneySpend :f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneySpend-heritage :f2} dollars to survive.");
            }
        }
    }
}
