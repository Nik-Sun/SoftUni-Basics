using System;

namespace Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)

        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesPlusFifteen = minutes + 15;
            if (minutesPlusFifteen >=60)
            {
                minutesPlusFifteen = minutesPlusFifteen % 60;
                hours++;
            }
            if (hours==24)
            {
                hours = 0;
            }
            if (minutesPlusFifteen <10)
            {
                Console.WriteLine($"{hours}:0{minutesPlusFifteen}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutesPlusFifteen}");
            }
        }
        

	}
    
}