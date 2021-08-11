using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * lenght * height;
            string boxesCount = Console.ReadLine();

            while (boxesCount != "Done")
            {
                int boxesCountAsInt = Convert.ToInt32(boxesCount);
                volume -= boxesCountAsInt;
                if (volume<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                boxesCount = Console.ReadLine();
            }
            if (volume>=0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
           
        }
    }
}
