using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            int timeOfExamAsMinutes = (hoursOfExam * 60) + minutesOfExam;
            int timeOfArrivalAsMinutes = (arrivalHours * 60) + arrivalMinutes;
            int differenceInMinutes = Math.Abs(timeOfExamAsMinutes - timeOfArrivalAsMinutes);
            if (differenceInMinutes == 0)
            {
                Console.WriteLine("On time");
            }
            if (differenceInMinutes <=30 && timeOfExamAsMinutes > timeOfArrivalAsMinutes)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceInMinutes} minutes before the start");
            }
            else if (differenceInMinutes >30 &&differenceInMinutes <60 && timeOfExamAsMinutes > timeOfArrivalAsMinutes)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{differenceInMinutes} minutes before the start");
            }
            else if (differenceInMinutes >=60 && timeOfExamAsMinutes > timeOfArrivalAsMinutes)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{(differenceInMinutes/60)}:{differenceInMinutes%60 :D2} hours before the start");
            }
            else if (differenceInMinutes < 60 && timeOfExamAsMinutes < timeOfArrivalAsMinutes)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceInMinutes} minutes after the start");
            }
            else
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{(differenceInMinutes / 60)}:{differenceInMinutes % 60:D2} hours after the start");
            }

         
            
        }

}   }
