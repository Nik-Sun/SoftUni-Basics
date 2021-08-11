using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            if ((N2 ==0 && operation =='/') || N2 == 0 && operation == '%')
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        result = N1 + N2;
                        if (result % 2 ==0)
                        {
                            Console.WriteLine($"{N1} + {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} + {N2} = {result} - odd");
                        }
                        break;
                    case '-':
                        result = N1 - N2;
                        if (result %2==0)
                        {
                            Console.WriteLine($"{N1} - {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} - {N2} = {result} - odd");
                        }
                        break;
                    case '*':
                        result = N1 * N2;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{N1} * {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} * {N2} = {result} - odd");
                        }
                        break;
                    case '/':
                        result = (N1/N2);
                        Console.WriteLine($"{N1} / {N2} = {result :f2}");
                        break;
                    case '%':
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result}");
                        break;

                }
            }
        }
    }
}
