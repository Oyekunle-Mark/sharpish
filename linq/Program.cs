using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person> {
                new Person() { FirstName = "Mark", LastName = "Fish", Age = 21 },
                new Person() { FirstName = "Tom", LastName = "Jerry", Age = 12 },
                new Person() { FirstName = "Egunjobi", LastName = "Alabi", Age = 34 }
            };

            IEnumerable<Person> adults =
                from person in allPeople
                where person.Age >= 18
                orderby person.Age descending
                select person;

            foreach (Person p in adults)
            {
                p.PrintPerson();
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void PrintPerson() => Console.WriteLine($"{FirstName}, {LastName}");
    }
}
