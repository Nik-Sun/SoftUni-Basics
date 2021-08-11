using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
           
            string familyName = Console.ReadLine();
         
            string age = Console.ReadLine();
       
            string city = Console.ReadLine();
            Console.WriteLine($"You are {name} {familyName}, a {age}-years old person from {city}.");
        }
    }
}
