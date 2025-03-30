using System;

namespace IndexOfElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 7, 23, 44, 57, 97 };

            Console.WriteLine("Введите элемент массива, номер которого хотите найти:  ");

            int arrayNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Номер вашего элемента:  ");

            int result = GetFirstIndex(myArray, arrayNumber);

            Console.WriteLine(result);
        }

        public static int GetFirstIndex(int[] array, int value)
        {
            int[] xxx = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }

            }

            return -1;
        }
    }
}
