using System;

namespace MovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double totalTickets = 0;
            double kidsT = 0;
            double studentT = 0;
            double standardT = 0;
            while (movieName!="Finish")
            {
                double freeSeats = double.Parse(Console.ReadLine());
                totalTickets = 0;
                for (double i=freeSeats; i>0; i--)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType=="End")
                    {
                        break;
                    }
                    else if (ticketType=="student")
                    {
                        studentT++;
                    }
                    else if (ticketType=="standard")
                    {
                        standardT++;
                    }
                    else if (ticketType=="kid")
                    {
                        kidsT++;
                    }
                    totalTickets++;
                }
                Console.WriteLine($"{movieName} - {(totalTickets/freeSeats)*100 :f2}% full.");
                movieName = Console.ReadLine();
            }
            totalTickets = (kidsT + standardT + studentT);
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentT/totalTickets)*100 :f2}% student tickets.");
            Console.WriteLine($"{(standardT / totalTickets) * 100 :f2}% standard tickets.");
            Console.WriteLine($"{(kidsT / totalTickets) * 100 :F2}% kids tickets.");
            
        }
    }
}
