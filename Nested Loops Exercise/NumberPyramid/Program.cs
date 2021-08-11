using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            bool flag = false;
            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 0; columns < rows; columns++)
                {
                    
                    if (counter>number)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
