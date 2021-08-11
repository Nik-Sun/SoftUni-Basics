using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometricFigure = Console.ReadLine();
            if (geometricFigure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideOfSquare*sideOfSquare :f3}");
            }
            else if (geometricFigure == "rectangle")
            {
                double rectangleHeight = double.Parse(Console.ReadLine());
                double rectangleWidth = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ rectangleHeight * rectangleWidth :f3}");
            }
            else if (geometricFigure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*(circleRadius*circleRadius):f3}");
            }
            else if (geometricFigure == "triangle")
            {
                double triangleSideLenght = double.Parse(Console.ReadLine());
                double triangleSideHeight = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(triangleSideLenght * 0.5)* triangleSideHeight :f3}");
            }
        }
    }
}
