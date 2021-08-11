using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double courseLenghtInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsPer1Meter = double.Parse(Console.ReadLine());
            double timeNeeded = courseLenghtInMeters * timeInSecondsPer1Meter;
            double SecondsAddedDueWaterDrag = Math.Floor(courseLenghtInMeters / 15) * 12.5;
            double totalTime = timeNeeded + SecondsAddedDueWaterDrag;
            if (totalTime>=recordTime)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordTime-totalTime) :F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime :F2} seconds.");
            }
        }
    }
}
