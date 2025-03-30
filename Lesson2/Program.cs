using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            int evenCountNumbers = 0;
            int oddCountNumbers = 0;

            int sumEven = 0;
            int sumOdd = 0;

            while (count < limit)
            {
                count++;

                if (count % 2 == 0)
                {
                    evenCountNumbers++;
                    sumEven += count;
                }
                else
                {
                    oddCountNumbers++;
                    sumOdd += count;
                }
            }

            Console.WriteLine("Вы ввели четных чисел: " + evenCountNumbers);
            Console.WriteLine("Вы ввели нечетных чисел: " + oddCountNumbers);

            Console.WriteLine("Сумма четных чисел: " + sumEven);
            Console.WriteLine("Сумма нечетных чисел: " + sumOdd);
        }
    }
}
