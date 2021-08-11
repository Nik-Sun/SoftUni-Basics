using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isnumberValid = (number >= 100 && number <= 200) || number == 0;
            if (!isnumberValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
