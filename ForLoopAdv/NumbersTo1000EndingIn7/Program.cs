using System;

namespace NumbersTo1000EndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <=1000; i++)
            {
                if (i % 10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
