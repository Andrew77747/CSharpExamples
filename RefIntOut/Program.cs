using System;

namespace RefInOut
{
    public class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int a = 2; 
            int b = 3;
            RefInOut.Sum(ref summa, a, b);
            Console.WriteLine(summa);

            int[] myArray = new int[3] { 1, 2 ,5 };
            RefInOut.DeleteArray(ref myArray);
            Console.WriteLine(myArray);
        }
    }

    public class RefInOut
    {
        public static void Sum(ref int sum, int a, int b)
        {
            sum = a + b; 
        }

        public static void DeleteArray(ref int[] array)
        {
            array = null;
        }
    }
}
