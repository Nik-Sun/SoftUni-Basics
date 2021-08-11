using System;

namespace SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            
            int minNumber = int.MaxValue;
            while (numAsString !="Stop")
            {
                int numAsInt = Convert.ToInt32(numAsString);
                if (numAsInt<minNumber)
                {
                    minNumber = numAsInt;
                }
                numAsString = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
