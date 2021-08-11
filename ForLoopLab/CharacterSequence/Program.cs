using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = Console.ReadLine();
            for (int i = 0; i < userString.Length; i++)
            {
                Console.WriteLine(userString[i]);
            }
        }
    }
}
