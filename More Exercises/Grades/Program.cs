using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double topStudents = 0;
            double averageStudents = 0;
            double lowStudents = 0;
            double failedStudents = 0;
            double averageGrade = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade=double.Parse(Console.ReadLine());
                if (grade>=5)
                {
                    topStudents++;
                }
                else if (grade>=4&&grade<=4.99)
                {
                    averageStudents++;
                }
                else if (grade>=3&&grade<=3.99)
                {
                    lowStudents++;
                }
                else
                {
                    failedStudents++;
                }
                averageGrade += grade;
            }
            Console.WriteLine($"Top students: {(topStudents/numberOfStudents)*100 :f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(averageStudents / numberOfStudents) * 100 :f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(lowStudents / numberOfStudents) * 100 :f2}%");
            Console.WriteLine($"Fail: {(failedStudents / numberOfStudents) * 100 :f2}%");
            Console.WriteLine($"Average: {averageGrade/numberOfStudents :f2}");
        }
    }
}
