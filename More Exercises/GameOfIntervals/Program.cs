using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0;
            double from0To9 = 0;
            double from10To19 = 0;
            double from20To29 = 0;
            double from30To39 = 0;
            double from40To49 = 0;
            double andAbove = 0;
            for (int i = 0; i < moves; i++)
            {
                int currentMove = int.Parse(Console.ReadLine());
                if (currentMove>=0&&currentMove<=9)
                {
                    result += currentMove * 0.2;
                    from0To9++;

                }
                else if (currentMove>=10&&currentMove<20)
                {
                    result += currentMove* 0.3;
                    from10To19++;
                }
                else if (currentMove>=20&&currentMove<30)
                {
                    result += currentMove*0.4;
                    from20To29++;
                }
                else if (currentMove >= 30 && currentMove < 40)
                {
                    result += 50;
                    from30To39++;
                }
                else if (currentMove >= 40 && currentMove <= 50)
                {
                    result += 100;
                    from40To49++;
                }
                else
                {
                    result = result/2;
                    andAbove++;
                }
            }
            Console.WriteLine($"{result :f2}");
            Console.WriteLine($"From 0 to 9: {(from0To9/moves)*100 :f2}%");
            Console.WriteLine($"From 10 to 19: {(from10To19/moves)*100 :f2}%");
            Console.WriteLine($"From 20 to 29: {(from20To29/moves)*100:f2}%");
            Console.WriteLine($"From 30 to 39: {(from30To39/moves)*100:f2}%");
            Console.WriteLine($"From 40 to 50: {(from40To49/moves)*100:f2}%");
            Console.WriteLine($"Invalid numbers: {(andAbove/moves)*100:f2}%");
        }
    }
}
