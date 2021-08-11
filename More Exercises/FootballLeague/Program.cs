using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;

            for (int i = 0; i < fansCount; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        a++;
                        break;
                    case "B":
                        b++;
                        break;
                    case "V":
                        v++;
                        break;
                    case "G":
                        g++;
                        break;
                }
            }
            Console.WriteLine($"{(a/fansCount)*100 :f2}%");
            Console.WriteLine($"{(b/fansCount)*100 :f2}%");
            Console.WriteLine($"{(v/fansCount)*100 :f2}%");
            Console.WriteLine($"{(g/fansCount)*100 :f2}%");
            Console.WriteLine($"{(fansCount/capacity)*100 :f2}%");
        }
    }
}
