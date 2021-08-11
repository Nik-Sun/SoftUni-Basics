using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double stepsCount = 0;
            while (stepsCount<10000)
            {
                
               string stepsAsString = Console.ReadLine();
                if (stepsAsString =="Going home")
                {
                    stepsCount += double.Parse(Console.ReadLine());
                    break;
                }
                stepsCount += Convert.ToDouble(stepsAsString);
            }
            if (stepsCount>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(10000 -stepsCount)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000- stepsCount} more steps to reach goal.");
            }
        }
    }
}
