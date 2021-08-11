﻿using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsOpened = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tabsOpened; ++i)
            {
                if (salary <=0)
                {
                    break;
                }
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }

            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
                
            }
            
        }
    }
}
