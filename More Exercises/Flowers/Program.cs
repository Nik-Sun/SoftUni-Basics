using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int daisyesCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            bool isHoliday = ("Y" == Console.ReadLine());
            double flowersCount = daisyesCount + rosesCount + tulipsCount;
            double flowersPrice = 0;
            
            switch (season)
            {
                case "Winter":
                case "Autumn":
                    flowersPrice = (daisyesCount * 3.75) + (rosesCount * 4.5) + (tulipsCount * 4.15);
                    if (isHoliday)
                    {
                        flowersPrice *= 1.15;
                        
                    }
                    if (rosesCount >= 10&&season=="Winter")
                    {
                        flowersPrice *= 0.90;
                    }
                    break;
                case "Spring":
                case "Summer":
                    flowersPrice = (daisyesCount * 2) + (rosesCount * 4.1) + (tulipsCount *2.5);
                    if (isHoliday)
                    {
                        flowersPrice *= 1.15;
                    }
                    if (tulipsCount>7&&season=="Spring")
                    {
                        flowersPrice *= 0.95;
                    }
                    break;
            }
            if (flowersCount>20)
            {
                flowersPrice *= 0.8;
            }
            Console.WriteLine($"{flowersPrice+2 :f2}");

        }
            
    }
}
