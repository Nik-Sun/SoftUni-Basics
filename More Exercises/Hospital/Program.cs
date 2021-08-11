using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int peroid = int.Parse(Console.ReadLine());
            
            int doctors = 7;
            int patientsChecked = 0;
            int patientsUnchecked = 0;
            int currentDay = 1;

            while (currentDay<=peroid)
            {
                int patientsCount = int.Parse(Console.ReadLine());
                if (currentDay%3==0)
                {
                    if (patientsUnchecked>patientsChecked)
                    {
                        doctors++;
                    }
                }
                if (patientsCount>=doctors)
                {
                    patientsChecked += doctors;
                    patientsUnchecked += patientsCount - doctors;
                }
                else if (patientsCount<doctors)
                {
                    patientsChecked += patientsCount;
                }
                currentDay++;
                
            }
            Console.WriteLine($"Treated patients: {patientsChecked}.");
            Console.WriteLine($"Untreated patients: {patientsUnchecked}.");
        }
    }
}
