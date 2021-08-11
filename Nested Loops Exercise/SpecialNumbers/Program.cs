using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int magic = 1111; magic < 9999; magic++)
            {
                flag = false;
                string magicAsString = magic.ToString();
                for (int i = 0; i < magicAsString.Length; i++)
                {

                    int digitOfMagic = int.Parse(magicAsString[i].ToString());
                    if (magicAsString.Contains('0'))
                    {
                        flag = true;
                        break;
                    }
                    else if (number % digitOfMagic != 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    continue;
                }
                Console.Write($"{magicAsString} ");

            }
        }
    }
}
