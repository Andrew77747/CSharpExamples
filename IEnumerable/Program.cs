using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableQW
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();

            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
        }
    }

    class Week : IEnumerable
    {

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
}
