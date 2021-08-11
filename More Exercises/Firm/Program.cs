using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());
            double workHours = Math.Floor(8 * (deadline*0.9) + (overtimeWorkers*2*deadline));
            if (hoursNeeded>workHours)
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-workHours} hours needed.");
            }
            else
            {
                Console.WriteLine($"Yes!{workHours-hoursNeeded} hours left.");
            }

        }
    }
}
