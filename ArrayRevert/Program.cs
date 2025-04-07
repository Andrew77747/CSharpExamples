using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRevert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 7, 9,};

            ShowReversedArray(myArray);
            SimpleArrayReverse(myArray);
            GetReversedArray(myArray);
            GetReversedList(myArray);
            GetMinAndMaxElements(myArray);
        }

        // Простой вывод массива задом наперед без сохранения в отдельный массив/лист
        private static void ShowReversedArray(int[] mass)
        {
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(mass[i]);
            }
        }

        // Переворачиваем все числа массива задом наперед с помощью команды Reverse
        private static void SimpleArrayReverse(int[] mass)
        {
            // первый вариант
            mass = mass.Reverse().ToArray();

            // второй вариант
            Array.Reverse(mass);

            Console.WriteLine(string.Join(", ", mass));
        }
        
        // Переворачиваем все числа массива задом наперед с сохранением в массив
        private static void GetReversedArray(int[] mass)
        {
            var reverseMass = new int[mass.Length];

            for (var i = 0; i < mass.Length; i++)
            {
                reverseMass[i] = mass[mass.Length - i - 1];
            }
            
            Console.WriteLine(string.Join(", ", reverseMass));
        }
        
        // Переворачиваем все числа массива задом наперед с сохранением в лист
        private static void GetReversedList(int[] mass)
        {
            var reversedArray = new List<int>();

            for (var i = mass.Length - 1; i >= 0; i--)
            {
                reversedArray.Add(mass[i]);
            }

            Console.WriteLine(string.Join(", ", reversedArray));
        }
        
        // Получаем минимальное и максимальное значение в массиве
        private static void GetMinAndMaxElements(int[] mass)
        {
            var min = mass[0];
            var max = mass[0];

            foreach (var a in mass)
            {
                if (min > a)
                    min = a;
                if (max < a)
                    max = a;
            }
            
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
