using System;
using System.Runtime.Intrinsics.Arm;

namespace ArrayFromKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int [x];

            Console.WriteLine($"Введите числа массива. Вы можете ввести {x} чисел");
            //int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ваш массив: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }
    }
}
