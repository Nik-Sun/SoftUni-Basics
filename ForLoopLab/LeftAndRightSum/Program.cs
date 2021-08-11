using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int number = 0;
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < userNumber*2; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i <userNumber)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
                
            }
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
            
        }
    }
}
