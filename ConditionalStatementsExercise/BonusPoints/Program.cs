using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (initialPoints <=100)
            {
                bonusPoints = bonusPoints+5;
            }
            else if (initialPoints>1000)
            {
                bonusPoints = bonusPoints + (initialPoints * 0.1);
            }
            else 
            {
                bonusPoints = bonusPoints + (initialPoints * 0.2);
            }
            bool pointsIsEven = initialPoints % 2 == 0 ;
            bool pointsIsEndsOn5 = initialPoints % 5 == 0;
            if (pointsIsEven)
            {
                bonusPoints++;
            }
            else if (pointsIsEndsOn5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(initialPoints + bonusPoints);
        }
        

    }
}
