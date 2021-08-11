using System;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double odd = 0;
            double even = 0;
            for (int i = number1 ; i <=number2; i++)
            {
                string toCheck = Convert.ToString(i);
                odd = 0;
                even = 0;
                for (int j = 0; j < toCheck.Length; j++)
                {
                    if (j%2==0)
                    {
                        odd += char.GetNumericValue(toCheck,j);
                    }
                    else
                    {
                        even += char.GetNumericValue(toCheck [j]);
                    }
                }
                if (even==odd)
                {
                    Console.Write(toCheck + " ");
                }
            }
        }
    }
}
