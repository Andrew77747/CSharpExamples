using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Миша");
            Person p2 = new Person("Миша");

            List<int> x = new List<int>() {1, 2, 3};
            List<int> y = new List<int>() {1, 2, 3};
            List<int> a = x;

            Console.WriteLine(x.Equals(y)); // False
            Console.WriteLine(x.Equals(a)); // True
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            // если параметр метода представляет тип Person
            // то возвращаем true, если имена совпадают
            if (obj is Person person)
                return Name == person.Name;
            return false;
        }
    }
}
