using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrades = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double scholarshipForGoodGrades = 0;
            if (averageGrades >= 5.50)
            {
                scholarshipForGoodGrades = Math.Floor(averageGrades * 25);
            }
            if (income < minimalSalary && averageGrades >= 4.50)
            {
                socialScholarship = Math.Floor(minimalSalary * 0.35);
            }
            if (socialScholarship > scholarshipForGoodGrades)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (scholarshipForGoodGrades > socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForGoodGrades} BGN");
            }
            else if (socialScholarship == scholarshipForGoodGrades && socialScholarship > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForGoodGrades} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
