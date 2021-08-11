using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeArea = cakeLenght * cakeWidth;       
            while (cakeArea>0)
            {
                string cakePieces = Console.ReadLine();
                if (cakePieces == "STOP")
                {
                    break;
                }
                  int cakePiecesAsInt = Convert.ToInt32(cakePieces);
                cakeArea -= cakePiecesAsInt;
            }
            if (cakeArea<=0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
        }
    }
}
