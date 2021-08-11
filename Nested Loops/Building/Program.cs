using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());
            for (int i = floorsCount; i >= 1; i--)
            {
                if (i==floorsCount)
                {
                    for (int i2 = 0; i2 <roomsPerFloor; i2++)
                    {
                        Console.Write($"L{i}{i2} ");                
                    }
                    Console.WriteLine();
                }         
                else if (i%2 != 0)
                {
                    for (int i3 = 0; i3 <roomsPerFloor; i3++)
                    {             
                        Console.Write($"A{i}{i3} ");
                    }
                    Console.WriteLine();
                }
                
                else 
                {
                    for (int i4 = 0; i4 <roomsPerFloor; i4++)
                    {        
                        Console.Write($"O{i}{i4} ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
