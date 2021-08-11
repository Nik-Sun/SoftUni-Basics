using System;

namespace SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysWorking = 365 - daysOff;
            int playTime = (daysOff * 127) + (daysWorking * 63); 
            if (playTime>=30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs((30000-playTime)/60)} hours and {Math.Abs((30000 - playTime) % 60)} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs((30000 - playTime) / 60)} hours and {Math.Abs((30000 - playTime) % 60)} minutes less for play");
            }
        }
    }
}
