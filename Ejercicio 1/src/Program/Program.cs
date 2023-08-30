using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("C# CheatSheet","ProgrammingCracks","001-036");

            Shelve shelve1 = new Shelve(7);
            Shelve shelve2 = new Shelve(3);

            Sector sector1 = new Sector("A");
            Sector sector2 = new Sector("B");

            shelve1.AddBook(book1);
            shelve1.AddBook(book3);
            shelve2.AddBook(book2);

            sector1.AddShelve(shelve1);
            sector2.AddShelve(shelve2);
            
            Console.WriteLine($"The book is named {book1.Title}, it was written by {book1.Author}, its code is {book1.Code}");
            Console.WriteLine($"It can be found in the shelve {shelve1.Shelveid} which is in the sector {sector1.Sectorid}");
        }
    }
}