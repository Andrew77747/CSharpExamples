using System;
using System.Collections.Generic;
using System.Linq;

namespace CopyArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListToArray();
            //ListToArray2();
            //ArrayToArray();
            ListToList3();
        }

        public static void ListToArray()
        {
            List<string> myList = new List<string>() { "First element", "Second element", "Third element" };

            string[] array = myList.ToArray();
        }

        public static void ListToArray2()
        {
            List<string> myList = new List<string>() { "First element", "Second element", "Third element" };

            string[] myArray = new string [3];

            myList.CopyTo(myArray);
        }

        public static void ArrayToArray()
        {
            string[] firstArray = new string[3] { "First element", "Second element", "Third element" };

            string[] secondArray = new string[firstArray.Length];

            firstArray.CopyTo(secondArray, 0);
        }

        public static void ListToList()
        {
            List<string> firstList = new List<string>() { "First element", "Second element", "Third element" };

            List<string> secondList = new List<string>(firstList);
        }

        public static void ListToList2()
        {
            List<string> firstList = new List<string>() { "First element", "Second element", "Third element" };

            List<string> secondList = new List<string>();

            secondList.AddRange(firstList);
        }

        public static void ListToList3()
        {
            List<string> myList = new List<string>() { "First element", "Second element", "Third element" };

            string[] myArray = new string[myList.Count];

            myList.CopyTo(myArray);

            var myNewList = myArray.ToList();
        }
    }
}
