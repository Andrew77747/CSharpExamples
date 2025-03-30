using System;
using System.Collections.Generic;
using System.Linq;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>
            {
                1, 10, 2, 122, 15
            };

            List<int> y = new List<int>
            {
                1, 10, 2, 122, 15
            };

            Console.WriteLine(x.SequenceEqual(y));

            //x.Sort();

            //foreach (var a in x)
            //{
            //    Console.WriteLine(a);
            //}

            List<Person> person = new List<Person>()
            {
                new Person() {name = "Igor"},
                new Person() {name = "Andrew"},
                new Person() {name = "Fedya"},
                new Person() {name = "Max"},
            };

            List<Person> person2 = new List<Person>()
            {
                new Person() {name = "Igor"},
                new Person() {name = "Andrew"},
                new Person() {name = "Fedya"},
                new Person() {name = "Max"},
            };

            person.Sort();
            person2.Sort();

            foreach (var p in person)
            {
                Console.WriteLine(p.name);
            }

            foreach (var p in person2)
            {
                Console.WriteLine(p.name);
            }

            Console.WriteLine(person.SequenceEqual(person2));
        }
    }

    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public string name;

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(name, other.name, StringComparison.Ordinal);
        }

        public bool Equals(Person? other)
        {
            if (ReferenceEquals(other, null)) 
                return false;
            if (ReferenceEquals(this, other)) 
                return true;

            return name == other.name;
        }
    }
}
