using System;

namespace my_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Book book = new Book.Book("Things Fall Apart");
            Console.WriteLine(book.GetTitle());
        }
    }
}
