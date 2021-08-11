using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = (Console.ReadLine());
            int maxNumber = int.MinValue;
            while (numberAsString!="Stop")
            {
               int numberAsInt = Convert.ToInt32(numberAsString);
                if (numberAsInt>maxNumber)
                {
                    maxNumber = numberAsInt;
                }
                numberAsString = (Console.ReadLine());
            }
            Console.WriteLine(maxNumber);
        }
    }
}
