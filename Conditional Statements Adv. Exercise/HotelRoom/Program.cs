using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;
            switch (month)
            {
                case "May":
                case "October":
                    if (nightsCount >7 && nightsCount <14)
                    {
                        studioPrice = (50 * nightsCount) * 0.95;
                        apartamentPrice = 65 * nightsCount;
                    }
                    else if (nightsCount >14)
                    {
                        studioPrice = (50 * nightsCount) * 0.70;
                        apartamentPrice = (65 * nightsCount) * 0.90;
                    }
                    else
                    {
                        studioPrice = (50 * nightsCount);
                        apartamentPrice = (65 * nightsCount);
                    }
                    break;

                case "June":
                case "September":
                    if (nightsCount >14)
                    {
                        studioPrice = (75.20 * nightsCount) * 0.80;
                        apartamentPrice = (68.70 * nightsCount) * 0.9;
                    }
                    else 
                    {
                        studioPrice = (75.20 * nightsCount);
                        apartamentPrice = (68.70 * nightsCount);
                    }
                    break;

                case "July":
                case "August":
                    if (nightsCount >14)
                    {
                        apartamentPrice = (77 * nightsCount) * 0.9;
                    }
                    else
                    {
                        apartamentPrice = (77 * nightsCount);
                    }
                    studioPrice = (76 * nightsCount);
                    
                    break;
            }
            Console.WriteLine($"Apartment: {apartamentPrice :f2} lv.");
            Console.WriteLine($"Studio: {studioPrice :f2} lv.");

        }
    }
}
