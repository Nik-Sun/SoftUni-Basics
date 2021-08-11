using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }
        }
    }
}
