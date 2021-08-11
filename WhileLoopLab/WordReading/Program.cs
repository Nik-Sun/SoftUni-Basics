using System;

namespace WordReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            while (words != "Stop")
            {
                Console.WriteLine(words);
                words = Console.ReadLine();
            }
        }
    }
}
