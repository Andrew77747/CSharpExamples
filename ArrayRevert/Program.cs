using System;
using System.Linq;

namespace ArrayRevert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 7, 9,};

            myArray = myArray.Reverse().ToArray();

            Array.Reverse(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
        }
    }
}
