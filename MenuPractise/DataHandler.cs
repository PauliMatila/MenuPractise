using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPractise
{
    public class DataHandler
    {
        public List<Person> people = new List<Person>();

        public Person CreatePerson()
        {
            Console.WriteLine("Input firstname:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input lastname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input age:");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(firstName, lastName, age);
            return person;
        }

        public Person AddPersonToList()
        {
            Person person = CreatePerson();
            people.Add(person);
            return person;
        }

        public void PrintPersonList()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {people[i].firstName} {people[i].lastName} {people[i].age}");
                people.OrderBy(p => p.firstName);
            }
        }
    }
}
