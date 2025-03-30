using System;

namespace MinimumNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 4, 7, 9, 2, 12, 20, 23, 30, 31, 40 };

            int minimalNumber = myArray[0];


            for (int i = 0; i < myArray.Length; i++)
            {

                if (minimalNumber > myArray[i])
                {
                    minimalNumber = myArray[i];
                }
            }

            Console.WriteLine(minimalNumber);
        }
    }
}
