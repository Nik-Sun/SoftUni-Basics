using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string salutation = "";
            if (gender == 'f')
            {
                if (age >=16)
                {
                    salutation += "Ms.";
                }
                else
                {
                    salutation += "Miss";
                }
            }
            else
            {
                if (age>=16)
                {
                    salutation += "Mr."; 
                }
                else
                {
                    salutation += "Master"; 
                }
            }
            Console.WriteLine(salutation);
        }
    }
}
