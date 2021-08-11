using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sportType = "";
            switch (groupType)
            {
                case "boys":
                    switch (season)
                    {
                        case "Winter":
                            sportType = "Judo";
                            pricePerNight = 9.6;
                            break;
                        case "Spring":
                            sportType = "Tennis";
                            pricePerNight = 7.2;
                            break;
                        case "Summer":
                            sportType = "Football";
                            pricePerNight = 15;
                            break;
                    }
                    break;
                case "girls":
                    switch (season)
                    {
                        case"Winter":
                            sportType = "Gymnastics";
                            pricePerNight = 9.6;
                            break;
                        case "Spring":
                            sportType = "Athletics";
                            pricePerNight = 7.2;
                            break;
                        case "Summer":
                            sportType = "Volleyball";
                            pricePerNight = 15;
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            sportType = "Ski";
                            pricePerNight = 10;
                            break;
                        case "Spring":
                            sportType = "Cycling";
                            pricePerNight = 9.5;
                            break;
                        case "Summer":
                            sportType = "Swimming";
                            pricePerNight = 20;
                            break;
                    }
                    break;
            }
            double totalPrice = (pricePerNight * nightsCount) *studentsCount;
            if (studentsCount>=50)
            {
                totalPrice *= 0.50;
            }
            else if (studentsCount>=20&&studentsCount<50)
            {
                totalPrice *= 0.85;
            }
            else if (studentsCount>=10&&studentsCount<20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
