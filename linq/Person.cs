using System;

namespace linq
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void PrintPerson() => Console.WriteLine($"{FirstName}, {LastName}");
    }
}