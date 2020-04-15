using System;
using System.Collections.Generic;
using System.Text;

namespace MenuPractise
{
    public class Person
    {       
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
