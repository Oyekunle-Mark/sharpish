using System;

namespace Book
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
