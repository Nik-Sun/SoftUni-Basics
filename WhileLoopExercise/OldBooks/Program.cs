using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            int booksChecked = 0;
            string bookPicked = Console.ReadLine();
            while (bookPicked != "No More Books")
            {
                
                if (bookPicked == bookToFind)
                {
                    break;
                }
                booksChecked++;
                bookPicked = Console.ReadLine();
            }
            if (bookPicked == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }
            else
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }
        }
    }
}
