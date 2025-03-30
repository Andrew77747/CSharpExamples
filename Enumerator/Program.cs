using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers numbers = new Numbers();
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}


            //foreach (var n in 5) 
            //    Console.WriteLine(n);
            foreach (var n in -5) 
                Console.WriteLine(n);

        }
    }

    class Numbers
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i * i;
            }
        }
    }

    static class Int32Extension
    {
        public static IEnumerator<int> GetEnumerator(this int number)
        {
            int k = (number > 0) ? number : 0;
            for (int i = number - k; i <= k; i++) yield return i;
        }

 
    }
}
