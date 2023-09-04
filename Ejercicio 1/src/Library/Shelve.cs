using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> BooksList { get; set; }
        public int Shelveid { get; set; }
         public Shelve(int shelveid) // Se tiene que llamar igual que la clase
        {
            Shelveid=shelveid;
            BooksList= new List<Book>();
        }
        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }
    }
}