using System;

namespace Book
{
    class Book
    {
        private string title;
        public Book(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}