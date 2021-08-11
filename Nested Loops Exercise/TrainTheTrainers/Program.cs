using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalGrade = 0;
            int totalPresentations=0;
            while (presentation!="Finish")
            {
                totalPresentations++;
                double presentationGrade = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    presentationGrade += grade;
                }
                Console.WriteLine($"{presentation} - {presentationGrade/juryCount :f2}.");
                totalGrade += (presentationGrade/juryCount);
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalGrade/totalPresentations :f2}.");


        }
    }
}
