using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            int stayNights = stayDays - 1;
            bool isEvaluationPositive = evaluation == "positive";
            double discount = 0;
            double price = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = stayNights * 18;
                    break;
                case "apartment":
                    if (stayDays < 10)
                    {
                        discount = 0.30;
                    }
                    else if (stayDays > 10 && stayDays <=15)
                    {
                        discount = 0.35;
                    }
                    else 
                    {
                        discount = 0.5;
                    }
                    price = stayNights * 25;
                
                    break;

                case "president apartment":
                    if (stayDays < 10)
                    {
                        discount = 0.10;
                    }
                    else if (stayDays > 10 && stayDays <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.2;
                    }
                    price = stayNights * 35;
                    break;

                default:
                    break;
            }
            double totalPrice = price - (price * discount);


           
            if (isEvaluationPositive)
            {
                Console.WriteLine($"{totalPrice + (totalPrice * 0.25) :f2}");
            }
            else
            {
                Console.WriteLine($"{totalPrice - (totalPrice * 0.1):f2}");
            }
        }
    }
}
