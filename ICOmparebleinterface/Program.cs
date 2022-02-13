using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;

namespace ICOmparebleinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new Person("Tom", 37);
            var bob = new Person("Bob", 41);
            var sam = new Person("Sam", 25);
            Person[] people = { tom, bob, sam };
            List<Person> People = new List<Person>() { tom, bob, sam, };
            Array.Sort(people);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine(new string('x', 20));
            foreach (var item in People)
            {
                if (item.Age>30)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
        }
    }
    class Person : IComparable, IEnumerable
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public int CompareTo(object? o)
        {
            if (o is Person person) return Name.CompareTo(person.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        public IEnumerator GetEnumerator()
        {
            yield break;
        }
    }
}
