﻿using System;
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
        }
    }
}