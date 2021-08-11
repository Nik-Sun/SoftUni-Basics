using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double moneyAvalible = double.Parse(Console.ReadLine());
            int daysConsistantSpending = 0;
            int daysPassed = 0;
            while (moneyAvalible<vacationCost)
            {               
                if (daysConsistantSpending<5)
                {
                    daysPassed++;
                    string transaction = Console.ReadLine();
                    switch (transaction)
                    {

                        case "spend":
                            moneyAvalible -= double.Parse(Console.ReadLine());
                            daysConsistantSpending++;
                            if (moneyAvalible <=0)
                            {
                                moneyAvalible = 0;
                            }
                            break;
                        case "save":
                            moneyAvalible += double.Parse(Console.ReadLine());
                            daysConsistantSpending=0;
                            break;
                    }
                }
                else
                {
                    break;
                }
                
            }
            if (moneyAvalible>=vacationCost)
            {
                Console.WriteLine($"You saved the money for {daysPassed} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysPassed}");
            }

        }
    }
}
