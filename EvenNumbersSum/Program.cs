using System;

namespace EvenNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 7, 9, 12, 20, 23, 30, 31, 40 };

            int evenNumbersSum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenNumbersSum += myArray[i];
                }
            }

            Console.WriteLine(evenNumbersSum);
        }
    }
}
