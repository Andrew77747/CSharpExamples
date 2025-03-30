using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Recurcion
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 5, 10 };

            int number = 561;

            //ShowArrayFromSimpleCode(myArray);
            //SumFromSimpleCode(myArray);
            //int result = SumNumberRecursion(number);
            //Console.WriteLine(result);
            //int result = Sum3(myArray);
            //Console.WriteLine(result);
            //ShowArray(myArray, 0);


        }

        //Вывод массива с помощью рекурсии

        //мой методы
        public static void ShowArray(int[] array, int i)
        {
            Console.WriteLine(array[i]);
            i++;
            if (i == array.Length)
                return;
            ShowArray(array, i);
        }

        //пример с ютуб
        public static void ShowArrayFromSimpleCode(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                ShowArrayFromSimpleCode(myArray, i + 1);
            }
        }


        //Сумма элементов массива

        //мой метод 1
        public static void Sum(int[] array, ref int result, int i = 0)
        {
            if (i < array.Length)
            {
                result += array[i];
                Sum(array, ref result, i + 1);
            }
        }

        //мой метод 2
        public static int Sum2(int[] array, int i = 0)
        {
            int result = 0;

            if (i < array.Length)
            {
                result = array[i] + Sum2(array, i + 1);
            }

            return result;
        }

        //мой метод3
        public static int Sum3(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;
            return array[i] + Sum3(array, i + 1);
        }

        //пример с ютуб
        public static int SumFromSimpleCode(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            int result = SumFromSimpleCode(myArray, i + 1);

            return myArray[i] + result;
        }

        //пример с ютуб
        public static int SumFromSimpleCode2(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            return myArray[i] + SumFromSimpleCode2(myArray, i + 1);
        }


        //найти сумму цифр числа

        //мой метод без рекурсии
        public static int SumNumber(int number)
        {
            string numberStr = Convert.ToString(number);

            int result = 0;

            for (int i = 0; i < numberStr.Length; i++)
            {
                string x = Convert.ToString(numberStr[i]);
                result += Convert.ToInt32(x);
            }

            return result;
        }

        //мой метод с рекурсией
        public static int SumNumberRecursion(int number, int i = 0)
        {
            string numberStr = Convert.ToString(number);

            if (i == numberStr.Length)
                return 0;
            string x = Convert.ToString(numberStr[i]);
            int result = Convert.ToInt32(x);

            return result + SumNumberRecursion(number, i + 1);
        }

        //Пример с ютуба с рекурсией
        public static int SumNumberRecursionFromSimpleCode(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;

            int nextValue = value / 10;
            return digit + SumNumberRecursionFromSimpleCode(nextValue);
        }

        //Пример с ютуба
        public static int SumNumberRecursionFromSimpleCode2(int value)
        {
            if (value < 10)
                return value;

            return value % 10 + SumNumberRecursionFromSimpleCode2(value / 10);
        }

        //Пример с ютуба без рекурсии
        public static int SumNumberFromSimpleCode(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result += value % 10;
                value /= 10;
            }

            return result;
        }
    }
}
