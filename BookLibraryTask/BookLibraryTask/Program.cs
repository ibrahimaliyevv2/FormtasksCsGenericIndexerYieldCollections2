using System;
using Models;
using Utilities;
namespace BookLibraryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Sherlock Holmes", 20, "Aghata", 200, 2);
            Book book2 = new Book("Sherlock Holmes2", 30, "Aghata", 300, 1);
            Book book3 = new Book("Sherlock Holmes3", 40, "Aghata", 400, 0);
            Library library = new Library();
            library.BookLimit = 2;
            library.AddBook(book2);
            library.AddBook(book1);
            library.AddBook(book3);
            book1.ShowInfo();
            book2.ShowInfo();
            book3.ShowInfo();
            book1.Sell();
            book1.ShowInfo();
        }
    }
}
