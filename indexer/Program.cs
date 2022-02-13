using System;

namespace indexer
{
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    class Company
    {
        Person[] personal;
        public Company(Person[] people) => personal = people;
        // индексатор
        public Person this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var microsoft = new Company(new[]
            {
                new Person("Tom"), new Person("Bob"), new Person("Sam"), new Person("Alice")
            });
            Person firstPerson = microsoft[0];

            Console.WriteLine(firstPerson.Name);  // Tom

            microsoft[0] = new Person("Mike");

            Console.WriteLine(microsoft[0].Name);  // Mike
        }
    }
}
