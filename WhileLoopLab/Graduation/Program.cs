using System;

namespace Graduation
{
    class Program
    {

        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double averageGrade = 0;
            int studentClass = 1;
            int timesFailed = 0;
            while (timesFailed < 2 && studentClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    averageGrade += grade;
                    timesFailed++;

                }
                else
                {
                    studentClass++;
                    averageGrade += grade;

                }


            }
            if (timesFailed == 2)
            {
                Console.WriteLine($"{studentName} has been excluded at {studentClass} grade");
            }
            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade / 12:f2}"
);
            }


        }


    }


}



