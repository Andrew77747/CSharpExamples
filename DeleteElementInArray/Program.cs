using System;

namespace DeleteElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] realArray = new int[5] { 2, 3, 5, 7, 9 };

            //DeleteAnyElement(ref realArray, 1);

            DeleteLastElement(ref realArray);
        }

        public static void DeleteAnyElement(ref int[] myArray, int element)
        {
            var newArray = new int[myArray.Length - 1];

            for (int i = 0; i < element; i++)
            {
                newArray[i] = myArray[i];
            }

            for (int i = element; i < newArray.Length; i++)
            {
                newArray[i] = myArray[i + 1];
            }

            myArray = newArray;
        }


        public static void DeleteFirstElement(ref int[] myArray)
        {
            DeleteAnyElement(ref myArray, 0);
        }

        public static void DeleteLastElement(ref int[] myArray)
        {
            DeleteAnyElement(ref myArray, myArray.Length - 1);
        }
    }
}
