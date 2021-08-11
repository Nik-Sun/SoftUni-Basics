using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string screeningType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int columnsCount = int.Parse(Console.ReadLine());
            double sales = 0;
            switch (screeningType)
            {
                case "Premiere":
                    sales = (rowsCount * columnsCount) * 12;
                    break;
                case "Normal":
                    sales = (rowsCount * columnsCount) * 7.50;
                    break;
                case "Discount":
                    sales = (rowsCount * columnsCount) * 5;
                    break;
            }
            Console.WriteLine($"{sales :f2}");
        }
    }
}
