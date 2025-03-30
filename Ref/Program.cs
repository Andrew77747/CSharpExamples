using System;
using System.Linq;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] realArray = new int[5] { 2, 3, 5, 7, 9 };

            //Resize2(ref realArray, -7);

            //AddElement(ref realArray, 111, "AnyElement", 3);

            //AddElementFirst(ref realArray, 111);

            //AddElementLast(ref realArray, 222);

            //AddElementAny(ref realArray, 2, 555);

            AddElementFirst2(ref realArray, 123);

            AddElementLast2(ref realArray, 777);

            AddElementAny3(ref realArray, 1, 12345);

            //NewResize(ref realArray, 10);

        }

        public static void NewResize(ref int[] myArray, int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < myArray.Length && i < newArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            myArray = newArray;
        }

        public static void Resize(ref int[] myArray, int elementCount, char symbol)
        {
            switch (symbol)
            {
                case '-':
                    if (myArray.Length - elementCount > 0)
                    {
                        int newElementCountMinus = myArray.Length - elementCount;
                        myArray = new int[newElementCountMinus];
                    }
                    else
                    {
                        Console.WriteLine("Введите правильный размер массива");
                    }
                    break;
                case '+':
                    int newElementCountPlus = myArray.Length + elementCount;
                    myArray = new int[newElementCountPlus];
                    break;
            }
        }

        public static void Resize2(ref int[] myArray, int elementCount)
        {
            if (elementCount < 0)
            {
                if (myArray.Length + elementCount > 0)
                {
                    int newElementCountMinus = myArray.Length + elementCount;
                    myArray = new int[newElementCountMinus];
                }
                else
                {
                    Console.WriteLine("Введите правильный размер массива");
                }
            }
            else
            {
                int newElementCountPlus = myArray.Length + elementCount;
                myArray = new int[newElementCountPlus];
            }
        }


        //public static void AddElement(ref int[] myArray, int addingElement, string element, int elementIndex = 0)
        //{
        //    if (myArray.Length >= elementIndex && elementIndex >= 0)
        //    {
        //        switch (element)
        //        {
        //            case "FirstElement":
        //                myArray[0] = addingElement;
        //                break;
        //            case "LastElement":
        //                int lastElement = myArray.Length - 1;
        //                myArray[lastElement] = addingElement;
        //                break;
        //            case "AnyElement":
        //                myArray[elementIndex] = addingElement;
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введите правильный размер массива");
        //    }
        //}

        public static void AddElementFirst(ref int[] myArray, int addingElement)
        {
            myArray[0] = addingElement;
        }

        public static void AddElementFirst2(ref int[] myArray, int addingElement)
        {
            var newArray = new int[myArray.Length + 1];

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = myArray[i - 1];
            }

            newArray[0] = addingElement;

            myArray = newArray;
        }

        public static void AddElementLast2(ref int[] myArray, int addingElement)
        {
            var newArray = new int[myArray.Length + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[newArray.Length - 1] = addingElement;

            myArray = newArray;
        }

        public static void AddElementLast(ref int[] myArray, int addingElement)
        {
            int lastElement = myArray.Length - 1;
            myArray[lastElement] = addingElement;
        }

        public static void AddElementAny(ref int[] myArray, int elementIndex, int addingElement)
        {
            if (myArray.Length > elementIndex && elementIndex >= 0)
            {
                myArray[elementIndex] = addingElement;
            }
            else
            {
                Console.WriteLine("Введите правильный размер массива");
            }
        }

        public static void AddElementAny2(ref int[] myArray, int elementIndex, int addingElement)
        {
            var newArray = new int[myArray.Length + 1];

            for (int i = 0; i < elementIndex - 1 && i > elementIndex + 1 && i < newArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[elementIndex] = addingElement;

            myArray = newArray;
        }

        public static void AddElementAny3(ref int[] myArray, int elementIndex, int addingElement)
        {
            var newArray = new int[myArray.Length + 1];

            for (int i = 0; i < elementIndex; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[elementIndex] = addingElement;

            for (int i = elementIndex + 1; i < newArray.Length; i++)
            {
                newArray[i] = myArray[i-1];
            }

            myArray = newArray;
        }


        //public int FiveAndFifteen(int x)
        //{
        //    if (x % 5 == 0)
        //    {
        //        Console.WriteLine("Число делиться только на 5");
        //    }
        //    if (x % 15 == 0)
        //    {
        //        Console.WriteLine("Число делиться только на 15");
        //    }
        //}
    }
}
