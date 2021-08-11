using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string alphabet = "abcdefghjjklmnopqrstuvwxyz";
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k <=l-1; k++)
                    {
                        for (int m = 0; m <= l-1; m++)
                        {
                            for (int o = 1; o<=n; o++)
                            {
                                if (o>j&&o>i)
                                {
                                    Console.Write($"{i}{j}{alphabet[k]}{alphabet[m]}{o} ");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
