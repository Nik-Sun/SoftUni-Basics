using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradesLimit = int.Parse(Console.ReadLine());
            int badGrades = 0;
            int problemsCount = 0;
            double averageGrade = 0;
            string lastProblemName = "";
            while (badGrades<badGradesLimit)
            {
                string problemName = Console.ReadLine();
                if (problemName=="Enough")
                {
                    break;
                }
                problemsCount++;
                lastProblemName = problemName;
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    badGrades++;
                }
                averageGrade += grade;
                
            }
            if (badGrades >= badGradesLimit)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageGrade/problemsCount :f2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
        }
    }
}
